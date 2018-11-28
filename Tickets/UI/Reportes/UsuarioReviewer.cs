using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tickets.Entidades;

namespace Tickets.UI.Reportes
{
    public partial class UsuarioReviewer : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        public UsuarioReviewer(List<Usuario> usuario)
        {
            this.usuarios = usuario;
            InitializeComponent();
        }

        private void UsuariocrystalReportViewer_Load(object sender, EventArgs e)
        {
            UsuarioCrystalReport usuarioCrystal = new UsuarioCrystalReport();
            usuarioCrystal.SetDataSource(usuarios);

            UsuariocrystalReportViewer.ReportSource = usuarioCrystal;
            usuarioCrystal.Refresh();
        }
    }
}
