using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tickets
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source = .\SqlExpress; Initial Catalog = TicketDb; "
             + "Integrated Security=true;");

            conexion.Open();
            string cadena = "select Email, Clave from Usuarios where Email ='" + EmailTextBox.Text + "' and Clave = '" + ClaveTextBox.Text + "' ";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {

                if ((registro["Email"].ToString() == EmailTextBox.Text) && (registro["CLave"].ToString() == ClaveTextBox.Text))
                {
                    MessageBox.Show("Bienvenido");
                    Principal principal = new Principal();
                    principal.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("El Email o la Clave estan incorrectos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            conexion.Close();
            
        }
    }
}
