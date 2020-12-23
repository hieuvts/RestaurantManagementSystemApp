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
            this.txtb_tongdoanhthu = new System.Windows.Forms.TextBox();
            this.LB_TONGDOANHTHU = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.pn_mostSellingItem = new System.Windows.Forms.Panel();
            this.dgv_danhsachhoadon = new System.Windows.Forms.DataGridView();
            this.IDhoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatrihoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylaphoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_mostSellingItem = new System.Windows.Forms.DataGridView();
            this.lb_mostSellingItem = new System.Windows.Forms.Label();
            this.pn_weeklyEarning.SuspendLayout();
            this.pn_mostSellingItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachhoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostSellingItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_weeklyEarning
            // 
            this.pn_weeklyEarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pn_weeklyEarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_weeklyEarning.Controls.Add(this.txtb_tongdoanhthu);
            this.pn_weeklyEarning.Controls.Add(this.LB_TONGDOANHTHU);
            this.pn_weeklyEarning.ForeColor = System.Drawing.Color.Black;
            this.pn_weeklyEarning.Location = new System.Drawing.Point(24, 113);
            this.pn_weeklyEarning.Name = "pn_weeklyEarning";
            this.pn_weeklyEarning.Size = new System.Drawing.Size(1016, 100);
            this.pn_weeklyEarning.TabIndex = 0;
            // 
            // txtb_tongdoanhthu
            // 
            this.txtb_tongdoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_tongdoanhthu.Location = new System.Drawing.Point(211, 29);
            this.txtb_tongdoanhthu.Multiline = true;
            this.txtb_tongdoanhthu.Name = "txtb_tongdoanhthu";
            this.txtb_tongdoanhthu.ReadOnly = true;
            this.txtb_tongdoanhthu.Size = new System.Drawing.Size(228, 32);
            this.txtb_tongdoanhthu.TabIndex = 1;
            // 
            // LB_TONGDOANHTHU
            // 
            this.LB_TONGDOANHTHU.AutoSize = true;
            this.LB_TONGDOANHTHU.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TONGDOANHTHU.ForeColor = System.Drawing.Color.Black;
            this.LB_TONGDOANHTHU.Location = new System.Drawing.Point(6, 29);
            this.LB_TONGDOANHTHU.Name = "LB_TONGDOANHTHU";
            this.LB_TONGDOANHTHU.Size = new System.Drawing.Size(188, 32);
            this.LB_TONGDOANHTHU.TabIndex = 0;
            this.LB_TONGDOANHTHU.Text = "Tổng doanh thu";
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
            // pn_mostSellingItem
            // 
            this.pn_mostSellingItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pn_mostSellingItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_mostSellingItem.Controls.Add(this.dgv_danhsachhoadon);
            this.pn_mostSellingItem.Controls.Add(this.dgv_mostSellingItem);
            this.pn_mostSellingItem.Controls.Add(this.lb_mostSellingItem);
            this.pn_mostSellingItem.Location = new System.Drawing.Point(24, 246);
            this.pn_mostSellingItem.Name = "pn_mostSellingItem";
            this.pn_mostSellingItem.Size = new System.Drawing.Size(1020, 307);
            this.pn_mostSellingItem.TabIndex = 1;
            // 
            // dgv_danhsachhoadon
            // 
            this.dgv_danhsachhoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_danhsachhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDhoaDon,
            this.giatrihoadon,
            this.ngaylaphoadon});
            this.dgv_danhsachhoadon.Location = new System.Drawing.Point(3, 45);
            this.dgv_danhsachhoadon.Name = "dgv_danhsachhoadon";
            this.dgv_danhsachhoadon.ReadOnly = true;
            this.dgv_danhsachhoadon.Size = new System.Drawing.Size(1012, 257);
            this.dgv_danhsachhoadon.TabIndex = 2;
            // 
            // IDhoaDon
            // 
            this.IDhoaDon.DataPropertyName = "IDhoaDon";
            this.IDhoaDon.HeaderText = "ID hoá dơn";
            this.IDhoaDon.Name = "IDhoaDon";
            this.IDhoaDon.ReadOnly = true;
            // 
            // giatrihoadon
            // 
            this.giatrihoadon.DataPropertyName = "giatri";
            this.giatrihoadon.HeaderText = "Giá trị hoá đơn";
            this.giatrihoadon.Name = "giatrihoadon";
            this.giatrihoadon.ReadOnly = true;
            // 
            // ngaylaphoadon
            // 
            this.ngaylaphoadon.DataPropertyName = "ngaylaphoadon";
            this.ngaylaphoadon.HeaderText = "Ngày lập hoá đơn";
            this.ngaylaphoadon.Name = "ngaylaphoadon";
            this.ngaylaphoadon.ReadOnly = true;
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
            // lb_mostSellingItem
            // 
            this.lb_mostSellingItem.AutoSize = true;
            this.lb_mostSellingItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mostSellingItem.ForeColor = System.Drawing.Color.Black;
            this.lb_mostSellingItem.Location = new System.Drawing.Point(3, 10);
            this.lb_mostSellingItem.Name = "lb_mostSellingItem";
            this.lb_mostSellingItem.Size = new System.Drawing.Size(222, 32);
            this.lb_mostSellingItem.TabIndex = 0;
            this.lb_mostSellingItem.Text = "Danh sách hoá đơn";
            // 
            // UC_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.pn_mostSellingItem);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pn_weeklyEarning);
            this.Name = "UC_dashboard";
            this.Size = new System.Drawing.Size(1066, 590);
            this.pn_weeklyEarning.ResumeLayout(false);
            this.pn_weeklyEarning.PerformLayout();
            this.pn_mostSellingItem.ResumeLayout(false);
            this.pn_mostSellingItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachhoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostSellingItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_weeklyEarning;
        private System.Windows.Forms.Label LB_TONGDOANHTHU;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Panel pn_mostSellingItem;
        private System.Windows.Forms.Label lb_mostSellingItem;
        private System.Windows.Forms.DataGridView dgv_mostSellingItem;
        private System.Windows.Forms.TextBox txtb_tongdoanhthu;
        private System.Windows.Forms.DataGridView dgv_danhsachhoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDhoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatrihoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylaphoadon;
    }
}
