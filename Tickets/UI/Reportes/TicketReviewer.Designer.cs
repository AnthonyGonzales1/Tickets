namespace Tickets.UI.Reportes
{
    partial class TicketReviewer
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
            this.TicketcrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // TicketcrystalReportViewer
            // 
            this.TicketcrystalReportViewer.ActiveViewIndex = -1;
            this.TicketcrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TicketcrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TicketcrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketcrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.TicketcrystalReportViewer.Name = "TicketcrystalReportViewer";
            this.TicketcrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.TicketcrystalReportViewer.TabIndex = 0;
            this.TicketcrystalReportViewer.Load += new System.EventHandler(this.TicketcrystalReportViewer_Load);
            // 
            // TicketReviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TicketcrystalReportViewer);
            this.Name = "TicketReviewer";
            this.Text = "TicketReviewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer TicketcrystalReportViewer;
    }
}