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
    public partial class TipoTicketReviewer : Form
    {
        private List<TipoTicket> tipoTickets = new List<TipoTicket>();
        public TipoTicketReviewer(List<TipoTicket> tipoTicket)
        {
            this.tipoTickets = tipoTicket;
            InitializeComponent();
        }

        private void TipoTicketcrystalReportViewer_Load(object sender, EventArgs e)
        {
            TipoTicketCrystalReport tipoTicketCrystal = new TipoTicketCrystalReport();
            tipoTicketCrystal.SetDataSource(tipoTickets);

            TipoTicketcrystalReportViewer.ReportSource = tipoTicketCrystal;
            tipoTicketCrystal.Refresh();
        }
    }
}
