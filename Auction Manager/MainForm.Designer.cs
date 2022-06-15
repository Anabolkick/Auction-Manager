
namespace Auction_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_name = new System.Windows.Forms.Label();
            this.sell_requests_list_view = new System.Windows.Forms.ListView();
            this.prod_name = new System.Windows.Forms.TextBox();
            this.s_price_nud = new System.Windows.Forms.NumericUpDown();
            this.s_count_nud = new System.Windows.Forms.NumericUpDown();
            this.coint_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.prod_label = new System.Windows.Forms.Label();
            this.add_sellreq_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_count_nud = new System.Windows.Forms.NumericUpDown();
            this.add_buyreq_btn = new System.Windows.Forms.Button();
            this.b_price_nud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buy_requests_list_view = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MakeDeals_btn = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.s_price_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_count_nud)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b_count_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_price_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // login_name
            // 
            this.login_name.AutoSize = true;
            this.login_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_name.Location = new System.Drawing.Point(345, 9);
            this.login_name.Name = "login_name";
            this.login_name.Size = new System.Drawing.Size(98, 21);
            this.login_name.TabIndex = 0;
            this.login_name.Text = "Login: Name";
            // 
            // sell_requests_list_view
            // 
            this.sell_requests_list_view.HideSelection = false;
            this.sell_requests_list_view.Location = new System.Drawing.Point(14, 56);
            this.sell_requests_list_view.MultiSelect = false;
            this.sell_requests_list_view.Name = "sell_requests_list_view";
            this.sell_requests_list_view.Size = new System.Drawing.Size(311, 384);
            this.sell_requests_list_view.TabIndex = 2;
            this.sell_requests_list_view.UseCompatibleStateImageBehavior = false;
            this.sell_requests_list_view.View = System.Windows.Forms.View.Tile;
            this.sell_requests_list_view.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.sell_requests_list_view_ItemSelectionChanged);
            // 
            // prod_name
            // 
            this.prod_name.Location = new System.Drawing.Point(6, 46);
            this.prod_name.Name = "prod_name";
            this.prod_name.Size = new System.Drawing.Size(168, 23);
            this.prod_name.TabIndex = 3;
            // 
            // s_price_nud
            // 
            this.s_price_nud.Location = new System.Drawing.Point(6, 94);
            this.s_price_nud.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.s_price_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.s_price_nud.Name = "s_price_nud";
            this.s_price_nud.Size = new System.Drawing.Size(94, 23);
            this.s_price_nud.TabIndex = 4;
            this.s_price_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // s_count_nud
            // 
            this.s_count_nud.Location = new System.Drawing.Point(6, 142);
            this.s_count_nud.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.s_count_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.s_count_nud.Name = "s_count_nud";
            this.s_count_nud.Size = new System.Drawing.Size(94, 23);
            this.s_count_nud.TabIndex = 5;
            this.s_count_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // coint_label
            // 
            this.coint_label.AutoSize = true;
            this.coint_label.Location = new System.Drawing.Point(6, 124);
            this.coint_label.Name = "coint_label";
            this.coint_label.Size = new System.Drawing.Size(40, 15);
            this.coint_label.TabIndex = 6;
            this.coint_label.Text = "Count";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(6, 76);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(36, 15);
            this.price_label.TabIndex = 7;
            this.price_label.Text = "Price:";
            // 
            // prod_label
            // 
            this.prod_label.AutoSize = true;
            this.prod_label.Location = new System.Drawing.Point(6, 28);
            this.prod_label.Name = "prod_label";
            this.prod_label.Size = new System.Drawing.Size(85, 15);
            this.prod_label.TabIndex = 8;
            this.prod_label.Text = "Product name:";
            // 
            // add_sellreq_btn
            // 
            this.add_sellreq_btn.Location = new System.Drawing.Point(6, 173);
            this.add_sellreq_btn.Name = "add_sellreq_btn";
            this.add_sellreq_btn.Size = new System.Drawing.Size(168, 23);
            this.add_sellreq_btn.TabIndex = 9;
            this.add_sellreq_btn.Text = "Add Sell Request";
            this.add_sellreq_btn.UseVisualStyleBackColor = true;
            this.add_sellreq_btn.Click += new System.EventHandler(this.add_sellreq_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.s_count_nud);
            this.groupBox1.Controls.Add(this.prod_name);
            this.groupBox1.Controls.Add(this.add_sellreq_btn);
            this.groupBox1.Controls.Add(this.s_price_nud);
            this.groupBox1.Controls.Add(this.prod_label);
            this.groupBox1.Controls.Add(this.coint_label);
            this.groupBox1.Controls.Add(this.price_label);
            this.groupBox1.Location = new System.Drawing.Point(345, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 208);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sell Request";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_count_nud);
            this.groupBox2.Controls.Add(this.add_buyreq_btn);
            this.groupBox2.Controls.Add(this.b_price_nud);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(345, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 159);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buy Request";
            // 
            // b_count_nud
            // 
            this.b_count_nud.Location = new System.Drawing.Point(6, 88);
            this.b_count_nud.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.b_count_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.b_count_nud.Name = "b_count_nud";
            this.b_count_nud.Size = new System.Drawing.Size(94, 23);
            this.b_count_nud.TabIndex = 5;
            this.b_count_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // add_buyreq_btn
            // 
            this.add_buyreq_btn.Location = new System.Drawing.Point(6, 124);
            this.add_buyreq_btn.Name = "add_buyreq_btn";
            this.add_buyreq_btn.Size = new System.Drawing.Size(168, 23);
            this.add_buyreq_btn.TabIndex = 9;
            this.add_buyreq_btn.Text = "Add Buy Request";
            this.add_buyreq_btn.UseVisualStyleBackColor = true;
            this.add_buyreq_btn.Click += new System.EventHandler(this.add_buyreq_btn_Click);
            // 
            // b_price_nud
            // 
            this.b_price_nud.Location = new System.Drawing.Point(6, 44);
            this.b_price_nud.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.b_price_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.b_price_nud.Name = "b_price_nud";
            this.b_price_nud.Size = new System.Drawing.Size(94, 23);
            this.b_price_nud.TabIndex = 4;
            this.b_price_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price:";
            // 
            // buy_requests_list_view
            // 
            this.buy_requests_list_view.HideSelection = false;
            this.buy_requests_list_view.Location = new System.Drawing.Point(563, 56);
            this.buy_requests_list_view.MultiSelect = false;
            this.buy_requests_list_view.Name = "buy_requests_list_view";
            this.buy_requests_list_view.Size = new System.Drawing.Size(311, 384);
            this.buy_requests_list_view.TabIndex = 13;
            this.buy_requests_list_view.UseCompatibleStateImageBehavior = false;
            this.buy_requests_list_view.View = System.Windows.Forms.View.Tile;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(673, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buy Requests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(99, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sell Requests";
            // 
            // MakeDeals_btn
            // 
            this.MakeDeals_btn.Location = new System.Drawing.Point(351, 455);
            this.MakeDeals_btn.Name = "MakeDeals_btn";
            this.MakeDeals_btn.Size = new System.Drawing.Size(168, 34);
            this.MakeDeals_btn.TabIndex = 16;
            this.MakeDeals_btn.Text = "Make Deals";
            this.MakeDeals_btn.UseVisualStyleBackColor = true;
            this.MakeDeals_btn.Click += new System.EventHandler(this.MakeDeals_btn_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(605, 455);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 20);
            this.error_label.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 501);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.MakeDeals_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buy_requests_list_view);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sell_requests_list_view);
            this.Controls.Add(this.login_name);
            this.Name = "MainForm";
            this.Text = "Auction Manager";
            ((System.ComponentModel.ISupportInitialize)(this.s_price_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_count_nud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b_count_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_price_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_name;
        private System.Windows.Forms.ListView sell_requests_list_view;
        private System.Windows.Forms.TextBox prod_name;
        private System.Windows.Forms.NumericUpDown s_price_nud;
        private System.Windows.Forms.NumericUpDown s_count_nud;
        private System.Windows.Forms.Label coint_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label prod_label;
        private System.Windows.Forms.Button add_sellreq_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown b_count_nud;
        private System.Windows.Forms.Button add_buyreq_btn;
        private System.Windows.Forms.NumericUpDown b_price_nud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView buy_requests_list_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MakeDeals_btn;
        private System.Windows.Forms.Label error_label;
    }
}