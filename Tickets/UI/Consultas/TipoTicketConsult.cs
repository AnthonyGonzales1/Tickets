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
    public partial class TipoTicketConsult : Form
    {
        List<TipoTicket> tipoTickets = new List<TipoTicket>();
        TipoTicket tipoTicket = new TipoTicket();
        Expression<Func<TipoTicket, bool>> filtrar = x => true;
        public TipoTicketConsult()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<TipoTicket, bool>> filtro = m => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = m => m.TipoTicketId == id;
                    break;
                case 1://Filtrando por Descripcion
                    filtro = m => m.Descripcion.Equals(CriterioTextBox.Text);
                    break;
                case 2://Filtrando por Lugar
                    filtro = m => m.Lugar.Equals(CriterioTextBox.Text);
                    break;
                case 3://Filtrando por Fecha .
                    filtro = m => m.FechaHora >= DesdeDateTimePicker.Value && m.FechaHora <= HastaDateTimePicker.Value;
                    break;
            }
            tipoTickets = BLL.TipoTicketBLL.GetList(filtrar);
            TipoTicketConsultDataGridView.DataSource = TipoTicketBLL.GetList(filtro);
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

        private void CriterioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            TipoTicketReviewer tipoTicketReviewer = new TipoTicketReviewer(BLL.TipoTicketBLL.GetList(filtrar));
            {
                tipoTicketReviewer.Show();
            }
        }
    }
}
