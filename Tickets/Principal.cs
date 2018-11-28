using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tickets.UI.Registros;
using Tickets.UI.Consultas;

namespace Tickets
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.MdiParent = this;
            clienteForm.Show();
        }

        private void tipoTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoTicketForm tipoTicketForm = new TipoTicketForm();
            tipoTicketForm.MdiParent = this;
            tipoTicketForm.Show();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.MdiParent = this;
            ticketForm.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioForm usuarioForm = new UsuarioForm();
            usuarioForm.MdiParent = this;
            usuarioForm.Show();
        }

        private void ventaTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaTicketForm ventaTicketForm = new VentaTicketForm();
            ventaTicketForm.MdiParent = this;
            ventaTicketForm.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClienteConsult ClienteConsult = new ClienteConsult();
            ClienteConsult.MdiParent = this;
            ClienteConsult.Show();
        }

        private void ticketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TicketConsult TicketConsult = new TicketConsult();
            TicketConsult.MdiParent = this;
            TicketConsult.Show();
        }

        private void tipoTicketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TipoTicketConsult TipoTicketConsult = new TipoTicketConsult();
            TipoTicketConsult.MdiParent = this;
            TipoTicketConsult.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UsuarioConsult UsuarioConsult = new UsuarioConsult();
            UsuarioConsult.MdiParent = this;
            UsuarioConsult.Show();
        }

        private void ventaTicketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VentaTicketConsult ventaTicketConsult = new VentaTicketConsult();
            ventaTicketConsult.MdiParent = this;
            ventaTicketConsult.Show();
        }
    }
}
