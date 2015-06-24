namespace QLBanhang
{
    partial class Huongdan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Huongdan));
            this.hd = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // hd
            // 
            this.hd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hd.Location = new System.Drawing.Point(0, 0);
            this.hd.Name = "hd";
            this.hd.ReadOnly = true;
            this.hd.Size = new System.Drawing.Size(430, 261);
            this.hd.TabIndex = 0;
            this.hd.Text = "";
            // 
            // Huongdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 261);
            this.Controls.Add(this.hd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Huongdan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng dẫn";
            this.Load += new System.EventHandler(this.Huongdan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox hd;
    }
}