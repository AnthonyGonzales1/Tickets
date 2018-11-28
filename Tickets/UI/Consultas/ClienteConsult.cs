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
    public partial class ClienteConsult : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        Cliente cliente = new Cliente();
        Expression<Func<Cliente, bool>> filtrar = x => true;
        public ClienteConsult()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            Expression<Func<Cliente, bool>> filtro = a => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = a => a.ClienteId == id;
                    break;
                case 1://Filtrando por Tipo Ticket
                    filtro = a => a.Nombres.Contains(CriterioTextBox.Text);
                    break;
                case 2://Filtrando por Nombre Evento
                    filtro = a => a.Telefono.Equals(CriterioTextBox.Text);
                    break;
                case 3://Filtrando por Cantidad
                    filtro = a => a.Deuda.Equals(CriterioTextBox.Text);
                    break;
            }

            clientes = BLL.ClienteBLL.GetList(filtrar);
            ClienteConsultDataGridView.DataSource = ClienteBLL.GetList(filtro);
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
            ClienteReviewer clienteReviewer = new ClienteReviewer(BLL.ClienteBLL.GetList(filtrar));
            {
                clienteReviewer.Show();
            }
        }
    }
}
