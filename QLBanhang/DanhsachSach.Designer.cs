namespace QLBanhang
{
    partial class DanhsachSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhsachSach));
            this.rptvSach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvSach
            // 
            this.rptvSach.ActiveViewIndex = -1;
            this.rptvSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvSach.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvSach.Location = new System.Drawing.Point(0, 0);
            this.rptvSach.Name = "rptvSach";
            this.rptvSach.Size = new System.Drawing.Size(734, 467);
            this.rptvSach.TabIndex = 0;
            this.rptvSach.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // DanhsachSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 467);
            this.Controls.Add(this.rptvSach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhsachSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thống kê sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhsachSach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvSach;
    }
}