using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using AuctionLibrary;
using Microsoft.EntityFrameworkCore;

namespace Auction_Manager
{
    public partial class MainForm : Form
    {
        public User Current_user;
        public MainForm()
        {
            InitializeComponent();
            LoadData();
            if (Current_user == null)
            {
                LoginForm loginForm = new LoginForm(this);
                loginForm.ShowDialog();
                using AppDbContext db = new AppDbContext();
                Current_user = db.Users.FirstOrDefault(user => user.Login == Current_user.Login);
            }

            login_name.Text = $"Login: {Current_user.Login}";
            RefreshSellView();
        }

        private void LoadData()
        {
            using (AppDbContext db = new AppDbContext())
            {
                var buyRequests = db.BuyRequests.ToList();
                var sellRequests = db.SellRequests.ToList();
                DealManager.BuyRequests = buyRequests;
                DealManager.SellRequests = sellRequests;
            }
        }

        private void RefreshSellView()
        {
            sell_requests_list_view.Clear();
            foreach (var sellRequest in DealManager.SellRequests)
            {
                var item = new ListViewItem
                {
                    Tag = sellRequest,
                    Text = $@"Product: {sellRequest.Product}, price: {sellRequest.Price}, count: {sellRequest.Count}"
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
            MailMessage message = new MailMessage();
            try //incorrect email address
            {
                message = new MailMessage("peopletwo98@gmail.com", email);
                message.Subject = "Your request has been done!";
                if (request.GetType() == typeof(SellRequest))
                {
                    SellRequest sellReqest = (SellRequest)request;
                    message.Body = $"Your sell request was done! \n Id:{sellReqest.Id}, product: {sellReqest.Product}, count: {sellReqest.Count}, price: {sellReqest.Price}";
                }
                if (request.GetType() == typeof(BuyRequest))
                {
                    BuyRequest buyReqest = (BuyRequest)request;
                    message.Body = $"Your buy request was done! \n Id:{buyReqest.Id}, sell request id: {buyReqest.TargetSellRequest.Id}, count: {buyReqest.Count}, price: {buyReqest.Price}";
                }
                client.Send(message);
            }
            catch
            {

            }
        }

        private void add_sellreq_btn_Click(object sender, System.EventArgs e)
        {
            var sellRequest = new SellRequest((double)s_price_nud.Value, (int)s_count_nud.Value);

            using (AppDbContext db = new AppDbContext())
            {
                Current_user = db.Users.FirstOrDefault(user => user.Login == Current_user.Login);
                sellRequest = new SellRequest(prod_name.Text, (double)s_price_nud.Value, (int)s_count_nud.Value, Current_user);
                db.SellRequests.Add(sellRequest);
                db.SaveChanges();
            }

            sellRequest.OnDone += () => SendEmail(Current_user.Email, sellRequest);
            var item = new ListViewItem
            {
                Tag = sellRequest,
                Text = $@"Product: {sellRequest.Product}, price: {sellRequest.Price}, count: {sellRequest.Count}"
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
                if (sellRequest.Id == buyRequest.TargetSellRequest.Id)
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
                var buyRequest = new BuyRequest((double)b_price_nud.Value, (int)b_count_nud.Value);
                var sellRequest = (SellRequest)sell_requests_list_view.SelectedItems[0].Tag;
                if (sellRequest.Seller != Current_user)
                {
                    using (AppDbContext db = new AppDbContext())
                    {
                        Current_user = db.Users.FirstOrDefault(user => user.Login == Current_user.Login);
                        sellRequest = db.SellRequests.FirstOrDefault(Request => Request.Id == sellRequest.Id);
                        buyRequest = new BuyRequest((double)b_price_nud.Value, (int)b_count_nud.Value, Current_user, sellRequest);
                        db.BuyRequests.Add(buyRequest);
                        db.SaveChanges();
                    }

                    buyRequest.OnDone += () => SendEmail(Current_user.Email, buyRequest);
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
            MakeDeals();
            RefreshSellView();
            buy_requests_list_view.Clear();
        }

        private void MakeDeals()
        {
            DealManager.MakeDeals();
            using (AppDbContext db = new AppDbContext())
            {
                var closedbuy = new List<BuyRequest>();
                foreach (var request in DealManager.ClosedBuyRequests)
                {
                    closedbuy.Add(db.BuyRequests.FirstOrDefault(r => r.Id == request.Id));
                }
                db.BuyRequests.RemoveRange(closedbuy);

                var closedsell = new List<SellRequest>();
                foreach (var request in DealManager.ClosedSellRequests)
                {
                    closedsell.Add(db.SellRequests.FirstOrDefault(r => r.Id == request.Id));
                }
                db.SellRequests.RemoveRange(closedsell);
                db.SaveChanges();
            }
            DealManager.DeleteClosedRequests();

        }
    }
}
