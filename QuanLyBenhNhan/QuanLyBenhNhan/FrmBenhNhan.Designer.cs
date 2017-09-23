namespace QuanLyBenhNhan
{
    partial class Form_BenhNhan
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.tabnghiepvu = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnxuatvien = new System.Windows.Forms.Button();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.btnthuoc = new System.Windows.Forms.Button();
            this.btndichvu = new System.Windows.Forms.Button();
            this.btnchuyenkhoa = new System.Windows.Forms.Button();
            this.btnbenhan = new System.Windows.Forms.Button();
            this.tabquanlybn = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtgbnnamvien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dtgbnxuatvien = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabnghiepvu.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabquanlybn.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbnnamvien)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbnxuatvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(633, 407);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(87, 23);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnchitiet
            // 
            this.btnchitiet.Location = new System.Drawing.Point(171, 407);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(87, 23);
            this.btnchitiet.TabIndex = 12;
            this.btnchitiet.Text = "Chi tiết";
            this.btnchitiet.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(49, 407);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 23);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // tabnghiepvu
            // 
            this.tabnghiepvu.Controls.Add(this.tabPage3);
            this.tabnghiepvu.Location = new System.Drawing.Point(615, 13);
            this.tabnghiepvu.Name = "tabnghiepvu";
            this.tabnghiepvu.SelectedIndex = 0;
            this.tabnghiepvu.Size = new System.Drawing.Size(200, 388);
            this.tabnghiepvu.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnxuatvien);
            this.tabPage3.Controls.Add(this.btnthanhtoan);
            this.tabPage3.Controls.Add(this.btnthuoc);
            this.tabPage3.Controls.Add(this.btndichvu);
            this.tabPage3.Controls.Add(this.btnchuyenkhoa);
            this.tabPage3.Controls.Add(this.btnbenhan);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 362);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Nghiệp vụ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnxuatvien
            // 
            this.btnxuatvien.Location = new System.Drawing.Point(50, 247);
            this.btnxuatvien.Name = "btnxuatvien";
            this.btnxuatvien.Size = new System.Drawing.Size(87, 23);
            this.btnxuatvien.TabIndex = 5;
            this.btnxuatvien.Text = "Xuất viện";
            this.btnxuatvien.UseVisualStyleBackColor = true;
            this.btnxuatvien.Click += new System.EventHandler(this.btnxuatvien_Click);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(50, 204);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(87, 23);
            this.btnthanhtoan.TabIndex = 4;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnthuoc
            // 
            this.btnthuoc.Location = new System.Drawing.Point(50, 162);
            this.btnthuoc.Name = "btnthuoc";
            this.btnthuoc.Size = new System.Drawing.Size(87, 23);
            this.btnthuoc.TabIndex = 3;
            this.btnthuoc.Text = "Thuốc";
            this.btnthuoc.UseVisualStyleBackColor = true;
            this.btnthuoc.Click += new System.EventHandler(this.btnthuoc_Click);
            // 
            // btndichvu
            // 
            this.btndichvu.Location = new System.Drawing.Point(50, 121);
            this.btndichvu.Name = "btndichvu";
            this.btndichvu.Size = new System.Drawing.Size(87, 23);
            this.btndichvu.TabIndex = 2;
            this.btndichvu.Text = "Dịch vụ";
            this.btndichvu.UseVisualStyleBackColor = true;
            this.btndichvu.Click += new System.EventHandler(this.btndichvu_Click);
            // 
            // btnchuyenkhoa
            // 
            this.btnchuyenkhoa.Location = new System.Drawing.Point(50, 79);
            this.btnchuyenkhoa.Name = "btnchuyenkhoa";
            this.btnchuyenkhoa.Size = new System.Drawing.Size(87, 23);
            this.btnchuyenkhoa.TabIndex = 1;
            this.btnchuyenkhoa.Text = "Chuyển khoa";
            this.btnchuyenkhoa.UseVisualStyleBackColor = true;
            this.btnchuyenkhoa.Click += new System.EventHandler(this.btnchuyenkhoa_Click);
            // 
            // btnbenhan
            // 
            this.btnbenhan.Location = new System.Drawing.Point(50, 38);
            this.btnbenhan.Name = "btnbenhan";
            this.btnbenhan.Size = new System.Drawing.Size(87, 23);
            this.btnbenhan.TabIndex = 0;
            this.btnbenhan.Text = "Bệnh án";
            this.btnbenhan.UseVisualStyleBackColor = true;
            this.btnbenhan.Click += new System.EventHandler(this.btnbenhan_Click);
            // 
            // tabquanlybn
            // 
            this.tabquanlybn.Controls.Add(this.tabPage1);
            this.tabquanlybn.Controls.Add(this.tabPage2);
            this.tabquanlybn.Location = new System.Drawing.Point(12, 12);
            this.tabquanlybn.Name = "tabquanlybn";
            this.tabquanlybn.SelectedIndex = 0;
            this.tabquanlybn.Size = new System.Drawing.Size(601, 389);
            this.tabquanlybn.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dtgbnnamvien);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bệnh nhân nằm viện";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 6;
            // 
            // dtgbnnamvien
            // 
            this.dtgbnnamvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgbnnamvien.Location = new System.Drawing.Point(10, 38);
            this.dtgbnnamvien.Name = "dtgbnnamvien";
            this.dtgbnnamvien.Size = new System.Drawing.Size(571, 247);
            this.dtgbnnamvien.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(282, 7);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txttimkiem);
            this.tabPage2.Controls.Add(this.dtgbnxuatvien);
            this.tabPage2.Controls.Add(this.btnrefresh);
            this.tabPage2.Controls.Add(this.dateTimePicker3);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dateTimePicker4);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bệnh nhân xuất viện";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(12, 318);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(154, 20);
            this.txttimkiem.TabIndex = 13;
            // 
            // dtgbnxuatvien
            // 
            this.dtgbnxuatvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgbnxuatvien.Location = new System.Drawing.Point(12, 56);
            this.dtgbnxuatvien.Name = "dtgbnxuatvien";
            this.dtgbnxuatvien.Size = new System.Drawing.Size(571, 247);
            this.dtgbnxuatvien.TabIndex = 12;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(468, 24);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 11;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(284, 25);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đến ngày";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(56, 24);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Từ ngày";
            // 
            // Form_BenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 445);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.tabnghiepvu);
            this.Controls.Add(this.tabquanlybn);
            this.MaximizeBox = false;
            this.Name = "Form_BenhNhan";
            this.Text = "Bệnh nhân";
            this.tabnghiepvu.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabquanlybn.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbnnamvien)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgbnxuatvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TabControl tabnghiepvu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnxuatvien;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Button btnthuoc;
        private System.Windows.Forms.Button btndichvu;
        private System.Windows.Forms.Button btnchuyenkhoa;
        private System.Windows.Forms.Button btnbenhan;
        private System.Windows.Forms.TabControl tabquanlybn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dtgbnnamvien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridView dtgbnxuatvien;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label4;
    }
}