namespace QLBanhang
{
    partial class Hoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoadon));
            this.grvHoadon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tensach = new System.Windows.Forms.TextBox();
            this.cboMasach = new System.Windows.Forms.ComboBox();
            this.Soluong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Xoact = new System.Windows.Forms.Button();
            this.btn_Suact = new System.Windows.Forms.Button();
            this.btn_Themct = new System.Windows.Forms.Button();
            this.grvChitiethd = new System.Windows.Forms.DataGridView();
            this.btn_Themhd = new System.Windows.Forms.Button();
            this.btn_Suahd = new System.Windows.Forms.Button();
            this.btn_Xoahd = new System.Windows.Forms.Button();
            this.btn_In = new System.Windows.Forms.Button();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.cboTimkiem = new System.Windows.Forms.ComboBox();
            this.Timkiem = new System.Windows.Forms.TextBox();
            this.MaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboKH = new System.Windows.Forms.ComboBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ngaylap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.Label();
            this.MaKH = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvHoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvChitiethd)).BeginInit();
            this.SuspendLayout();
            // 
            // grvHoadon
            // 
            this.grvHoadon.AllowUserToAddRows = false;
            this.grvHoadon.AllowUserToDeleteRows = false;
            this.grvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHoadon.Location = new System.Drawing.Point(12, 34);
            this.grvHoadon.MultiSelect = false;
            this.grvHoadon.Name = "grvHoadon";
            this.grvHoadon.ReadOnly = true;
            this.grvHoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvHoadon.Size = new System.Drawing.Size(443, 263);
            this.grvHoadon.TabIndex = 0;
            this.grvHoadon.Click += new System.EventHandler(this.grvHoadon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tensach);
            this.groupBox1.Controls.Add(this.cboMasach);
            this.groupBox1.Controls.Add(this.Soluong);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_Xoact);
            this.groupBox1.Controls.Add(this.btn_Suact);
            this.groupBox1.Controls.Add(this.btn_Themct);
            this.groupBox1.Controls.Add(this.grvChitiethd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(461, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 450);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // Tensach
            // 
            this.Tensach.Location = new System.Drawing.Point(83, 335);
            this.Tensach.Name = "Tensach";
            this.Tensach.ReadOnly = true;
            this.Tensach.Size = new System.Drawing.Size(202, 23);
            this.Tensach.TabIndex = 6;
            // 
            // cboMasach
            // 
            this.cboMasach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasach.FormattingEnabled = true;
            this.cboMasach.Location = new System.Drawing.Point(83, 300);
            this.cboMasach.Name = "cboMasach";
            this.cboMasach.Size = new System.Drawing.Size(202, 24);
            this.cboMasach.TabIndex = 0;
            this.cboMasach.SelectedIndexChanged += new System.EventHandler(this.cboMasach_SelectedIndexChanged);
            // 
            // Soluong
            // 
            this.Soluong.Location = new System.Drawing.Point(83, 371);
            this.Soluong.Name = "Soluong";
            this.Soluong.Size = new System.Drawing.Size(202, 23);
            this.Soluong.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tên sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã sách";
            // 
            // btn_Xoact
            // 
            this.btn_Xoact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoact.Location = new System.Drawing.Point(202, 409);
            this.btn_Xoact.Name = "btn_Xoact";
            this.btn_Xoact.Size = new System.Drawing.Size(83, 35);
            this.btn_Xoact.TabIndex = 4;
            this.btn_Xoact.Text = "Xóa";
            this.btn_Xoact.UseVisualStyleBackColor = true;
            this.btn_Xoact.Click += new System.EventHandler(this.btn_Xoact_Click);
            // 
            // btn_Suact
            // 
            this.btn_Suact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Suact.Location = new System.Drawing.Point(109, 409);
            this.btn_Suact.Name = "btn_Suact";
            this.btn_Suact.Size = new System.Drawing.Size(83, 35);
            this.btn_Suact.TabIndex = 3;
            this.btn_Suact.Text = "Sửa";
            this.btn_Suact.UseVisualStyleBackColor = true;
            this.btn_Suact.Click += new System.EventHandler(this.btn_Suact_Click);
            // 
            // btn_Themct
            // 
            this.btn_Themct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Themct.Location = new System.Drawing.Point(9, 409);
            this.btn_Themct.Name = "btn_Themct";
            this.btn_Themct.Size = new System.Drawing.Size(88, 35);
            this.btn_Themct.TabIndex = 2;
            this.btn_Themct.Text = "Thêm";
            this.btn_Themct.UseVisualStyleBackColor = true;
            this.btn_Themct.Click += new System.EventHandler(this.btn_Themct_Click);
            // 
            // grvChitiethd
            // 
            this.grvChitiethd.AllowUserToAddRows = false;
            this.grvChitiethd.AllowUserToDeleteRows = false;
            this.grvChitiethd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvChitiethd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvChitiethd.Location = new System.Drawing.Point(6, 29);
            this.grvChitiethd.MultiSelect = false;
            this.grvChitiethd.Name = "grvChitiethd";
            this.grvChitiethd.ReadOnly = true;
            this.grvChitiethd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvChitiethd.Size = new System.Drawing.Size(279, 263);
            this.grvChitiethd.TabIndex = 0;
            this.grvChitiethd.TabStop = false;
            this.grvChitiethd.Click += new System.EventHandler(this.grvChitiethd_Click);
            // 
            // btn_Themhd
            // 
            this.btn_Themhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Themhd.Location = new System.Drawing.Point(12, 414);
            this.btn_Themhd.Name = "btn_Themhd";
            this.btn_Themhd.Size = new System.Drawing.Size(100, 41);
            this.btn_Themhd.TabIndex = 7;
            this.btn_Themhd.Text = "Thêm hóa đơn";
            this.btn_Themhd.UseVisualStyleBackColor = true;
            this.btn_Themhd.Click += new System.EventHandler(this.btn_Themhd_Click);
            // 
            // btn_Suahd
            // 
            this.btn_Suahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Suahd.Location = new System.Drawing.Point(118, 414);
            this.btn_Suahd.Name = "btn_Suahd";
            this.btn_Suahd.Size = new System.Drawing.Size(96, 41);
            this.btn_Suahd.TabIndex = 8;
            this.btn_Suahd.Text = "Sửa hóa đơn";
            this.btn_Suahd.UseVisualStyleBackColor = true;
            this.btn_Suahd.Click += new System.EventHandler(this.btn_Suahd_Click);
            // 
            // btn_Xoahd
            // 
            this.btn_Xoahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoahd.Location = new System.Drawing.Point(220, 414);
            this.btn_Xoahd.Name = "btn_Xoahd";
            this.btn_Xoahd.Size = new System.Drawing.Size(89, 41);
            this.btn_Xoahd.TabIndex = 9;
            this.btn_Xoahd.Text = "Xóa hóa đơn";
            this.btn_Xoahd.UseVisualStyleBackColor = true;
            this.btn_Xoahd.Click += new System.EventHandler(this.btn_Xoahd_Click);
            // 
            // btn_In
            // 
            this.btn_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_In.Location = new System.Drawing.Point(315, 414);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(73, 41);
            this.btn_In.TabIndex = 10;
            this.btn_In.Text = "In hóa đơn";
            this.btn_In.UseVisualStyleBackColor = true;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Timkiem.Location = new System.Drawing.Point(343, 5);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(112, 25);
            this.btn_Timkiem.TabIndex = 2;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // cboTimkiem
            // 
            this.cboTimkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimkiem.FormattingEnabled = true;
            this.cboTimkiem.Items.AddRange(new object[] {
            "Mã hóa đơn",
            "Tên khách hàng",
            "Tên nhân viên",
            "Ngày lập"});
            this.cboTimkiem.Location = new System.Drawing.Point(12, 7);
            this.cboTimkiem.Name = "cboTimkiem";
            this.cboTimkiem.Size = new System.Drawing.Size(111, 21);
            this.cboTimkiem.TabIndex = 0;
            // 
            // Timkiem
            // 
            this.Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Timkiem.Location = new System.Drawing.Point(129, 7);
            this.Timkiem.Name = "Timkiem";
            this.Timkiem.Size = new System.Drawing.Size(208, 21);
            this.Timkiem.TabIndex = 1;
            // 
            // MaHD
            // 
            this.MaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaHD.Location = new System.Drawing.Point(109, 312);
            this.MaHD.Name = "MaHD";
            this.MaHD.Size = new System.Drawing.Size(145, 21);
            this.MaHD.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã hóa đơn";
            // 
            // cboKH
            // 
            this.cboKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKH.FormattingEnabled = true;
            this.cboKH.Location = new System.Drawing.Point(109, 346);
            this.cboKH.Name = "cboKH";
            this.cboKH.Size = new System.Drawing.Size(145, 21);
            this.cboKH.TabIndex = 5;
            this.cboKH.SelectedIndexChanged += new System.EventHandler(this.cboKH_SelectedIndexChanged);
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(109, 378);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(145, 21);
            this.cboNV.TabIndex = 6;
            this.cboNV.SelectedIndexChanged += new System.EventHandler(this.cboNV_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(9, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(9, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhân viên lập";
            // 
            // Ngaylap
            // 
            this.Ngaylap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Ngaylap.Location = new System.Drawing.Point(357, 310);
            this.Ngaylap.Name = "Ngaylap";
            this.Ngaylap.Size = new System.Drawing.Size(98, 21);
            this.Ngaylap.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(273, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(273, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã khách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(273, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã nhân viên";
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaNV.Location = new System.Drawing.Point(386, 382);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(20, 17);
            this.MaNV.TabIndex = 7;
            this.MaNV.Text = "...";
            // 
            // MaKH
            // 
            this.MaKH.AutoSize = true;
            this.MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaKH.Location = new System.Drawing.Point(385, 350);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(20, 17);
            this.MaKH.TabIndex = 7;
            this.MaKH.Text = "...";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Clear.Location = new System.Drawing.Point(394, 414);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(61, 41);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(764, 465);
            this.Controls.Add(this.Ngaylap);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.cboKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaKH);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaHD);
            this.Controls.Add(this.Timkiem);
            this.Controls.Add(this.cboTimkiem);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.btn_Xoahd);
            this.Controls.Add(this.btn_Suahd);
            this.Controls.Add(this.btn_Themhd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grvHoadon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.Hoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvHoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvChitiethd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvHoadon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Xoact;
        private System.Windows.Forms.Button btn_Suact;
        private System.Windows.Forms.Button btn_Themct;
        private System.Windows.Forms.DataGridView grvChitiethd;
        private System.Windows.Forms.Button btn_Themhd;
        private System.Windows.Forms.Button btn_Suahd;
        private System.Windows.Forms.Button btn_Xoahd;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.ComboBox cboTimkiem;
        private System.Windows.Forms.TextBox Timkiem;
        private System.Windows.Forms.TextBox MaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKH;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Ngaylap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.Label MaKH;
        private System.Windows.Forms.TextBox Soluong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox cboMasach;
        private System.Windows.Forms.TextBox Tensach;
    }
}