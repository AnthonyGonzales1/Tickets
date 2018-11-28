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
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private Usuario LlenaClase()
        {
            Usuario usuario = new Usuario();

            usuario.UsuarioId = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            usuario.Nombres = NombresTextBox.Text;
            usuario.Email = EmailTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;

            return usuario;
        }

        private void Limpiar()
        {
            UsuarioIdNumericUpDown.Value = 0;
            NombresTextBox.Clear();
            EmailTextBox.Clear();
            ClaveTextBox.Clear();
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
            if (String.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MyErrorProvider.SetError(EmailTextBox,
                    "Debes escribir un Nmbre para el Cliente");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                MyErrorProvider.SetError(ClaveTextBox,
                    "Debes escribir un Nmbre para el Cliente");
                HayErrores = true;
            }

            return HayErrores;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            Usuario usuario = UsuarioBLL.Buscar(id);

            if (usuario != null)
            {
                NombresTextBox.Text = usuario.Nombres;
                EmailTextBox.Text = usuario.Email;
                ClaveTextBox.Text = usuario.Clave;
            }
            else
                MessageBox.Show("No se encontró", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Debe llenar éste campo!!!", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            usuario = LlenaClase();

            if (UsuarioIdNumericUpDown.Value == 0)
            {
                Paso = UsuarioBLL.Guardar(usuario);
                MessageBox.Show("Guardado", "Exito",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
                usuario = UsuarioBLL.Buscar(id);

                if (usuario != null)
                {
                    Paso = UsuarioBLL.Modificar(LlenaClase());
                    MessageBox.Show("Modificado", "Exito",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Id no existe", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Paso)
            {
               Limpiar();
            }

            else
                MessageBox.Show("No se pudo guardar", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            Usuario usuario = UsuarioBLL.Buscar(id);

            if (usuario != null)
            {
                if (UsuarioBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClaveTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void NombresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void NombresTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClaveTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
