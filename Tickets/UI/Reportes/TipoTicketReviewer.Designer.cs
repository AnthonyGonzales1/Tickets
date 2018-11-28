namespace Tickets.UI.Reportes
{
    partial class TipoTicketReviewer
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
            this.TipoTicketcrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // TipoTicketcrystalReportViewer
            // 
            this.TipoTicketcrystalReportViewer.ActiveViewIndex = -1;
            this.TipoTicketcrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TipoTicketcrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TipoTicketcrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipoTicketcrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.TipoTicketcrystalReportViewer.Name = "TipoTicketcrystalReportViewer";
            this.TipoTicketcrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.TipoTicketcrystalReportViewer.TabIndex = 0;
            this.TipoTicketcrystalReportViewer.Load += new System.EventHandler(this.TipoTicketcrystalReportViewer_Load);
            // 
            // TipoTicketReviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TipoTicketcrystalReportViewer);
            this.Name = "TipoTicketReviewer";
            this.Text = "TipoTicketReviewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer TipoTicketcrystalReportViewer;
    }
}