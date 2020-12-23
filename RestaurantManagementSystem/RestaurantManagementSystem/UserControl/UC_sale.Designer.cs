
namespace RestaurantManagementSystem
{
    partial class UC_Sale
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
            this.pn_hoadon = new System.Windows.Forms.Panel();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.idbanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmonan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhmuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamonan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_monan = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmr_soluongmonan = new System.Windows.Forms.NumericUpDown();
            this.btn_add = new System.Windows.Forms.Button();
            this.cbb_danhsachmonan = new System.Windows.Forms.ComboBox();
            this.cbb_danhmucmonan = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_tongtien = new System.Windows.Forms.TextBox();
            this.btn_payment = new System.Windows.Forms.Button();
            this.flp_danhSachBanAn = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_hoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.pn_monan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_soluongmonan)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_hoadon
            // 
            this.pn_hoadon.Controls.Add(this.dgv_hoadon);
            this.pn_hoadon.Location = new System.Drawing.Point(631, 79);
            this.pn_hoadon.Name = "pn_hoadon";
            this.pn_hoadon.Size = new System.Drawing.Size(432, 385);
            this.pn_hoadon.TabIndex = 1;
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbanan,
            this.idmonan,
            this.name,
            this.danhmuc,
            this.giamonan,
            this.soluong});
            this.dgv_hoadon.Location = new System.Drawing.Point(0, 3);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.Size = new System.Drawing.Size(429, 379);
            this.dgv_hoadon.TabIndex = 0;
            this.dgv_hoadon.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_RowEnter);
            // 
            // idbanan
            // 
            this.idbanan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idbanan.DataPropertyName = "IDbanAn";
            this.idbanan.HeaderText = "ID bàn ăn";
            this.idbanan.Name = "idbanan";
            this.idbanan.ReadOnly = true;
            this.idbanan.Visible = false;
            // 
            // idmonan
            // 
            this.idmonan.DataPropertyName = "IDmonAn";
            this.idmonan.HeaderText = "Id món ăn";
            this.idmonan.Name = "idmonan";
            this.idmonan.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "tenMonAn";
            this.name.HeaderText = "Tên món ăn";
            this.name.Name = "name";
            // 
            // danhmuc
            // 
            this.danhmuc.DataPropertyName = "danhMuc";
            this.danhmuc.HeaderText = "Danh mục";
            this.danhmuc.Name = "danhmuc";
            // 
            // giamonan
            // 
            this.giamonan.DataPropertyName = "giaMonAn";
            this.giamonan.HeaderText = "Giá";
            this.giamonan.Name = "giamonan";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soLuong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // pn_monan
            // 
            this.pn_monan.Controls.Add(this.btn_delete);
            this.pn_monan.Controls.Add(this.label3);
            this.pn_monan.Controls.Add(this.label2);
            this.pn_monan.Controls.Add(this.nmr_soluongmonan);
            this.pn_monan.Controls.Add(this.btn_add);
            this.pn_monan.Controls.Add(this.cbb_danhsachmonan);
            this.pn_monan.Controls.Add(this.cbb_danhmucmonan);
            this.pn_monan.Location = new System.Drawing.Point(631, 3);
            this.pn_monan.Name = "pn_monan";
            this.pn_monan.Size = new System.Drawing.Size(432, 70);
            this.pn_monan.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(226, 38);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 21);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Xoá món";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh mục";
            // 
            // nmr_soluongmonan
            // 
            this.nmr_soluongmonan.Location = new System.Drawing.Point(323, 25);
            this.nmr_soluongmonan.Name = "nmr_soluongmonan";
            this.nmr_soluongmonan.Size = new System.Drawing.Size(81, 20);
            this.nmr_soluongmonan.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(226, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 21);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Thêm món";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbb_danhsachmonan
            // 
            this.cbb_danhsachmonan.FormattingEnabled = true;
            this.cbb_danhsachmonan.Location = new System.Drawing.Point(62, 39);
            this.cbb_danhsachmonan.Name = "cbb_danhsachmonan";
            this.cbb_danhsachmonan.Size = new System.Drawing.Size(158, 21);
            this.cbb_danhsachmonan.TabIndex = 1;
            // 
            // cbb_danhmucmonan
            // 
            this.cbb_danhmucmonan.FormattingEnabled = true;
            this.cbb_danhmucmonan.Location = new System.Drawing.Point(62, 12);
            this.cbb_danhmucmonan.Name = "cbb_danhmucmonan";
            this.cbb_danhmucmonan.Size = new System.Drawing.Size(158, 21);
            this.cbb_danhmucmonan.TabIndex = 0;
            this.cbb_danhmucmonan.SelectedIndexChanged += new System.EventHandler(this.cbb_danhmucmonan_SelectedIndexChanged_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtb_tongtien);
            this.panel3.Controls.Add(this.btn_payment);
            this.panel3.Location = new System.Drawing.Point(631, 470);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 117);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tổng tiền";
            // 
            // txtb_tongtien
            // 
            this.txtb_tongtien.Location = new System.Drawing.Point(99, 45);
            this.txtb_tongtien.Name = "txtb_tongtien";
            this.txtb_tongtien.Size = new System.Drawing.Size(228, 20);
            this.txtb_tongtien.TabIndex = 7;
            // 
            // btn_payment
            // 
            this.btn_payment.Location = new System.Drawing.Point(333, 17);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(96, 75);
            this.btn_payment.TabIndex = 4;
            this.btn_payment.Text = "Thanh toán";
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // flp_danhSachBanAn
            // 
            this.flp_danhSachBanAn.Location = new System.Drawing.Point(3, 3);
            this.flp_danhSachBanAn.Name = "flp_danhSachBanAn";
            this.flp_danhSachBanAn.Size = new System.Drawing.Size(625, 584);
            this.flp_danhSachBanAn.TabIndex = 4;
            // 
            // UC_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_danhSachBanAn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pn_monan);
            this.Controls.Add(this.pn_hoadon);
            this.Name = "UC_Sale";
            this.Size = new System.Drawing.Size(1066, 590);
            this.pn_hoadon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.pn_monan.ResumeLayout(false);
            this.pn_monan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_soluongmonan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_hoadon;
        private System.Windows.Forms.Panel pn_monan;
        private System.Windows.Forms.ComboBox cbb_danhsachmonan;
        private System.Windows.Forms.ComboBox cbb_danhmucmonan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nmr_soluongmonan;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_tongtien;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.FlowLayoutPanel flp_danhSachBanAn;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmonan;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamonan;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.Button btn_delete;
    }
}
