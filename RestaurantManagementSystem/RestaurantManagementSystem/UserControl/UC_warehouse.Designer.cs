namespace RestaurantManagementSystem
{
    partial class UC_warehouse
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
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.soLuong_txtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tenmonan_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.func_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_danhSachMonAn = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.func_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.add_btn.Location = new System.Drawing.Point(3, 18);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(87, 31);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Thêm ";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.update_btn.Location = new System.Drawing.Point(96, 18);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(87, 31);
            this.update_btn.TabIndex = 5;
            this.update_btn.Text = "Sửa";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.delete_btn.Location = new System.Drawing.Point(189, 18);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(87, 31);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Xoá";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.soLuong_txtb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tenmonan_txtbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 102);
            this.panel1.TabIndex = 7;
            // 
            // soLuong_txtb
            // 
            this.soLuong_txtb.Location = new System.Drawing.Point(179, 60);
            this.soLuong_txtb.Name = "soLuong_txtb";
            this.soLuong_txtb.Size = new System.Drawing.Size(196, 20);
            this.soLuong_txtb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng";
            // 
            // tenmonan_txtbox
            // 
            this.tenmonan_txtbox.Location = new System.Drawing.Point(179, 13);
            this.tenmonan_txtbox.Name = "tenmonan_txtbox";
            this.tenmonan_txtbox.Size = new System.Drawing.Size(196, 20);
            this.tenmonan_txtbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nguyên liệu";
            // 
            // func_panel
            // 
            this.func_panel.Controls.Add(this.add_btn);
            this.func_panel.Controls.Add(this.update_btn);
            this.func_panel.Controls.Add(this.delete_btn);
            this.func_panel.Location = new System.Drawing.Point(23, 153);
            this.func_panel.Name = "func_panel";
            this.func_panel.Size = new System.Drawing.Size(414, 67);
            this.func_panel.TabIndex = 8;
            this.func_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.func_panel_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.save_btn);
            this.panel3.Controls.Add(this.cancel_btn);
            this.panel3.Location = new System.Drawing.Point(23, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 66);
            this.panel3.TabIndex = 9;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.save_btn.Location = new System.Drawing.Point(0, 18);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(87, 31);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Xác nhận";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cancel_btn.Location = new System.Drawing.Point(96, 18);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(87, 31);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Huỷ bỏ";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_danhSachMonAn);
            this.panel2.Location = new System.Drawing.Point(443, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 547);
            this.panel2.TabIndex = 9;
            // 
            // dgv_danhSachMonAn
            // 
            this.dgv_danhSachMonAn.AllowUserToAddRows = false;
            this.dgv_danhSachMonAn.AllowUserToDeleteRows = false;
            this.dgv_danhSachMonAn.AllowUserToResizeColumns = false;
            this.dgv_danhSachMonAn.AllowUserToResizeRows = false;
            this.dgv_danhSachMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_danhSachMonAn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_danhSachMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhSachMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.soluong});
            this.dgv_danhSachMonAn.Location = new System.Drawing.Point(0, 0);
            this.dgv_danhSachMonAn.Name = "dgv_danhSachMonAn";
            this.dgv_danhSachMonAn.ReadOnly = true;
            this.dgv_danhSachMonAn.Size = new System.Drawing.Size(618, 544);
            this.dgv_danhSachMonAn.TabIndex = 0;
            this.dgv_danhSachMonAn.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhSachMonAn_RowEnter);
            // 
            // id
            // 
            this.id.DataPropertyName = "IDnguyenLieu";
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "tenNguyenLieu";
            this.ten.HeaderText = "Tên nguyên liệu";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soLuong";
            this.soluong.HeaderText = "Số lượng (Kg)";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // UC_warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.func_panel);
            this.Controls.Add(this.panel1);
            this.Name = "UC_warehouse";
            this.Size = new System.Drawing.Size(1066, 565);
            this.Load += new System.EventHandler(this.UC_warehouse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.func_panel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhSachMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tenmonan_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel func_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_danhSachMonAn;
        private System.Windows.Forms.TextBox soLuong_txtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}
