namespace QLBanhang
{
    partial class DanhsachNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhsachNV));
            this.rptvNhanvien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvNhanvien
            // 
            this.rptvNhanvien.ActiveViewIndex = -1;
            this.rptvNhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvNhanvien.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvNhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvNhanvien.Location = new System.Drawing.Point(0, 0);
            this.rptvNhanvien.Name = "rptvNhanvien";
            this.rptvNhanvien.Size = new System.Drawing.Size(720, 464);
            this.rptvNhanvien.TabIndex = 0;
            this.rptvNhanvien.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // DanhsachNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 464);
            this.Controls.Add(this.rptvNhanvien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhsachNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhsachNV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvNhanvien;
    }
}