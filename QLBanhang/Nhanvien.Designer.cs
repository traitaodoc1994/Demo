namespace QLBanhang
{
    partial class Nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhanvien));
            this.grvNhanvien = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_In = new System.Windows.Forms.Button();
            this.Timkiem = new System.Windows.Forms.TextBox();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.cboTimkiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // grvNhanvien
            // 
            this.grvNhanvien.AllowUserToAddRows = false;
            this.grvNhanvien.AllowUserToDeleteRows = false;
            this.grvNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvNhanvien.Location = new System.Drawing.Point(12, 46);
            this.grvNhanvien.MultiSelect = false;
            this.grvNhanvien.Name = "grvNhanvien";
            this.grvNhanvien.ReadOnly = true;
            this.grvNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvNhanvien.Size = new System.Drawing.Size(710, 267);
            this.grvNhanvien.TabIndex = 0;
            this.grvNhanvien.TabStop = false;
            this.grvNhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvNhanvien_CellContentClick);
            this.grvNhanvien.Click += new System.EventHandler(this.grvNhanvien_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(68, 342);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(138, 39);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm nhân viên";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(231, 342);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(117, 39);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.Text = "Sửa thông tin";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(367, 342);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(117, 39);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa nhân viên";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_In
            // 
            this.btn_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_In.Location = new System.Drawing.Point(509, 342);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(166, 39);
            this.btn_In.TabIndex = 6;
            this.btn_In.Text = "In danh sách nhân viên";
            this.btn_In.UseVisualStyleBackColor = true;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // Timkiem
            // 
            this.Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Timkiem.Location = new System.Drawing.Point(281, 12);
            this.Timkiem.Name = "Timkiem";
            this.Timkiem.Size = new System.Drawing.Size(205, 21);
            this.Timkiem.TabIndex = 1;
            this.Timkiem.TextChanged += new System.EventHandler(this.Timkiem_TextChanged);
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Timkiem.Location = new System.Drawing.Point(493, 10);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(93, 23);
            this.btn_Timkiem.TabIndex = 2;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // cboTimkiem
            // 
            this.cboTimkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboTimkiem.FormattingEnabled = true;
            this.cboTimkiem.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Họ tên",
            "Giới tính",
            "Năm sinh",
            "Số CMND"});
            this.cboTimkiem.Location = new System.Drawing.Point(151, 11);
            this.cboTimkiem.Name = "cboTimkiem";
            this.cboTimkiem.Size = new System.Drawing.Size(121, 23);
            this.cboTimkiem.TabIndex = 0;
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.cboTimkiem);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.Timkiem);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.grvNhanvien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvNhanvien;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.TextBox Timkiem;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.ComboBox cboTimkiem;
    }
}