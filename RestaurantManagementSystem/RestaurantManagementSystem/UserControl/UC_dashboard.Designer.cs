namespace RestaurantManagementSystem
{
    partial class UC_dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_weeklyEarning = new System.Windows.Forms.Panel();
            this.lb_weeklyEarning = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.pn_monthlyEarning = new System.Windows.Forms.Panel();
            this.lb_monthlyEarning = new System.Windows.Forms.Label();
            this.pn_mostSellingItem = new System.Windows.Forms.Panel();
            this.lb_mostSellingItem = new System.Windows.Forms.Label();
            this.dgv_mostSellingItem = new System.Windows.Forms.DataGridView();
            this.pn_weeklyEarning.SuspendLayout();
            this.pn_monthlyEarning.SuspendLayout();
            this.pn_mostSellingItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostSellingItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_weeklyEarning
            // 
            this.pn_weeklyEarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pn_weeklyEarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_weeklyEarning.Controls.Add(this.lb_weeklyEarning);
            this.pn_weeklyEarning.ForeColor = System.Drawing.Color.Black;
            this.pn_weeklyEarning.Location = new System.Drawing.Point(24, 113);
            this.pn_weeklyEarning.Name = "pn_weeklyEarning";
            this.pn_weeklyEarning.Size = new System.Drawing.Size(370, 100);
            this.pn_weeklyEarning.TabIndex = 0;
            // 
            // lb_weeklyEarning
            // 
            this.lb_weeklyEarning.AutoSize = true;
            this.lb_weeklyEarning.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_weeklyEarning.ForeColor = System.Drawing.Color.Black;
            this.lb_weeklyEarning.Location = new System.Drawing.Point(6, 29);
            this.lb_weeklyEarning.Name = "lb_weeklyEarning";
            this.lb_weeklyEarning.Size = new System.Drawing.Size(189, 32);
            this.lb_weeklyEarning.TabIndex = 0;
            this.lb_weeklyEarning.Text = "Doanh thu tuần:";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lb_title.Location = new System.Drawing.Point(17, 10);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(202, 42);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "Dashboard";
            // 
            // pn_monthlyEarning
            // 
            this.pn_monthlyEarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pn_monthlyEarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_monthlyEarning.Controls.Add(this.lb_monthlyEarning);
            this.pn_monthlyEarning.Location = new System.Drawing.Point(674, 113);
            this.pn_monthlyEarning.Name = "pn_monthlyEarning";
            this.pn_monthlyEarning.Size = new System.Drawing.Size(370, 100);
            this.pn_monthlyEarning.TabIndex = 1;
            // 
            // lb_monthlyEarning
            // 
            this.lb_monthlyEarning.AutoSize = true;
            this.lb_monthlyEarning.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_monthlyEarning.ForeColor = System.Drawing.Color.Black;
            this.lb_monthlyEarning.Location = new System.Drawing.Point(14, 29);
            this.lb_monthlyEarning.Name = "lb_monthlyEarning";
            this.lb_monthlyEarning.Size = new System.Drawing.Size(203, 32);
            this.lb_monthlyEarning.TabIndex = 0;
            this.lb_monthlyEarning.Text = "Doanh thu tháng:";
            // 
            // pn_mostSellingItem
            // 
            this.pn_mostSellingItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pn_mostSellingItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_mostSellingItem.Controls.Add(this.dgv_mostSellingItem);
            this.pn_mostSellingItem.Controls.Add(this.lb_mostSellingItem);
            this.pn_mostSellingItem.Location = new System.Drawing.Point(24, 244);
            this.pn_mostSellingItem.Name = "pn_mostSellingItem";
            this.pn_mostSellingItem.Size = new System.Drawing.Size(1020, 309);
            this.pn_mostSellingItem.TabIndex = 1;
            // 
            // lb_mostSellingItem
            // 
            this.lb_mostSellingItem.AutoSize = true;
            this.lb_mostSellingItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mostSellingItem.ForeColor = System.Drawing.Color.Black;
            this.lb_mostSellingItem.Location = new System.Drawing.Point(3, 10);
            this.lb_mostSellingItem.Name = "lb_mostSellingItem";
            this.lb_mostSellingItem.Size = new System.Drawing.Size(308, 32);
            this.lb_mostSellingItem.TabIndex = 0;
            this.lb_mostSellingItem.Text = "Những món bán chạy nhất:";
            // 
            // dgv_mostSellingItem
            // 
            this.dgv_mostSellingItem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_mostSellingItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostSellingItem.Location = new System.Drawing.Point(3, 45);
            this.dgv_mostSellingItem.Name = "dgv_mostSellingItem";
            this.dgv_mostSellingItem.Size = new System.Drawing.Size(1012, 259);
            this.dgv_mostSellingItem.TabIndex = 1;
            // 
            // UC_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.pn_mostSellingItem);
            this.Controls.Add(this.pn_monthlyEarning);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pn_weeklyEarning);
            this.Name = "UC_dashboard";
            this.Size = new System.Drawing.Size(1066, 565);
            this.pn_weeklyEarning.ResumeLayout(false);
            this.pn_weeklyEarning.PerformLayout();
            this.pn_monthlyEarning.ResumeLayout(false);
            this.pn_monthlyEarning.PerformLayout();
            this.pn_mostSellingItem.ResumeLayout(false);
            this.pn_mostSellingItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostSellingItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_weeklyEarning;
        private System.Windows.Forms.Label lb_weeklyEarning;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Panel pn_monthlyEarning;
        private System.Windows.Forms.Label lb_monthlyEarning;
        private System.Windows.Forms.Panel pn_mostSellingItem;
        private System.Windows.Forms.Label lb_mostSellingItem;
        private System.Windows.Forms.DataGridView dgv_mostSellingItem;
    }
}
