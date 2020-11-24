namespace RestaurantManagementSystem
{
    partial class loginForm
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
            this.pn_titleBar = new System.Windows.Forms.Panel();
            this.lb_appTitle = new System.Windows.Forms.Label();
            this.pn_exitButton = new System.Windows.Forms.Panel();
            this.pn_login = new System.Windows.Forms.Panel();
            this.bt_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_contact = new System.Windows.Forms.Label();
            this.pn_titleBar.SuspendLayout();
            this.pn_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_titleBar
            // 
            this.pn_titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pn_titleBar.Controls.Add(this.lb_appTitle);
            this.pn_titleBar.Controls.Add(this.pn_exitButton);
            this.pn_titleBar.Location = new System.Drawing.Point(0, 0);
            this.pn_titleBar.Name = "pn_titleBar";
            this.pn_titleBar.Size = new System.Drawing.Size(520, 50);
            this.pn_titleBar.TabIndex = 0;
            // 
            // lb_appTitle
            // 
            this.lb_appTitle.AutoSize = true;
            this.lb_appTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appTitle.ForeColor = System.Drawing.Color.White;
            this.lb_appTitle.Location = new System.Drawing.Point(204, 9);
            this.lb_appTitle.Name = "lb_appTitle";
            this.lb_appTitle.Size = new System.Drawing.Size(106, 33);
            this.lb_appTitle.TabIndex = 3;
            this.lb_appTitle.Text = "LOGIN";
            // 
            // pn_exitButton
            // 
            this.pn_exitButton.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.cancel;
            this.pn_exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_exitButton.Location = new System.Drawing.Point(480, 6);
            this.pn_exitButton.Name = "pn_exitButton";
            this.pn_exitButton.Size = new System.Drawing.Size(35, 35);
            this.pn_exitButton.TabIndex = 2;
            // 
            // pn_login
            // 
            this.pn_login.Controls.Add(this.lb_contact);
            this.pn_login.Controls.Add(this.bt_login);
            this.pn_login.Controls.Add(this.tb_password);
            this.pn_login.Controls.Add(this.tb_username);
            this.pn_login.Controls.Add(this.lb_password);
            this.pn_login.Controls.Add(this.lb_username);
            this.pn_login.Location = new System.Drawing.Point(0, 50);
            this.pn_login.Name = "pn_login";
            this.pn_login.Size = new System.Drawing.Size(520, 470);
            this.pn_login.TabIndex = 1;
            // 
            // bt_login
            // 
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_login.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(295, 289);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(182, 56);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(238, 187);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(239, 40);
            this.tb_password.TabIndex = 3;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_username
            // 
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(238, 109);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(239, 40);
            this.tb_username.TabIndex = 2;
            this.tb_username.UseSystemPasswordChar = true;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.lb_password.Location = new System.Drawing.Point(55, 187);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(142, 40);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Password:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.lb_username.Location = new System.Drawing.Point(55, 109);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(151, 40);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Username:";
            // 
            // lb_contact
            // 
            this.lb_contact.AutoSize = true;
            this.lb_contact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contact.Location = new System.Drawing.Point(12, 440);
            this.lb_contact.Name = "lb_contact";
            this.lb_contact.Size = new System.Drawing.Size(153, 21);
            this.lb_contact.TabIndex = 5;
            this.lb_contact.Text = "Hỗ trợ: 0123456789";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 520);
            this.Controls.Add(this.pn_login);
            this.Controls.Add(this.pn_titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pn_titleBar.ResumeLayout(false);
            this.pn_titleBar.PerformLayout();
            this.pn_login.ResumeLayout(false);
            this.pn_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_titleBar;
        private System.Windows.Forms.Panel pn_exitButton;
        private System.Windows.Forms.Panel pn_login;
        private System.Windows.Forms.Label lb_appTitle;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_contact;
    }
}