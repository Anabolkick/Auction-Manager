using System;
using System.Net.Mail;
using System.Windows.Forms;
using AuctionLibrary;

namespace Auction_Manager
{
    public partial class MainForm : Form
    {
        public User User;
        public MainForm()
        {
            InitializeComponent();
            CreateExampleData();
            if (User == null)
            {
                LoginForm loginForm = new LoginForm(this);
                loginForm.ShowDialog();
            }

            login_name.Text = $"Login: {User.Login}";

            RefreshSellView();
        }

        private void CreateExampleData()
        {
            User user1 = new User("Oleg", "oleg10galysh@gmail.com", "Oleg");
            User user2 = new User("Ivan", "ivan@any.com", "Ivan");
            User user3 = new User("Egor", "egor@any.com", "Egor");

            SellRequest sell_req1 = new SellRequest(new Product("Apple"), 100, 1, user2);
            SellRequest sell_req2 = new SellRequest(new Product("Lemons"), 300, 3, user2);
            SellRequest sell_req3 = new SellRequest(new Product("Orange"), 150, 2, user1);

            BuyRequest buy_req1 = new BuyRequest(90, 1, user3, sell_req1.Id);
            BuyRequest buy_req2 = new BuyRequest(310, 4, user3, sell_req2.Id);
            BuyRequest buy_req3 = new BuyRequest(305, 2, user1, sell_req2.Id);
            BuyRequest buy_req4 = new BuyRequest(90, 1, user2, sell_req3.Id);

            UserManager.AddUser(user1);
            UserManager.AddUser(user2);
            UserManager.AddUser(user3);
            DealManager.SellRequests.AddRange(new[] { sell_req1, sell_req2, sell_req3 });
            DealManager.BuyRequests.AddRange(new[] { buy_req1, buy_req2, buy_req3, buy_req4 });
        }

        private void RefreshSellView()
        {
            sell_requests_list_view.Clear();
            foreach (var sellRequest in DealManager.SellRequests)
            {
                var item = new ListViewItem
                {
                    Tag = sellRequest,
                    Text = $@"Product: {sellRequest.Product.Name}, price: {sellRequest.Price}, count: {sellRequest.Count}"
                };
                sell_requests_list_view.Items.Add(item);
            }
        }

        private void SendEmail(string email, Request request)
        {
            using SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("peopletwo98@gmail.com", "cs18g1d91d");
            client.EnableSsl = true;

            MailMessage message = new MailMessage("peopletwo98@gmail.com", email);
            message.Subject = "Your request has been done!";
            if (request.GetType() == typeof(SellRequest))
            {
                SellRequest sellReqest = (SellRequest)request;
                message.Body = $"Your sell request was done! \n Id:{sellReqest.Id}, product: {sellReqest.Product.Name}, count: {sellReqest.Count}, price: {sellReqest.Price}";
            }
            if (request.GetType() == typeof(BuyRequest))
            {
                BuyRequest buyReqest = (BuyRequest)request;
                message.Body = $"Your buy request was done! \n Id:{buyReqest.Id}, sell request id: {buyReqest.SellRequestId}, count: {buyReqest.Count}, price: {buyReqest.Price}";
            }
            client.Send(message);
        }

        private void add_sellreq_btn_Click(object sender, System.EventArgs e)
        {
            var sellRequest = new SellRequest(new Product(prod_name.Text), (double)s_price_nud.Value, (int)s_count_nud.Value, User);
            sellRequest.OnDone += () => SendEmail(User.Email, sellRequest);
            var item = new ListViewItem
            {
                Tag = sellRequest,
                Text = $@"Product: {sellRequest.Product.Name}, price: {sellRequest.Price}, count: {sellRequest.Count}"
            };
            DealManager.SellRequests.Add(sellRequest);
            sell_requests_list_view.Items.Add(item);
        }

        private void sell_requests_list_view_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var sellRequest = (SellRequest)e.Item.Tag;
            RefreshBuyRequest(sellRequest);
            error_label.Text = "";
        }

        private void RefreshBuyRequest(SellRequest sellRequest)
        {
            buy_requests_list_view.Clear();
            foreach (var buyRequest in DealManager.BuyRequests)
            {
                if (sellRequest.Id == buyRequest.SellRequestId)
                {
                    var item = new ListViewItem
                    {
                        Tag = buyRequest,
                        Text = $@"User: {buyRequest.Buyer.Login}, price: {buyRequest.Price}, count: {buyRequest.Count}"
                    };
                    buy_requests_list_view.Items.Add(item);
                }
            }
        }

        private void add_buyreq_btn_Click(object sender, System.EventArgs e)
        {
            if (sell_requests_list_view.SelectedItems.Count > 0 && sell_requests_list_view.SelectedItems[0].Tag != null)
            {
                var sellRequest = (SellRequest)sell_requests_list_view.SelectedItems[0].Tag;
                if (sellRequest.Seller != User)
                {
                    var buyRequest = new BuyRequest((double)b_price_nud.Value, (int)b_count_nud.Value, User, sellRequest.Id);
                    buyRequest.OnDone += () => SendEmail(User.Email, buyRequest);
                    DealManager.BuyRequests.Add(buyRequest);
                    var item = new ListViewItem
                    {
                        Tag = buyRequest,
                        Text = $@"User: {buyRequest.Buyer.Login}, price: {buyRequest.Price}, count: {buyRequest.Count}"
                    };
                    buy_requests_list_view.Items.Add(item);
                }
                else
                {
                    error_label.Text = "You can`t buy your own product!";
                }
            }
        }


        private void MakeDeals_btn_Click(object sender, System.EventArgs e)
        {
            DealManager.MakeDeals();
            RefreshSellView();
            buy_requests_list_view.Clear();
        }
    }
}
