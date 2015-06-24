namespace QLBanhang
{
    partial class SuaNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaNhanvien));
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.Sdt = new System.Windows.Forms.TextBox();
            this.Scm = new System.Windows.Forms.TextBox();
            this.Diachi = new System.Windows.Forms.TextBox();
            this.Namsinh = new System.Windows.Forms.TextBox();
            this.MaNV = new System.Windows.Forms.TextBox();
            this.Hoten = new System.Windows.Forms.TextBox();
            this.Gt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(173, 309);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(109, 40);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Location = new System.Drawing.Point(25, 309);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(109, 40);
            this.btn_Luu.TabIndex = 7;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // Sdt
            // 
            this.Sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Sdt.Location = new System.Drawing.Point(120, 135);
            this.Sdt.Name = "Sdt";
            this.Sdt.Size = new System.Drawing.Size(162, 21);
            this.Sdt.TabIndex = 3;
            this.Sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sdt_KeyPress);
            // 
            // Scm
            // 
            this.Scm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Scm.Location = new System.Drawing.Point(120, 176);
            this.Scm.Name = "Scm";
            this.Scm.Size = new System.Drawing.Size(162, 21);
            this.Scm.TabIndex = 4;
            this.Scm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Scm_KeyPress);
            // 
            // Diachi
            // 
            this.Diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Diachi.Location = new System.Drawing.Point(120, 218);
            this.Diachi.Name = "Diachi";
            this.Diachi.Size = new System.Drawing.Size(162, 21);
            this.Diachi.TabIndex = 5;
            // 
            // Namsinh
            // 
            this.Namsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Namsinh.Location = new System.Drawing.Point(120, 95);
            this.Namsinh.Name = "Namsinh";
            this.Namsinh.Size = new System.Drawing.Size(162, 21);
            this.Namsinh.TabIndex = 2;
            // 
            // MaNV
            // 
            this.MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaNV.Location = new System.Drawing.Point(120, 13);
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Size = new System.Drawing.Size(162, 21);
            this.MaNV.TabIndex = 0;
            // 
            // Hoten
            // 
            this.Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Hoten.Location = new System.Drawing.Point(120, 53);
            this.Hoten.Name = "Hoten";
            this.Hoten.Size = new System.Drawing.Size(162, 21);
            this.Hoten.TabIndex = 1;
            // 
            // Gt
            // 
            this.Gt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Gt.FormattingEnabled = true;
            this.Gt.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.Gt.Location = new System.Drawing.Point(120, 256);
            this.Gt.Name = "Gt";
            this.Gt.Size = new System.Drawing.Size(121, 23);
            this.Gt.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(22, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(22, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(22, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(22, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Năm sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã nhân viên";
            // 
            // SuaNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(306, 367);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.Sdt);
            this.Controls.Add(this.Scm);
            this.Controls.Add(this.Diachi);
            this.Controls.Add(this.Namsinh);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.Hoten);
            this.Controls.Add(this.Gt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuaNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SuaNhanvien_FormClosing);
            this.Load += new System.EventHandler(this.SuaNhanvien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox Sdt;
        private System.Windows.Forms.TextBox Scm;
        private System.Windows.Forms.TextBox Diachi;
        private System.Windows.Forms.TextBox Namsinh;
        private System.Windows.Forms.TextBox MaNV;
        private System.Windows.Forms.TextBox Hoten;
        private System.Windows.Forms.ComboBox Gt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}