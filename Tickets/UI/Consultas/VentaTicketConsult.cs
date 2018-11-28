using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Tickets.BLL;
using Tickets.Entidades;
using Tickets.UI.Reportes;

namespace Tickets.UI.Consultas
{
    public partial class VentaTicketConsult : Form
    {
        List<VentaTicket> ventaTickets = new List<VentaTicket>();
        VentaTicket ventaTicket = new VentaTicket();
        Expression<Func<VentaTicket, bool>> filtrar = x => true;
        public VentaTicketConsult()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<VentaTicket, bool>> filtro = m => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = m => m.VentaTicketId == id;
                    break;
                case 1://Filtrando por Cliente Id
                    filtro = m => m.ClienteId.Equals(CriterioTextBox.Text);
                    break;
                case 2://Filtrando por Ticket Id
                    filtro = m => m.TicketId.Equals(CriterioTextBox.Text);
                    break;
                case 3://Filtrando por Fecha .
                    filtro = m => m.Fecha >= DesdeDateTimePicker.Value && m.Fecha <= HastaDateTimePicker.Value;
                    break;
                case 4://Filtrando por Sub Total 
                    filtro = m => m.SubTotal.Equals(CriterioTextBox.Text);
                    break;
                case 5://Filtrando por Itbis
                    filtro = m => m.Itbis.Equals(CriterioTextBox.Text);
                    break;
                case 6://Filtrando por Total
                    filtro = m => m.Total.Equals(CriterioTextBox.Text);
                    break;
            }
            ventaTickets = BLL.VentaTicketBLL.GetList(filtrar);
            VentaTicketConsultDataGridView.DataSource = VentaTicketBLL.GetList(filtro);
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltroComboBox.SelectedIndex == 1)
            {
                CriterioTextBox.Visible = false;
                CriterioLabel.Visible = false;
            }
            else
            {
                CriterioTextBox.Visible = true;
                CriterioLabel.Visible = true;
            }
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            VentaTicketReviewer ventaTicketReviewer = new VentaTicketReviewer(BLL.VentaTicketBLL.GetList(filtrar));
            {
                ventaTicketReviewer.Show();
            }
        }
    }
}
