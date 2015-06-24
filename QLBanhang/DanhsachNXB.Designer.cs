namespace QLBanhang
{
    partial class DanhsachNXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhsachNXB));
            this.rptvNXB = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvNXB
            // 
            this.rptvNXB.ActiveViewIndex = -1;
            this.rptvNXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvNXB.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvNXB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvNXB.Location = new System.Drawing.Point(0, 0);
            this.rptvNXB.Name = "rptvNXB";
            this.rptvNXB.Size = new System.Drawing.Size(671, 393);
            this.rptvNXB.TabIndex = 0;
            this.rptvNXB.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // DanhsachNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 393);
            this.Controls.Add(this.rptvNXB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhsachNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách nhà xuất bản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhsachNXB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvNXB;
    }
}