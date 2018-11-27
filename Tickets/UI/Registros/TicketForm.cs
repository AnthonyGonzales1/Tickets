using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tickets.Entidades;
using Tickets.BLL;
using Tickets.DAL;

namespace Tickets.UI.Registros
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            Repositorio<TipoTicket> Repositorio = new Repositorio<TipoTicket>(new Contexto());
            
            TipoTicketComboBox.DataSource = Repositorio.GetList(c => true);
            TipoTicketComboBox.ValueMember = "TipoTicketId";
            TipoTicketComboBox.DisplayMember = "Descripcion";
        }

        private Ticket LlenaClase()
        {
            Ticket ticket = new Ticket();

            ticket.TicketId = Convert.ToInt32(TicketIdNumericUpDown.Value);
            ticket.TipoTicket = TipoTicketComboBox.Text;
            ticket.NombreEvento = NombreEventoTextBox.Text;
            ticket.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            ticket.Precio = Convert.ToInt32(PrecioTextBox.Text);

            return ticket;
        }

        private void Limpiar()
        {
            TicketIdNumericUpDown.Value = 0;
            TipoTicketComboBox.SelectedIndex = 0;
            NombreEventoTextBox.Clear();
            CantidadTextBox.Clear();
            PrecioTextBox.Clear();
        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(NombreEventoTextBox.Text))
            {
                MyErrorProvider.SetError(NombreEventoTextBox,
                    "Debes escribir un Nombre");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(CantidadTextBox.Text))
            {
                MyErrorProvider.SetError(CantidadTextBox,
                    "Debes escribir una Cantidad");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(PrecioTextBox.Text))
            {
                MyErrorProvider.SetError(PrecioTextBox,
                    "Debes escribir un Precio");
                HayErrores = true;
            }

            return HayErrores;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TicketIdNumericUpDown.Value);
            Ticket ticket = TicketBLL.Buscar(id);

            if (ticket != null)
            {
                TipoTicketComboBox.Text = ticket.TipoTicket;
                NombreEventoTextBox.Text = ticket.NombreEvento;
                CantidadTextBox.Text = ticket.Cantidad.ToString();
                PrecioTextBox.Text = ticket.Precio.ToString();
            }
            else
                MessageBox.Show("No se encontró", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Ticket ticket;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Debe llenar éste campo!!!", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ticket = LlenaClase();

            if (TicketIdNumericUpDown.Value == 0)
                Paso = TicketBLL.Guardar(ticket);
            else
            {
                int id = Convert.ToInt32(TicketIdNumericUpDown.Value);
                ticket = TicketBLL.Buscar(id);

                if (ticket != null)
                {
                    Paso = TicketBLL.Modificar(LlenaClase());
                }
                else
                    MessageBox.Show("Id no existe", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Paso)
            {
                MessageBox.Show("Guardado", "Exito",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }

            else
                MessageBox.Show("No se pudo guardar", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TicketIdNumericUpDown.Value);
            Ticket ticket = TicketBLL.Buscar(id);

            if (ticket != null)
            {
                if (TicketBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
