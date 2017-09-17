namespace QuanLyBenhNhan
{
    partial class FrmDichVuSuDungcs
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabthongtin = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabdanhsachthuoc = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbngay = new System.Windows.Forms.ComboBox();
            this.cbhang = new System.Windows.Forms.ComboBox();
            this.txtmasonhapvien = new System.Windows.Forms.TextBox();
            this.txtbenhnhan = new System.Windows.Forms.TextBox();
            this.txtmasodichvu = new System.Windows.Forms.TextBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabthongtin.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabdanhsachthuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabthongtin);
            this.tabControl1.Location = new System.Drawing.Point(16, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 152);
            this.tabControl1.TabIndex = 0;
            // 
            // tabthongtin
            // 
            this.tabthongtin.Controls.Add(this.txtghichu);
            this.tabthongtin.Controls.Add(this.txtmasodichvu);
            this.tabthongtin.Controls.Add(this.txtbenhnhan);
            this.tabthongtin.Controls.Add(this.txtmasonhapvien);
            this.tabthongtin.Controls.Add(this.cbhang);
            this.tabthongtin.Controls.Add(this.cbngay);
            this.tabthongtin.Controls.Add(this.label5);
            this.tabthongtin.Controls.Add(this.label4);
            this.tabthongtin.Controls.Add(this.label6);
            this.tabthongtin.Controls.Add(this.label3);
            this.tabthongtin.Controls.Add(this.label2);
            this.tabthongtin.Controls.Add(this.label1);
            this.tabthongtin.Location = new System.Drawing.Point(4, 22);
            this.tabthongtin.Name = "tabthongtin";
            this.tabthongtin.Padding = new System.Windows.Forms.Padding(3);
            this.tabthongtin.Size = new System.Drawing.Size(704, 126);
            this.tabthongtin.TabIndex = 0;
            this.tabthongtin.Text = "Thông tin";
            this.tabthongtin.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabdanhsachthuoc);
            this.tabControl2.Location = new System.Drawing.Point(12, 171);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(720, 122);
            this.tabControl2.TabIndex = 0;
            // 
            // tabdanhsachthuoc
            // 
            this.tabdanhsachthuoc.Controls.Add(this.listView1);
            this.tabdanhsachthuoc.Location = new System.Drawing.Point(4, 22);
            this.tabdanhsachthuoc.Name = "tabdanhsachthuoc";
            this.tabdanhsachthuoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabdanhsachthuoc.Size = new System.Drawing.Size(712, 96);
            this.tabdanhsachthuoc.TabIndex = 0;
            this.tabdanhsachthuoc.Text = "Danh sách thuốc";
            this.tabdanhsachthuoc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số nhập viện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "bệnh nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã số dịch vụ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bác sĩ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ghi chú";
            // 
            // cbngay
            // 
            this.cbngay.FormattingEnabled = true;
            this.cbngay.Location = new System.Drawing.Point(378, 50);
            this.cbngay.Name = "cbngay";
            this.cbngay.Size = new System.Drawing.Size(121, 21);
            this.cbngay.TabIndex = 1;
            this.cbngay.Text = "27/03/2017";
            // 
            // cbhang
            // 
            this.cbhang.FormattingEnabled = true;
            this.cbhang.Location = new System.Drawing.Point(103, 73);
            this.cbhang.Name = "cbhang";
            this.cbhang.Size = new System.Drawing.Size(121, 21);
            this.cbhang.TabIndex = 1;
            this.cbhang.Text = "Hằng,Nam";
            // 
            // txtmasonhapvien
            // 
            this.txtmasonhapvien.Location = new System.Drawing.Point(103, 7);
            this.txtmasonhapvien.Name = "txtmasonhapvien";
            this.txtmasonhapvien.Size = new System.Drawing.Size(100, 20);
            this.txtmasonhapvien.TabIndex = 2;
            // 
            // txtbenhnhan
            // 
            this.txtbenhnhan.Location = new System.Drawing.Point(103, 26);
            this.txtbenhnhan.Name = "txtbenhnhan";
            this.txtbenhnhan.Size = new System.Drawing.Size(396, 20);
            this.txtbenhnhan.TabIndex = 2;
            // 
            // txtmasodichvu
            // 
            this.txtmasodichvu.Location = new System.Drawing.Point(103, 50);
            this.txtmasodichvu.Name = "txtmasodichvu";
            this.txtmasodichvu.Size = new System.Drawing.Size(100, 20);
            this.txtmasodichvu.TabIndex = 2;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(103, 94);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(100, 20);
            this.txtghichu.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(709, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmDichVuSuDungcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 290);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDichVuSuDungcs";
            this.Text = "FrmDichVuSuDungcs";
            this.tabControl1.ResumeLayout(false);
            this.tabthongtin.ResumeLayout(false);
            this.tabthongtin.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabdanhsachthuoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabthongtin;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txtmasodichvu;
        private System.Windows.Forms.TextBox txtbenhnhan;
        private System.Windows.Forms.TextBox txtmasonhapvien;
        private System.Windows.Forms.ComboBox cbhang;
        private System.Windows.Forms.ComboBox cbngay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabdanhsachthuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
    }
}