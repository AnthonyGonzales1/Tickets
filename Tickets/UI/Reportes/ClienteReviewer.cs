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
    public partial class ClienteReviewer : Form
    {
        private List<Cliente> clientes = new List<Cliente>();
        public ClienteReviewer(List<Cliente> cliente)
        {
            this.clientes = cliente;
            InitializeComponent();
        }

        private void ClientecrystalReportViewer_Load(object sender, EventArgs e)
        {
            ClienteCrystalReport clienteCrystal = new ClienteCrystalReport();
            clienteCrystal.SetDataSource(clientes);

            ClientecrystalReportViewer.ReportSource = clienteCrystal;
            clienteCrystal.Refresh();
        }
    }
}
