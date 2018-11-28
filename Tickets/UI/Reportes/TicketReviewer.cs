using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tickets.Entidades;

namespace Tickets.UI.Reportes
{
    public partial class TicketReviewer : Form
    {
        private List<Ticket> tickets = new List<Ticket>();
        public TicketReviewer(List<Ticket> ticket)
        {
            this.tickets = ticket;
            InitializeComponent();
        }

        private void TicketcrystalReportViewer_Load(object sender, EventArgs e)
        {
            TicketCrystalReport ticketCrystal = new TicketCrystalReport();
            ticketCrystal.SetDataSource(tickets);

            TicketcrystalReportViewer.ReportSource = ticketCrystal;
            ticketCrystal.Refresh();
        }
    }
}
