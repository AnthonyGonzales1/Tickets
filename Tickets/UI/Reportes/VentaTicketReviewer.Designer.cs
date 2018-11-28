namespace Tickets.UI.Reportes
{
    partial class VentaTicketReviewer
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
            this.VentaTicketcrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VentaTicketcrystalReportViewer
            // 
            this.VentaTicketcrystalReportViewer.ActiveViewIndex = -1;
            this.VentaTicketcrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VentaTicketcrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VentaTicketcrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VentaTicketcrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.VentaTicketcrystalReportViewer.Name = "VentaTicketcrystalReportViewer";
            this.VentaTicketcrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.VentaTicketcrystalReportViewer.TabIndex = 0;
            this.VentaTicketcrystalReportViewer.Load += new System.EventHandler(this.VentaTicketcrystalReportViewer_Load);
            // 
            // VentaTicketReviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VentaTicketcrystalReportViewer);
            this.Name = "VentaTicketReviewer";
            this.Text = "VentaTicketReviewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer VentaTicketcrystalReportViewer;
    }
}