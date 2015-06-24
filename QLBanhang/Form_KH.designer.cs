namespace QLBanhang
{
    partial class Form_KH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_KH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSdtkh = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.testMaKH = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTT2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTT1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScmkh = new System.Windows.Forms.TextBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.grvdata = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMuahang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testMaKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSdtkh);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.testMaKH);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.lblTT2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblTT1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtScmkh);
            this.panel1.Controls.Add(this.txtTenkh);
            this.panel1.Controls.Add(this.txtMakh);
            this.panel1.Controls.Add(this.radNu);
            this.panel1.Controls.Add(this.radNam);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 358);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "SĐT";
            // 
            // txtSdtkh
            // 
            this.txtSdtkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdtkh.Location = new System.Drawing.Point(81, 179);
            this.txtSdtkh.MaxLength = 11;
            this.txtSdtkh.Name = "txtSdtkh";
            this.txtSdtkh.Size = new System.Drawing.Size(205, 26);
            this.txtSdtkh.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QLBanhang.Properties.Resources.exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(164, 308);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 43);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // testMaKH
            // 
            this.testMaKH.Location = new System.Drawing.Point(258, 51);
            this.testMaKH.Name = "testMaKH";
            this.testMaKH.Size = new System.Drawing.Size(25, 25);
            this.testMaKH.TabIndex = 14;
            this.testMaKH.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::QLBanhang.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(35, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 43);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "&Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTT2
            // 
            this.lblTT2.AutoSize = true;
            this.lblTT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT2.ForeColor = System.Drawing.Color.Red;
            this.lblTT2.Location = new System.Drawing.Point(286, 85);
            this.lblTT2.Name = "lblTT2";
            this.lblTT2.Size = new System.Drawing.Size(20, 25);
            this.lblTT2.TabIndex = 13;
            this.lblTT2.Text = "*";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::QLBanhang.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(164, 219);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 43);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm &kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTT1
            // 
            this.lblTT1.AutoSize = true;
            this.lblTT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT1.ForeColor = System.Drawing.Color.Red;
            this.lblTT1.Location = new System.Drawing.Point(286, 53);
            this.lblTT1.Name = "lblTT1";
            this.lblTT1.Size = new System.Drawing.Size(20, 25);
            this.lblTT1.TabIndex = 12;
            this.lblTT1.Text = "*";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::QLBanhang.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(164, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 43);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "&Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(-2, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(323, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "_____________________________________________";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::QLBanhang.Properties.Resources.reset;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(35, 308);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 43);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "&Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(87, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Thông tin khách hàng";
            // 
            // btnInsert
            // 
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Image = global::QLBanhang.Properties.Resources.insert;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(35, 219);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 43);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "&Thêm mới";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "CMT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã KH";
            // 
            // txtScmkh
            // 
            this.txtScmkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScmkh.Location = new System.Drawing.Point(81, 147);
            this.txtScmkh.MaxLength = 9;
            this.txtScmkh.Name = "txtScmkh";
            this.txtScmkh.Size = new System.Drawing.Size(205, 26);
            this.txtScmkh.TabIndex = 5;
            // 
            // txtTenkh
            // 
            this.txtTenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenkh.Location = new System.Drawing.Point(81, 83);
            this.txtTenkh.MaxLength = 50;
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(205, 26);
            this.txtTenkh.TabIndex = 2;
            // 
            // txtMakh
            // 
            this.txtMakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakh.Location = new System.Drawing.Point(81, 51);
            this.txtMakh.MaxLength = 10;
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(171, 26);
            this.txtMakh.TabIndex = 1;
            this.txtMakh.TextChanged += new System.EventHandler(this.txtMakh_TextChanged);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(222, 121);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 4;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(131, 121);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 3;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // grvdata
            // 
            this.grvdata.AllowUserToAddRows = false;
            this.grvdata.AllowUserToDeleteRows = false;
            this.grvdata.AllowUserToResizeColumns = false;
            this.grvdata.AllowUserToResizeRows = false;
            this.grvdata.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.btnMuahang});
            this.grvdata.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvdata.Location = new System.Drawing.Point(320, 1);
            this.grvdata.MultiSelect = false;
            this.grvdata.Name = "grvdata";
            this.grvdata.ReadOnly = true;
            this.grvdata.Size = new System.Drawing.Size(561, 358);
            this.grvdata.TabIndex = 13;
            this.grvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvdata_CellClick);
            this.grvdata.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvdata_RowEnter);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Mã KH";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số CMT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnMuahang
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Mua hàng";
            this.btnMuahang.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnMuahang.HeaderText = "Mua hàng";
            this.btnMuahang.Name = "btnMuahang";
            this.btnMuahang.ReadOnly = true;
            this.btnMuahang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnMuahang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnMuahang.Width = 80;
            // 
            // Form_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(883, 362);
            this.Controls.Add(this.grvdata);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CỬA HÀNG SÁCH";
            this.Load += new System.EventHandler(this.Form_KH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testMaKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox testMaKH;
        private System.Windows.Forms.Label lblTT2;
        private System.Windows.Forms.Label lblTT1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScmkh;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.DataGridView grvdata;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSdtkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn btnMuahang;
    }
}