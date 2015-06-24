namespace QLBanhang
{
    partial class Inhoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inhoadon));
            this.rptvHoadon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvHoadon
            // 
            this.rptvHoadon.ActiveViewIndex = -1;
            this.rptvHoadon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvHoadon.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvHoadon.Location = new System.Drawing.Point(0, 0);
            this.rptvHoadon.Name = "rptvHoadon";
            this.rptvHoadon.Size = new System.Drawing.Size(780, 421);
            this.rptvHoadon.TabIndex = 0;
            this.rptvHoadon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Inhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 421);
            this.Controls.Add(this.rptvHoadon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inhoadon";
            this.Text = "Hóa đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inhoadon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvHoadon;
    }
}