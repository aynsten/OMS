﻿namespace OSM
{
    partial class FormOSM_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOSM_Main));
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_username = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_date = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.TSMItem_Offers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_offer_add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_offer_query = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_offer_aduit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_Orders = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_order_query = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_order_delivery = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_OrderDelivery_Audit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_Purchase = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_purchase_query = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_purchase_arrive = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_Deliver = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_deliver_query = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_deliver_pay = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_Delivery_Arrive = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_Pay = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_PayList = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_change_pwd = new System.Windows.Forms.ToolStripMenuItem();
            this.TStMItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.TSMItem_PayList_Pay = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Main.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_username,
            this.toolStripStatusLabel_date});
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 550);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip_Main.Size = new System.Drawing.Size(1058, 22);
            this.statusStrip_Main.TabIndex = 2;
            this.statusStrip_Main.Text = "statusStrip";
            // 
            // toolStripStatusLabel_username
            // 
            this.toolStripStatusLabel_username.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel_username.Name = "toolStripStatusLabel_username";
            this.toolStripStatusLabel_username.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel_username.Text = "用户名";
            // 
            // toolStripStatusLabel_date
            // 
            this.toolStripStatusLabel_date.Name = "toolStripStatusLabel_date";
            this.toolStripStatusLabel_date.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel_date.Text = "日期";
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItem_Offers,
            this.TSMItem_Orders,
            this.TSMItem_Purchase,
            this.TSMItem_Deliver,
            this.TSMItem_Pay,
            this.TSMItem_Options});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(1058, 25);
            this.menuStrip_Main.TabIndex = 3;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // TSMItem_Offers
            // 
            this.TSMItem_Offers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItem_offer_add,
            this.TSMItem_offer_query,
            this.TSMItem_offer_aduit});
            this.TSMItem_Offers.Name = "TSMItem_Offers";
            this.TSMItem_Offers.Size = new System.Drawing.Size(80, 21);
            this.TSMItem_Offers.Text = "报价单管理";
            // 
            // TSMItem_offer_add
            // 
            this.TSMItem_offer_add.Name = "TSMItem_offer_add";
            this.TSMItem_offer_add.Size = new System.Drawing.Size(136, 22);
            this.TSMItem_offer_add.Text = "新增报价单";
            this.TSMItem_offer_add.Click += new System.EventHandler(this.TSMItem_offer_add_Click);
            // 
            // TSMItem_offer_query
            // 
            this.TSMItem_offer_query.Name = "TSMItem_offer_query";
            this.TSMItem_offer_query.Size = new System.Drawing.Size(136, 22);
            this.TSMItem_offer_query.Text = "报价单查询";
            this.TSMItem_offer_query.Click += new System.EventHandler(this.TSMItem_offer_query_Click);
            // 
            // TSMItem_offer_aduit
            // 
            this.TSMItem_offer_aduit.Name = "TSMItem_offer_aduit";
            this.TSMItem_offer_aduit.Size = new System.Drawing.Size(136, 22);
            this.TSMItem_offer_aduit.Text = "报价单审核";
            this.TSMItem_offer_aduit.Click += new System.EventHandler(this.TSMItem_offer_aduit_Click);
            // 
            // TSMItem_Orders
            // 
            this.TSMItem_Orders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItem_order_query,
            this.TSMItem_order_delivery,
            this.TSMItem_OrderDelivery_Audit});
            this.TSMItem_Orders.Name = "TSMItem_Orders";
            this.TSMItem_Orders.Size = new System.Drawing.Size(68, 21);
            this.TSMItem_Orders.Text = "订单管理";
            // 
            // TSMItem_order_query
            // 
            this.TSMItem_order_query.Name = "TSMItem_order_query";
            this.TSMItem_order_query.Size = new System.Drawing.Size(148, 22);
            this.TSMItem_order_query.Text = "订单查询";
            this.TSMItem_order_query.Click += new System.EventHandler(this.TSMItem_order_query_Click);
            // 
            // TSMItem_order_delivery
            // 
            this.TSMItem_order_delivery.Name = "TSMItem_order_delivery";
            this.TSMItem_order_delivery.Size = new System.Drawing.Size(148, 22);
            this.TSMItem_order_delivery.Text = "订单采购审核";
            this.TSMItem_order_delivery.Click += new System.EventHandler(this.TSMItem_order_delivery_Click);
            // 
            // TSMItem_OrderDelivery_Audit
            // 
            this.TSMItem_OrderDelivery_Audit.Name = "TSMItem_OrderDelivery_Audit";
            this.TSMItem_OrderDelivery_Audit.Size = new System.Drawing.Size(148, 22);
            this.TSMItem_OrderDelivery_Audit.Text = "订单发货审核";
            this.TSMItem_OrderDelivery_Audit.Click += new System.EventHandler(this.TSMItem_OrderDelivery_Audit_Click);
            // 
            // TSMItem_Purchase
            // 
            this.TSMItem_Purchase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItem_purchase_query,
            this.TSMItem_purchase_arrive});
            this.TSMItem_Purchase.Name = "TSMItem_Purchase";
            this.TSMItem_Purchase.Size = new System.Drawing.Size(68, 21);
            this.TSMItem_Purchase.Text = "采购管理";
            // 
            // TSMItem_purchase_query
            // 
            this.TSMItem_purchase_query.Name = "TSMItem_purchase_query";
            this.TSMItem_purchase_query.Size = new System.Drawing.Size(136, 22);
            this.TSMItem_purchase_query.Text = "采购单查询";
            this.TSMItem_purchase_query.Click += new System.EventHandler(this.TSMItem_purchase_query_Click);
            // 
            // TSMItem_purchase_arrive
            // 
            this.TSMItem_purchase_arrive.Name = "TSMItem_purchase_arrive";
            this.TSMItem_purchase_arrive.Size = new System.Drawing.Size(136, 22);
            this.TSMItem_purchase_arrive.Text = "采购到货";
            this.TSMItem_purchase_arrive.Click += new System.EventHandler(this.TSMItem_purchase_arrive_Click);
            // 
            // TSMItem_Deliver
            // 
            this.TSMItem_Deliver.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItem_deliver_query,
            this.TSMItem_deliver_pay,
            this.TSMItem_Delivery_Arrive});
            this.TSMItem_Deliver.Name = "TSMItem_Deliver";
            this.TSMItem_Deliver.Size = new System.Drawing.Size(68, 21);
            this.TSMItem_Deliver.Text = "发货管理";
            // 
            // TSMItem_deliver_query
            // 
            this.TSMItem_deliver_query.Name = "TSMItem_deliver_query";
            this.TSMItem_deliver_query.Size = new System.Drawing.Size(136, 22);
            this.TSMItem_deliver_query.Text = "发货单查询";
            this.TSMItem_deliver_query.Click += new System.EventHandler(this.TSMItem_deliver_query_Click);
            // 
            // TSMItem_deliver_pay
            // 
            this.TSMItem_deliver_pay.Name = "TSMItem_deliver_pay";
            this.TSMItem_deliver_pay.Size = new System.Drawing.Size(136, 22);
            this.TSMItem_deliver_pay.Text = "发货确认";
            this.TSMItem_deliver_pay.Click += new System.EventHandler(this.TSMItem_deliver_pay_Click);
            // 
            // TSMItem_Delivery_Arrive
            // 
            this.TSMItem_Delivery_Arrive.Name = "TSMItem_Delivery_Arrive";
            this.TSMItem_Delivery_Arrive.Size = new System.Drawing.Size(136, 22);
            this.TSMItem_Delivery_Arrive.Text = "到货确认";
            this.TSMItem_Delivery_Arrive.Click += new System.EventHandler(this.TSMItem_Delivery_Arrive_Click);
            // 
            // TSMItem_Pay
            // 
            this.TSMItem_Pay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItem_PayList,
            this.TSMItem_PayList_Pay});
            this.TSMItem_Pay.Name = "TSMItem_Pay";
            this.TSMItem_Pay.Size = new System.Drawing.Size(68, 21);
            this.TSMItem_Pay.Text = "付款管理";
            // 
            // TSMItem_PayList
            // 
            this.TSMItem_PayList.Name = "TSMItem_PayList";
            this.TSMItem_PayList.Size = new System.Drawing.Size(152, 22);
            this.TSMItem_PayList.Text = "收款单查询";
            this.TSMItem_PayList.Click += new System.EventHandler(this.TSMItem_PayList_Click);
            // 
            // TSMItem_Options
            // 
            this.TSMItem_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItem_change_pwd,
            this.TStMItem_about,
            this.TSMItem_exit});
            this.TSMItem_Options.Name = "TSMItem_Options";
            this.TSMItem_Options.Size = new System.Drawing.Size(68, 21);
            this.TSMItem_Options.Text = "系统设置";
            // 
            // TSMItem_change_pwd
            // 
            this.TSMItem_change_pwd.Name = "TSMItem_change_pwd";
            this.TSMItem_change_pwd.Size = new System.Drawing.Size(124, 22);
            this.TSMItem_change_pwd.Text = "修改密码";
            this.TSMItem_change_pwd.Click += new System.EventHandler(this.TSMItem_change_pwd_Click);
            // 
            // TStMItem_about
            // 
            this.TStMItem_about.Name = "TStMItem_about";
            this.TStMItem_about.Size = new System.Drawing.Size(124, 22);
            this.TStMItem_about.Text = "关于...";
            this.TStMItem_about.Click += new System.EventHandler(this.TStMItem_about_Click);
            // 
            // TSMItem_exit
            // 
            this.TSMItem_exit.Name = "TSMItem_exit";
            this.TSMItem_exit.Size = new System.Drawing.Size(124, 22);
            this.TSMItem_exit.Text = "退出";
            this.TSMItem_exit.Click += new System.EventHandler(this.TSMItem_exit_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Location = new System.Drawing.Point(12, 28);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1034, 519);
            this.panel_Main.TabIndex = 4;
            // 
            // TSMItem_PayList_Pay
            // 
            this.TSMItem_PayList_Pay.Name = "TSMItem_PayList_Pay";
            this.TSMItem_PayList_Pay.Size = new System.Drawing.Size(152, 22);
            this.TSMItem_PayList_Pay.Text = "付款确认";
            this.TSMItem_PayList_Pay.Click += new System.EventHandler(this.TSMItem_PayList_Pay_Click);
            // 
            // FormOSM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 572);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.statusStrip_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "FormOSM_Main";
            this.Text = "订单信息管理系统";
            this.statusStrip_Main.ResumeLayout(false);
            this.statusStrip_Main.PerformLayout();
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_username;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_date;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_Offers;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_offer_query;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_offer_add;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_Orders;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_order_query;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_order_delivery;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_Purchase;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_purchase_query;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_purchase_arrive;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_Deliver;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_deliver_query;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_deliver_pay;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_Options;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_change_pwd;
        private System.Windows.Forms.ToolStripMenuItem TStMItem_about;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_exit;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_offer_aduit;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_Pay;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_OrderDelivery_Audit;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_Delivery_Arrive;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_PayList;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_PayList_Pay;
    }
}