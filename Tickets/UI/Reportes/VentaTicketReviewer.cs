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
    public partial class VentaTicketReviewer : Form
    {
        private List<VentaTicket> ventaTickets = new List<VentaTicket>();
        public VentaTicketReviewer(List<VentaTicket> ventaTicket)
        {
            this.ventaTickets = ventaTicket;
            InitializeComponent();
        }

        private void VentaTicketcrystalReportViewer_Load(object sender, EventArgs e)
        {
            VentaTicketCrystalReport ventaTicketCrystal = new VentaTicketCrystalReport();
            ventaTicketCrystal.SetDataSource(ventaTickets);

            VentaTicketcrystalReportViewer.ReportSource = ventaTicketCrystal;
            ventaTicketCrystal.Refresh();
        }
    }
}
