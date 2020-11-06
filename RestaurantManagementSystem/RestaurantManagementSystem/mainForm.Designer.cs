namespace RestaurantManagementSystem
{
    partial class mainForm
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
            this.pn_topBar = new System.Windows.Forms.Panel();
            this.pn_exitButton = new System.Windows.Forms.Panel();
            this.lb_activatingAccount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_appTitle = new System.Windows.Forms.Label();
            this.pn_leftTab = new System.Windows.Forms.Panel();
            this.pn_warehouseButton = new System.Windows.Forms.Panel();
            this.lb_warehouse = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pn_saleButton = new System.Windows.Forms.Panel();
            this.lb_sale = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_dashboardButton = new System.Windows.Forms.Panel();
            this.lb_dashboard = new System.Windows.Forms.Label();
            this.pn_icon_dashboard = new System.Windows.Forms.Panel();
            this.pn_switchableWndw = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_topBar.SuspendLayout();
            this.pn_leftTab.SuspendLayout();
            this.pn_warehouseButton.SuspendLayout();
            this.pn_saleButton.SuspendLayout();
            this.pn_dashboardButton.SuspendLayout();
            this.pn_switchableWndw.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_topBar
            // 
            this.pn_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(206)))), ((int)(((byte)(231)))));
            this.pn_topBar.Controls.Add(this.pn_exitButton);
            this.pn_topBar.Controls.Add(this.lb_activatingAccount);
            this.pn_topBar.Controls.Add(this.panel5);
            this.pn_topBar.Controls.Add(this.lb_appTitle);
            this.pn_topBar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pn_topBar.Location = new System.Drawing.Point(0, 0);
            this.pn_topBar.Name = "pn_topBar";
            this.pn_topBar.Size = new System.Drawing.Size(1270, 75);
            this.pn_topBar.TabIndex = 0;
            // 
            // pn_exitButton
            // 
            this.pn_exitButton.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.cancel;
            this.pn_exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_exitButton.Location = new System.Drawing.Point(1213, 12);
            this.pn_exitButton.Name = "pn_exitButton";
            this.pn_exitButton.Size = new System.Drawing.Size(45, 45);
            this.pn_exitButton.TabIndex = 3;
            this.pn_exitButton.Click += new System.EventHandler(this.pn_exitButton_Click);
            // 
            // lb_activatingAccount
            // 
            this.lb_activatingAccount.AutoSize = true;
            this.lb_activatingAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_activatingAccount.ForeColor = System.Drawing.Color.White;
            this.lb_activatingAccount.Location = new System.Drawing.Point(1064, 26);
            this.lb_activatingAccount.Name = "lb_activatingAccount";
            this.lb_activatingAccount.Size = new System.Drawing.Size(61, 21);
            this.lb_activatingAccount.TabIndex = 2;
            this.lb_activatingAccount.Text = "Admin";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.restaurant;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 75);
            this.panel5.TabIndex = 1;
            // 
            // lb_appTitle
            // 
            this.lb_appTitle.AutoSize = true;
            this.lb_appTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appTitle.ForeColor = System.Drawing.Color.White;
            this.lb_appTitle.Location = new System.Drawing.Point(196, 15);
            this.lb_appTitle.Name = "lb_appTitle";
            this.lb_appTitle.Size = new System.Drawing.Size(467, 47);
            this.lb_appTitle.TabIndex = 0;
            this.lb_appTitle.Text = "Phần mềm quản lý nhà hàng";
            // 
            // pn_leftTab
            // 
            this.pn_leftTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.pn_leftTab.Controls.Add(this.pn_warehouseButton);
            this.pn_leftTab.Controls.Add(this.pn_saleButton);
            this.pn_leftTab.Controls.Add(this.pn_dashboardButton);
            this.pn_leftTab.Location = new System.Drawing.Point(0, 75);
            this.pn_leftTab.Name = "pn_leftTab";
            this.pn_leftTab.Size = new System.Drawing.Size(205, 565);
            this.pn_leftTab.TabIndex = 1;
            // 
            // pn_warehouseButton
            // 
            this.pn_warehouseButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_warehouseButton.Controls.Add(this.lb_warehouse);
            this.pn_warehouseButton.Controls.Add(this.panel4);
            this.pn_warehouseButton.Location = new System.Drawing.Point(0, 130);
            this.pn_warehouseButton.Name = "pn_warehouseButton";
            this.pn_warehouseButton.Size = new System.Drawing.Size(204, 64);
            this.pn_warehouseButton.TabIndex = 2;
            this.pn_warehouseButton.Click += new System.EventHandler(this.pn_warehouseButton_Click);
            // 
            // lb_warehouse
            // 
            this.lb_warehouse.AutoSize = true;
            this.lb_warehouse.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_warehouse.Location = new System.Drawing.Point(72, 16);
            this.lb_warehouse.Name = "lb_warehouse";
            this.lb_warehouse.Size = new System.Drawing.Size(119, 30);
            this.lb_warehouse.TabIndex = 1;
            this.lb_warehouse.Text = "Warehouse";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.dashboard2;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(66, 64);
            this.panel4.TabIndex = 0;
            // 
            // pn_saleButton
            // 
            this.pn_saleButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_saleButton.Controls.Add(this.lb_sale);
            this.pn_saleButton.Controls.Add(this.panel2);
            this.pn_saleButton.Location = new System.Drawing.Point(0, 65);
            this.pn_saleButton.Name = "pn_saleButton";
            this.pn_saleButton.Size = new System.Drawing.Size(204, 64);
            this.pn_saleButton.TabIndex = 2;
            this.pn_saleButton.Click += new System.EventHandler(this.pn_saleButton_Click);
            // 
            // lb_sale
            // 
            this.lb_sale.AutoSize = true;
            this.lb_sale.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sale.Location = new System.Drawing.Point(72, 16);
            this.lb_sale.Name = "lb_sale";
            this.lb_sale.Size = new System.Drawing.Size(51, 30);
            this.lb_sale.TabIndex = 1;
            this.lb_sale.Text = "Sale";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.cena;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 64);
            this.panel2.TabIndex = 0;
            // 
            // pn_dashboardButton
            // 
            this.pn_dashboardButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_dashboardButton.Controls.Add(this.pn_icon_dashboard);
            this.pn_dashboardButton.Controls.Add(this.lb_dashboard);
            this.pn_dashboardButton.Location = new System.Drawing.Point(0, 0);
            this.pn_dashboardButton.Name = "pn_dashboardButton";
            this.pn_dashboardButton.Size = new System.Drawing.Size(204, 64);
            this.pn_dashboardButton.TabIndex = 0;
            this.pn_dashboardButton.Click += new System.EventHandler(this.pn_dashboardButton_Click);
            // 
            // lb_dashboard
            // 
            this.lb_dashboard.AutoSize = true;
            this.lb_dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dashboard.Location = new System.Drawing.Point(72, 16);
            this.lb_dashboard.Name = "lb_dashboard";
            this.lb_dashboard.Size = new System.Drawing.Size(118, 30);
            this.lb_dashboard.TabIndex = 1;
            this.lb_dashboard.Text = "Dashboard";
            // 
            // pn_icon_dashboard
            // 
            this.pn_icon_dashboard.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.dashboard2;
            this.pn_icon_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_icon_dashboard.Location = new System.Drawing.Point(0, 0);
            this.pn_icon_dashboard.Name = "pn_icon_dashboard";
            this.pn_icon_dashboard.Size = new System.Drawing.Size(64, 64);
            this.pn_icon_dashboard.TabIndex = 0;
            // 
            // pn_switchableWndw
            // 
            this.pn_switchableWndw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.pn_switchableWndw.Controls.Add(this.label1);
            this.pn_switchableWndw.Location = new System.Drawing.Point(204, 75);
            this.pn_switchableWndw.Name = "pn_switchableWndw";
            this.pn_switchableWndw.Size = new System.Drawing.Size(1066, 565);
            this.pn_switchableWndw.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "mainForm";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 640);
            this.Controls.Add(this.pn_switchableWndw);
            this.Controls.Add(this.pn_leftTab);
            this.Controls.Add(this.pn_topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Management System";
            this.pn_topBar.ResumeLayout(false);
            this.pn_topBar.PerformLayout();
            this.pn_leftTab.ResumeLayout(false);
            this.pn_warehouseButton.ResumeLayout(false);
            this.pn_warehouseButton.PerformLayout();
            this.pn_saleButton.ResumeLayout(false);
            this.pn_saleButton.PerformLayout();
            this.pn_dashboardButton.ResumeLayout(false);
            this.pn_dashboardButton.PerformLayout();
            this.pn_switchableWndw.ResumeLayout(false);
            this.pn_switchableWndw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_topBar;
        private System.Windows.Forms.Panel pn_leftTab;
        private System.Windows.Forms.Panel pn_dashboardButton;
        private System.Windows.Forms.Panel pn_icon_dashboard;
        private System.Windows.Forms.Label lb_dashboard;
        private System.Windows.Forms.Panel pn_warehouseButton;
        private System.Windows.Forms.Label lb_warehouse;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pn_saleButton;
        private System.Windows.Forms.Label lb_sale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_exitButton;
        private System.Windows.Forms.Label lb_activatingAccount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lb_appTitle;
        private System.Windows.Forms.Panel pn_switchableWndw;
        private System.Windows.Forms.Label label1;
    }
}

