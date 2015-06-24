namespace QLBanhang
{
    partial class Sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sach));
            this.grvSach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mota = new System.Windows.Forms.RichTextBox();
            this.NXB = new System.Windows.Forms.Label();
            this.Namxb = new System.Windows.Forms.Label();
            this.Dongia = new System.Windows.Forms.Label();
            this.Sl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.cboTimkiem = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.Suasach = new System.Windows.Forms.Button();
            this.XoaSach = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cboSosanh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvSach
            // 
            this.grvSach.AllowUserToAddRows = false;
            this.grvSach.AllowUserToDeleteRows = false;
            this.grvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSach.Location = new System.Drawing.Point(12, 53);
            this.grvSach.MultiSelect = false;
            this.grvSach.Name = "grvSach";
            this.grvSach.ReadOnly = true;
            this.grvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvSach.Size = new System.Drawing.Size(447, 291);
            this.grvSach.TabIndex = 20;
            this.grvSach.TabStop = false;
            this.grvSach.Click += new System.EventHandler(this.grvSach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Mota);
            this.groupBox1.Controls.Add(this.NXB);
            this.groupBox1.Controls.Add(this.Namxb);
            this.groupBox1.Controls.Add(this.Dongia);
            this.groupBox1.Controls.Add(this.Sl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(465, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(4, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tóm tắt nội dung:";
            // 
            // Mota
            // 
            this.Mota.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Mota.Location = new System.Drawing.Point(14, 180);
            this.Mota.Name = "Mota";
            this.Mota.ReadOnly = true;
            this.Mota.Size = new System.Drawing.Size(232, 160);
            this.Mota.TabIndex = 2;
            this.Mota.TabStop = false;
            this.Mota.Text = "";
            // 
            // NXB
            // 
            this.NXB.AutoSize = true;
            this.NXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NXB.Location = new System.Drawing.Point(85, 60);
            this.NXB.Name = "NXB";
            this.NXB.Size = new System.Drawing.Size(16, 15);
            this.NXB.TabIndex = 0;
            this.NXB.Text = "...";
            this.NXB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Namxb
            // 
            this.Namxb.AutoSize = true;
            this.Namxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Namxb.Location = new System.Drawing.Point(99, 31);
            this.Namxb.Name = "Namxb";
            this.Namxb.Size = new System.Drawing.Size(16, 15);
            this.Namxb.TabIndex = 0;
            this.Namxb.Text = "...";
            // 
            // Dongia
            // 
            this.Dongia.AutoSize = true;
            this.Dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Dongia.Location = new System.Drawing.Point(66, 92);
            this.Dongia.Name = "Dongia";
            this.Dongia.Size = new System.Drawing.Size(16, 15);
            this.Dongia.TabIndex = 0;
            this.Dongia.Text = "...";
            this.Dongia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Sl
            // 
            this.Sl.AutoSize = true;
            this.Sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Sl.Location = new System.Drawing.Point(84, 123);
            this.Sl.Name = "Sl";
            this.Sl.Size = new System.Drawing.Size(16, 15);
            this.Sl.TabIndex = 0;
            this.Sl.Text = "...";
            this.Sl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượn còn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(4, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhà xuất bản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm xuất bản:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(321, 15);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(151, 20);
            this.txtTimkiem.TabIndex = 2;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Timkiem.Location = new System.Drawing.Point(478, 13);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_Timkiem.TabIndex = 3;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            this.btn_Timkiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboTimkiem
            // 
            this.cboTimkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboTimkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimkiem.FormattingEnabled = true;
            this.cboTimkiem.Items.AddRange(new object[] {
            "Mã sách",
            "Tác giả",
            "Tên sách",
            "Năm xuất bản",
            "Nhà xuất bản",
            "Đơn giá"});
            this.cboTimkiem.Location = new System.Drawing.Point(209, 14);
            this.cboTimkiem.Name = "cboTimkiem";
            this.cboTimkiem.Size = new System.Drawing.Size(106, 21);
            this.cboTimkiem.TabIndex = 0;
            this.cboTimkiem.SelectedIndexChanged += new System.EventHandler(this.cboTimkiem_SelectedIndexChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(12, 350);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(108, 49);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm sách";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Suasach
            // 
            this.Suasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Suasach.Location = new System.Drawing.Point(126, 350);
            this.Suasach.Name = "Suasach";
            this.Suasach.Size = new System.Drawing.Size(110, 49);
            this.Suasach.TabIndex = 5;
            this.Suasach.Text = "Sửa thông tin";
            this.Suasach.UseVisualStyleBackColor = true;
            this.Suasach.Click += new System.EventHandler(this.button3_Click);
            // 
            // XoaSach
            // 
            this.XoaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.XoaSach.Location = new System.Drawing.Point(242, 350);
            this.XoaSach.Name = "XoaSach";
            this.XoaSach.Size = new System.Drawing.Size(107, 49);
            this.XoaSach.TabIndex = 6;
            this.XoaSach.Text = "Xóa sách";
            this.XoaSach.UseVisualStyleBackColor = true;
            this.XoaSach.Click += new System.EventHandler(this.XoaSach_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.Location = new System.Drawing.Point(355, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 49);
            this.button5.TabIndex = 7;
            this.button5.Text = "In danh sách";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cboSosanh
            // 
            this.cboSosanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSosanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboSosanh.FormattingEnabled = true;
            this.cboSosanh.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.cboSosanh.Location = new System.Drawing.Point(321, 14);
            this.cboSosanh.Name = "cboSosanh";
            this.cboSosanh.Size = new System.Drawing.Size(39, 21);
            this.cboSosanh.TabIndex = 1;
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.cboSosanh);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.XoaSach);
            this.Controls.Add(this.Suasach);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cboTimkiem);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grvSach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Mota;
        private System.Windows.Forms.Label NXB;
        private System.Windows.Forms.Label Namxb;
        private System.Windows.Forms.Label Dongia;
        private System.Windows.Forms.Label Sl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.ComboBox cboTimkiem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button Suasach;
        private System.Windows.Forms.Button XoaSach;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cboSosanh;
    }
}