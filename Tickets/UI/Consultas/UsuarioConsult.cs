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
    public partial class UsuarioConsult : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        Usuario usuario = new Usuario();
        Expression<Func<Usuario, bool>> filtrar = x => true;
        public UsuarioConsult()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuario, bool>> filtro = a => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Filtrando por ID del Artículo.
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = a => a.UsuarioId == id;
                    break;
                case 1://Filtrando por Nombres del Artículo.
                    filtro = a => a.Nombres.Contains(CriterioTextBox.Text);
                    break;
                case 2://Filtrando por Email del Artículo.
                    filtro = a => a.Email.Equals(CriterioTextBox.Text);
                    break;
                case 3://Filtrando por Clave del Artículo.
                    filtro = a => a.Clave.Equals(CriterioTextBox.Text);
                    break;
            }
            usuarios = BLL.UsuarioBLL.GetList(filtrar);
            UsuarioConsultaDataGridView.DataSource = UsuarioBLL.GetList(filtro);
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
            UsuarioReviewer usuarioReviewer = new UsuarioReviewer(BLL.UsuarioBLL.GetList(filtrar));
            {
                usuarioReviewer.Show();
            }
        }
    }
}
