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
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private Cliente LlenaClase()
        {
            Cliente cliente = new Cliente();

            cliente.ClienteId = Convert.ToInt32(ClienteIdNumericUpDown.Value);
            cliente.Nombres = NombresTextBox.Text;
            cliente.Telefono = TelefonoMaskedTextBox.Text;
            cliente.Deuda = 0;

            return cliente;
        }

        private void Limpiar()
        {
            ClienteIdNumericUpDown.Value = 0;
            NombresTextBox.Clear();
            TelefonoMaskedTextBox.Clear();
            DeudaTextBox.Clear();
        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                MyErrorProvider.SetError(NombresTextBox,
                    "Debes escribir un Nmbre para el Cliente");
                HayErrores = true;
            }

            return HayErrores;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ClienteIdNumericUpDown.Value);
            Cliente cliente = ClienteBLL.Buscar(id);

            if (cliente != null)
            {
                NombresTextBox.Text = cliente.Nombres;
                TelefonoMaskedTextBox.Text = cliente.Telefono.ToString();
                DeudaTextBox.Text = cliente.Deuda.ToString();
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
            Cliente cliente;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Debe llenar éste campo!!!", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cliente = LlenaClase();

            if (ClienteIdNumericUpDown.Value == 0)
                Paso = ClienteBLL.Guardar(cliente);
            else
            {
                int id = Convert.ToInt32(ClienteIdNumericUpDown.Value);
                cliente = ClienteBLL.Buscar(id);

                if (cliente != null)
                {
                    Paso = ClienteBLL.Modificar(LlenaClase());
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
            int id = Convert.ToInt32(ClienteIdNumericUpDown.Value);
            Cliente cliente = ClienteBLL.Buscar(id);

            if (cliente != null)
            {
                if (ClienteBLL.Eliminar(id))
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
