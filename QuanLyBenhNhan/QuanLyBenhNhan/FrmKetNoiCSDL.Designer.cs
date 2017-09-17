namespace QuanLyBenhNhan
{
    partial class FrmKetNoiCSDL
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
            this.txttenserver = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttentaikhoan = new System.Windows.Forms.TextBox();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnketnoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttenserver
            // 
            this.txttenserver.Location = new System.Drawing.Point(291, 43);
            this.txttenserver.Name = "txttenserver";
            this.txttenserver.Size = new System.Drawing.Size(100, 20);
            this.txttenserver.TabIndex = 0;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(291, 107);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(100, 20);
            this.txtmatkhau.TabIndex = 0;
            // 
            // txttentaikhoan
            // 
            this.txttentaikhoan.Location = new System.Drawing.Point(291, 69);
            this.txttentaikhoan.Name = "txttentaikhoan";
            this.txttentaikhoan.Size = new System.Drawing.Size(100, 20);
            this.txttentaikhoan.TabIndex = 0;
            // 
            // txtdatabase
            // 
            this.txtdatabase.Location = new System.Drawing.Point(291, 130);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(100, 20);
            this.txtdatabase.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Database";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(333, 183);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(224, 183);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnketnoi
            // 
            this.btnketnoi.Location = new System.Drawing.Point(109, 183);
            this.btnketnoi.Name = "btnketnoi";
            this.btnketnoi.Size = new System.Drawing.Size(75, 23);
            this.btnketnoi.TabIndex = 2;
            this.btnketnoi.Text = "Kết Nối";
            this.btnketnoi.UseVisualStyleBackColor = true;
            // 
            // FrmKetNoiCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 304);
            this.Controls.Add(this.btnketnoi);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdatabase);
            this.Controls.Add(this.txttentaikhoan);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttenserver);
            this.Name = "FrmKetNoiCSDL";
            this.Text = "FrmKetNoiCSDL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttenserver;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttentaikhoan;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnketnoi;
    }
}