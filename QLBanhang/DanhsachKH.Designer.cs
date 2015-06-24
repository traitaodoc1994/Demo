namespace QLBanhang
{
    partial class DanhsachKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhsachKH));
            this.rptvKhachhang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvKhachhang
            // 
            this.rptvKhachhang.ActiveViewIndex = -1;
            this.rptvKhachhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvKhachhang.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvKhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvKhachhang.Location = new System.Drawing.Point(0, 0);
            this.rptvKhachhang.Name = "rptvKhachhang";
            this.rptvKhachhang.Size = new System.Drawing.Size(649, 397);
            this.rptvKhachhang.TabIndex = 0;
            this.rptvKhachhang.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // DanhsachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 397);
            this.Controls.Add(this.rptvKhachhang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhsachKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhsachKH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvKhachhang;
    }
}