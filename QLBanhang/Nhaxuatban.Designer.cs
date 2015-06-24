namespace QLBanhang
{
    partial class Nhaxuatban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhaxuatban));
            this.grvNXB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Timkiem = new System.Windows.Forms.TextBox();
            this.Diachi = new System.Windows.Forms.TextBox();
            this.Sdt = new System.Windows.Forms.TextBox();
            this.TenNXB = new System.Windows.Forms.TextBox();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.MaNXB = new System.Windows.Forms.TextBox();
            this.cboTimkiem = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_In = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // grvNXB
            // 
            this.grvNXB.AllowUserToAddRows = false;
            this.grvNXB.AllowUserToDeleteRows = false;
            this.grvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvNXB.Location = new System.Drawing.Point(12, 41);
            this.grvNXB.MultiSelect = false;
            this.grvNXB.Name = "grvNXB";
            this.grvNXB.ReadOnly = true;
            this.grvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvNXB.Size = new System.Drawing.Size(571, 260);
            this.grvNXB.TabIndex = 0;
            this.grvNXB.TabStop = false;
            this.grvNXB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvNXB_CellContentClick);
            this.grvNXB.Click += new System.EventHandler(this.grvNXB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhà xuất bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(308, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(308, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số điện thoại";
            // 
            // Timkiem
            // 
            this.Timkiem.Location = new System.Drawing.Point(202, 11);
            this.Timkiem.Name = "Timkiem";
            this.Timkiem.Size = new System.Drawing.Size(200, 20);
            this.Timkiem.TabIndex = 1;
            // 
            // Diachi
            // 
            this.Diachi.Location = new System.Drawing.Point(135, 359);
            this.Diachi.Name = "Diachi";
            this.Diachi.Size = new System.Drawing.Size(150, 20);
            this.Diachi.TabIndex = 5;
            // 
            // Sdt
            // 
            this.Sdt.Location = new System.Drawing.Point(433, 359);
            this.Sdt.Name = "Sdt";
            this.Sdt.Size = new System.Drawing.Size(150, 20);
            this.Sdt.TabIndex = 6;
            this.Sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sdt_KeyPress);
            // 
            // TenNXB
            // 
            this.TenNXB.Location = new System.Drawing.Point(433, 319);
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.Size = new System.Drawing.Size(150, 20);
            this.TenNXB.TabIndex = 4;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Timkiem.Location = new System.Drawing.Point(408, 7);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(100, 25);
            this.btn_Timkiem.TabIndex = 2;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // MaNXB
            // 
            this.MaNXB.Location = new System.Drawing.Point(135, 321);
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.Size = new System.Drawing.Size(150, 20);
            this.MaNXB.TabIndex = 3;
            // 
            // cboTimkiem
            // 
            this.cboTimkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimkiem.FormattingEnabled = true;
            this.cboTimkiem.Items.AddRange(new object[] {
            "Mã nhà xuất bản",
            "Tên nhà xuất bản",
            "Địa chỉ",
            "Số điện thoại"});
            this.cboTimkiem.Location = new System.Drawing.Point(75, 10);
            this.cboTimkiem.Name = "cboTimkiem";
            this.cboTimkiem.Size = new System.Drawing.Size(121, 21);
            this.cboTimkiem.TabIndex = 0;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(15, 402);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 50);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm NXB";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(121, 402);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 50);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa thông tin";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(227, 402);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 50);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa NXB";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_In
            // 
            this.btn_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_In.Location = new System.Drawing.Point(439, 402);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(144, 50);
            this.btn_In.TabIndex = 11;
            this.btn_In.Text = "In danh sách";
            this.btn_In.UseVisualStyleBackColor = true;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(333, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nhaxuatban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(595, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cboTimkiem);
            this.Controls.Add(this.MaNXB);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.TenNXB);
            this.Controls.Add(this.Sdt);
            this.Controls.Add(this.Diachi);
            this.Controls.Add(this.Timkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvNXB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nhaxuatban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhà xuất bản";
            this.Load += new System.EventHandler(this.Nhaxuatban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvNXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvNXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Timkiem;
        private System.Windows.Forms.TextBox Diachi;
        private System.Windows.Forms.TextBox Sdt;
        private System.Windows.Forms.TextBox TenNXB;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.TextBox MaNXB;
        private System.Windows.Forms.ComboBox cboTimkiem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.Button button1;
    }
}