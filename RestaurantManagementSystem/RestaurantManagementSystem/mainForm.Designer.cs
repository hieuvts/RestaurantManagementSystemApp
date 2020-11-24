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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pn_topBar = new System.Windows.Forms.Panel();
            this.pn_exitButton = new System.Windows.Forms.Panel();
            this.lb_activatingAccount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_appTitle = new System.Windows.Forms.Label();
            this.pn_leftTab = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.pn_switchableWndw = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_topBar.SuspendLayout();
            this.pn_leftTab.SuspendLayout();
            this.pn_switchableWndw.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_topBar
            // 
            this.pn_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pn_topBar.Controls.Add(this.pn_exitButton);
            this.pn_topBar.Controls.Add(this.lb_activatingAccount);
            this.pn_topBar.Controls.Add(this.panel5);
            this.pn_topBar.Controls.Add(this.lb_appTitle);
            this.pn_topBar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pn_topBar.Location = new System.Drawing.Point(0, 0);
            this.pn_topBar.Name = "pn_topBar";
            this.pn_topBar.Size = new System.Drawing.Size(1270, 50);
            this.pn_topBar.TabIndex = 0;
            // 
            // pn_exitButton
            // 
            this.pn_exitButton.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.cancel;
            this.pn_exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_exitButton.Location = new System.Drawing.Point(1230, 6);
            this.pn_exitButton.Name = "pn_exitButton";
            this.pn_exitButton.Size = new System.Drawing.Size(35, 35);
            this.pn_exitButton.TabIndex = 1;
            this.pn_exitButton.Click += new System.EventHandler(this.pn_exitButton_Click);
            // 
            // lb_activatingAccount
            // 
            this.lb_activatingAccount.AutoSize = true;
            this.lb_activatingAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(164)))), ((int)(((byte)(200)))));
            this.lb_activatingAccount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_activatingAccount.ForeColor = System.Drawing.Color.White;
            this.lb_activatingAccount.Location = new System.Drawing.Point(1100, 15);
            this.lb_activatingAccount.Name = "lb_activatingAccount";
            this.lb_activatingAccount.Size = new System.Drawing.Size(71, 25);
            this.lb_activatingAccount.TabIndex = 2;
            this.lb_activatingAccount.Text = "Admin";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.restaurant;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(7, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(43, 41);
            this.panel5.TabIndex = 1;
            // 
            // lb_appTitle
            // 
            this.lb_appTitle.AutoSize = true;
            this.lb_appTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appTitle.ForeColor = System.Drawing.Color.White;
            this.lb_appTitle.Location = new System.Drawing.Point(198, 8);
            this.lb_appTitle.Name = "lb_appTitle";
            this.lb_appTitle.Size = new System.Drawing.Size(386, 33);
            this.lb_appTitle.TabIndex = 0;
            this.lb_appTitle.Text = "Phần mềm quản lý nhà hàng";
            // 
            // pn_leftTab
            // 
            this.pn_leftTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pn_leftTab.Controls.Add(this.btnDashboard);
            this.pn_leftTab.Controls.Add(this.btnSale);
            this.pn_leftTab.Controls.Add(this.btnWarehouse);
            this.pn_leftTab.Location = new System.Drawing.Point(0, 50);
            this.pn_leftTab.Name = "pn_leftTab";
            this.pn_leftTab.Size = new System.Drawing.Size(204, 590);
            this.pn_leftTab.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDashboard.Image = global::RestaurantManagementSystem.Properties.Resources.home;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(204, 65);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Tổng quan";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.btnDashboard_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.btnDashboard_MouseLeave);
            // 
            // btnSale
            // 
            this.btnSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Image = global::RestaurantManagementSystem.Properties.Resources.serving_dish;
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(0, 65);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(204, 65);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "Gọi món";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            this.btnSale.MouseEnter += new System.EventHandler(this.btnSale_MouseEnter);
            this.btnSale.MouseLeave += new System.EventHandler(this.btnSale_MouseLeave);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarehouse.Image = global::RestaurantManagementSystem.Properties.Resources.warehouse__1_;
            this.btnWarehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWarehouse.Location = new System.Drawing.Point(0, 130);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(204, 65);
            this.btnWarehouse.TabIndex = 3;
            this.btnWarehouse.Text = "Kho hàng";
            this.btnWarehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWarehouse.UseVisualStyleBackColor = false;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            this.btnWarehouse.MouseEnter += new System.EventHandler(this.btnWarehouse_MouseEnter);
            this.btnWarehouse.MouseLeave += new System.EventHandler(this.btnWarehouse_MouseLeave);
            // 
            // pn_switchableWndw
            // 
            this.pn_switchableWndw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pn_switchableWndw.Controls.Add(this.label1);
            this.pn_switchableWndw.Location = new System.Drawing.Point(204, 50);
            this.pn_switchableWndw.Name = "pn_switchableWndw";
            this.pn_switchableWndw.Size = new System.Drawing.Size(1066, 590);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Management System";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.pn_topBar.ResumeLayout(false);
            this.pn_topBar.PerformLayout();
            this.pn_leftTab.ResumeLayout(false);
            this.pn_switchableWndw.ResumeLayout(false);
            this.pn_switchableWndw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_topBar;
        private System.Windows.Forms.Panel pn_leftTab;
        private System.Windows.Forms.Panel pn_exitButton;
        private System.Windows.Forms.Label lb_activatingAccount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lb_appTitle;
        private System.Windows.Forms.Panel pn_switchableWndw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnWarehouse;
    }
}

