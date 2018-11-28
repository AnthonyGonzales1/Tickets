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
    public partial class TicketConsult : Form
    {

        List<Ticket> tickets = new List<Ticket>();
        Ticket ticket = new Ticket();
        Expression<Func<Ticket, bool>> filtrar = x => true;
        public TicketConsult()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<Ticket, bool>> filtro = a => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = a => a.TicketId == id;
                    break;
                case 1://Filtrando por Tipo Ticket
                    filtro = a => a.TipoTicket.Contains(CriterioTextBox.Text);
                    break;
                case 2://Filtrando por Nombre Evento
                    filtro = a => a.NombreEvento.Equals(CriterioTextBox.Text);
                    break;
                case 3://Filtrando por Cantidad
                    filtro = a => a.Cantidad.Equals(CriterioTextBox.Text);
                    break;
                case 4://Filtrando por Precio
                    filtro = a => a.Precio.Equals(CriterioTextBox.Text);
                    break;
            }
            tickets = BLL.TicketBLL.GetList(filtrar);
            TicketConsultaDataGridView.DataSource = TicketBLL.GetList(filtro);
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltroComboBox.SelectedIndex == 1)
            {
                CriterioTextBox.Visible = false;
                label1.Visible = false;
            }
            else
            {
                CriterioTextBox.Visible = true;
                label1.Visible = true;
            }
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            TicketReviewer ticketReviewer = new TicketReviewer(BLL.TicketBLL.GetList(filtrar));
            {
                ticketReviewer.Show();
            }
        }
    }
}
