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

namespace Tickets.UI.Registros
{
    public partial class TipoTicketForm : Form
    {
        public TipoTicketForm()
        {
            InitializeComponent();
        }

        private TipoTicket LlenaClase()
        {
            TipoTicket tipoTicket = new TipoTicket();

            tipoTicket.TipoTicketId = Convert.ToInt32(TipoTicketIdNumericUpDown.Value);
            tipoTicket.Descripcion = DescripcionTextBox.Text;
            tipoTicket.Lugar = LugarTextBox.Text;
            tipoTicket.FechaHora = FechaDateTimePicker.Value;

            return tipoTicket;
        }

        private void Limpiar()
        {
            TipoTicketIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            LugarTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Now;
        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionTextBox,
                    "Debes escribir un Nmbre para el Cliente");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(LugarTextBox.Text))
            {
                MyErrorProvider.SetError(LugarTextBox,
                    "Debes escribir un Nmbre para el Cliente");
                HayErrores = true;
            }
            return HayErrores;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TipoTicketIdNumericUpDown.Value);
            TipoTicket tipoTicket = TipoTicketBLL.Buscar(id);

            if (tipoTicket != null)
            {
                DescripcionTextBox.Text = tipoTicket.Descripcion;
                LugarTextBox.Text = tipoTicket.Lugar;
                FechaDateTimePicker.Value = tipoTicket.FechaHora;
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
            TipoTicket tipoTicket;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Debe llenar éste campo!!!", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tipoTicket = LlenaClase();

            if (TipoTicketIdNumericUpDown.Value == 0)
                Paso = TipoTicketBLL.Guardar(tipoTicket);
            else
            {
                int id = Convert.ToInt32(TipoTicketIdNumericUpDown.Value);
                tipoTicket = TipoTicketBLL.Buscar(id);

                if (tipoTicket != null)
                {
                    Paso = TipoTicketBLL.Modificar(LlenaClase());
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
            int id = Convert.ToInt32(TipoTicketIdNumericUpDown.Value);
            TipoTicket tipoTicket = TipoTicketBLL.Buscar(id);

            if (tipoTicket != null)
            {
                if (TipoTicketBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
