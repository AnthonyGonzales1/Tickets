using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tickets.BLL;
using Tickets.Entidades;
using Tickets.DAL;

namespace Tickets.UI.Registros
{
    public partial class VentaTicketForm : Form
    {
        public VentaTicketForm()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            Repositorio<Cliente> Repositorio = new Repositorio<Cliente>(new Contexto());
            Repositorio<Ticket> Repositorios = new Repositorio<Ticket>(new Contexto());

            ClienteComboBox.DataSource = Repositorio.GetList(c => true);
            ClienteComboBox.ValueMember = "ClienteId";
            ClienteComboBox.DisplayMember = "Nombres";

            TicketComboBox.DataSource = Repositorios.GetList(c => true);
            TicketComboBox.ValueMember = "TicketId";
            TicketComboBox.DisplayMember = "NombreEvento";

            //CambiarPrecio();
        }

        private void LlenarCampos(VentaTicket ventaTicket)
        {
            VentaTicketIdNumericUpDown.Value = ventaTicket.VentaTicketId;
            ClienteComboBox.SelectedValue = ventaTicket.ClienteId;
            TicketComboBox.SelectedValue = ventaTicket.TicketId;
            FechaDateTimePicker.Value = ventaTicket.Fecha;
            SubTotalTextBox.Text = ventaTicket.SubTotal.ToString();
            ItbisTextBox.Text = ventaTicket.Itbis.ToString();
            TotalTextBox.Text = ventaTicket.Total.ToString();

            VentaTicketDetalleDataGridView.DataSource = ventaTicket.Detalle;

            VentaTicketDetalleDataGridView.Columns["Id"].Visible = false;
            VentaTicketDetalleDataGridView.Columns["VentaTicketId"].Visible = false;
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private VentaTicket LlenaClase()
        {
            VentaTicket ventaTicket = new VentaTicket();

            ventaTicket.VentaTicketId = Convert.ToInt32(VentaTicketIdNumericUpDown.Value);
            ventaTicket.ClienteId = Convert.ToInt32(ClienteComboBox.SelectedValue);
            ventaTicket.TicketId = Convert.ToInt32(TicketComboBox.SelectedValue);
            ventaTicket.Fecha = FechaDateTimePicker.Value;
            ventaTicket.SubTotal = Convert.ToSingle(SubTotalTextBox.Text);
            ventaTicket.Itbis = Convert.ToSingle(ItbisTextBox.Text);
            ventaTicket.Total = Convert.ToSingle(TotalTextBox.Text);

            foreach (DataGridViewRow item in VentaTicketDetalleDataGridView.Rows)
            {
                ventaTicket.AgregarDetalle(
                    ToInt(item.Cells["Id"].Value),
                    ToInt(item.Cells["VentaTicketId"].Value),
                    ToInt(item.Cells["ClienteId"].Value),
                    ToInt(item.Cells["TicketId"].Value),
                    ToInt(item.Cells["Cantidad"].Value),
                    ToInt(item.Cells["Precio"].Value),
                    ToInt(item.Cells["Importe"].Value)
                );
            }

            VentaTicketDetalleDataGridView.Columns["Id"].Visible = false;
            VentaTicketDetalleDataGridView.Columns["VentaTicketId"].Visible = false;

            return ventaTicket;
        }

        private void Limpiar()
        {
            VentaTicketIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            CantidadTextBox.Clear();
            PrecioTextBox.Clear();
            ImporteTextBox.Clear();
            VentaTicketDetalleDataGridView.DataSource = null;
            SubTotalTextBox.Clear();
            ItbisTextBox.Clear();
            TotalTextBox.Clear();
            MyErrorProvider.Clear();
        }

        private void LlenarPrecio()
        {
            List<Ticket> lista = TicketBLL.GetList(c => c.NombreEvento == TicketComboBox.Text);
            foreach (var item in lista)
            {
                PrecioTextBox.Text = item.Precio.ToString();
            }
        }

        private void LlenarImporte()
        {
            int cantidad, precio;

            cantidad = ToInt(CantidadTextBox.Text);
            precio = ToInt(PrecioTextBox.Text);
            ImporteTextBox.Text = VentaTicketBLL.Importe(cantidad, precio).ToString();
        }

        private void LlenarValores()
        {
            List<VentaTicketDetalle> detalle = new List<VentaTicketDetalle>();

            if (VentaTicketDetalleDataGridView.DataSource != null)
            {
                detalle = (List<VentaTicketDetalle>)VentaTicketDetalleDataGridView.DataSource;
            }
            int Total = 0;
            int Itbis = 0;
            int SubTotal = 0;
            foreach (var item in detalle)
            {
                Total += item.Importe;
            }
            Itbis = (Total * 18) / 100;
            SubTotal = Total - Itbis;
            SubTotalTextBox.Text = SubTotal.ToString();
            ItbisTextBox.Text = Itbis.ToString();
            TotalTextBox.Text = Total.ToString();
        }

        private void RebajarValores()
        {
            List<VentaTicketDetalle> detalle = new List<VentaTicketDetalle>();

            if (VentaTicketDetalleDataGridView.DataSource != null)
            {
                detalle = (List<VentaTicketDetalle>)VentaTicketDetalleDataGridView.DataSource;
            }
            int Total = 0;
            int Itbis = 0;
            int SubTotal = 0;
            foreach (var item in detalle)
            {
                Total -= item.Importe;
            }
            Total *= (-1);
            Itbis = (Total * 18) / 100;
            SubTotal = Total - Itbis;
            SubTotalTextBox.Text = SubTotal.ToString();
            ItbisTextBox.Text = Itbis.ToString();
            TotalTextBox.Text = Total.ToString();
        }

        private bool ContarCantidadInventario()
        {
            List<VentaTicketDetalle> detalle = new List<VentaTicketDetalle>();

            if (VentaTicketDetalleDataGridView.DataSource != null)
            {
                detalle = (List<VentaTicketDetalle>)VentaTicketDetalleDataGridView.DataSource;
            }

            Repositorio<Ticket> repositorio = new Repositorio<Ticket>(new Contexto());

            Ticket ticket = (Ticket)TicketComboBox.SelectedItem;

            int CantidadCotizada = 0;
            foreach (var item in detalle)
            {
                CantidadCotizada += item.Cantidad;
            }

            int CantidadTickets = ticket.Cantidad;

            bool paso = false;

            if (Convert.ToInt32(CantidadTextBox.Text) > ticket.Cantidad)
            {
                MyErrorProvider.SetError(CantidadTextBox, "Error");
                MessageBox.Show("Cantidad mayor a la existente en inventario!!", "Falló!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                paso = true;
            }

            CantidadTickets -= CantidadCotizada;

            if (CantidadTickets < CantidadCotizada)
            {
                MessageBox.Show($"Solo quedan {CantidadTickets} del articulo deseado!!", "Articulo Agotado!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                paso = true;
            }

            return paso;
        }



        private bool HayErrores()
        {
            bool HayErrores = false;

            if (VentaTicketDetalleDataGridView.RowCount == 0)
            {
                MyErrorProvider.SetError(VentaTicketDetalleDataGridView,
                    "Debe Agregar los Artículos ");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(CantidadTextBox.Text))
            {
                MyErrorProvider.SetError(CantidadTextBox,
                    "Debe Agregar los Artículos ");
                HayErrores = true;
            }

            return HayErrores;
        }

        private void AgregarButtton_Click(object sender, EventArgs e)
        {
            List<VentaTicketDetalle> detalle = new List<VentaTicketDetalle>();

            if (VentaTicketDetalleDataGridView.DataSource != null)
            {
                detalle = (List<VentaTicketDetalle>)VentaTicketDetalleDataGridView.DataSource;
            }
            if (ContarCantidadInventario())
            {
                MessageBox.Show("Cantidad mayor a la existente!!", "Falló!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(CantidadTextBox.Text))
            {
                MessageBox.Show("Cantidad no puede estar vacia!!", "Falló!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                detalle.Add(
               new VentaTicketDetalle(
                   id: 0,
                   ventaTicketId: (int)VentaTicketIdNumericUpDown.Value,
                   clienteId: (int)ClienteComboBox.SelectedValue,
                   ticketId: (int)TicketComboBox.SelectedValue,
                   cantidad: (int)Convert.ToInt32(CantidadTextBox.Text),
                   precio: (int)Convert.ToInt32(PrecioTextBox.Text),
                   importe: (int)Convert.ToInt32(ImporteTextBox.Text)
               ));

                VentaTicketDetalleDataGridView.DataSource = null;
                VentaTicketDetalleDataGridView.DataSource = detalle;

                LlenarValores();
            }
        }

        private void VentaTicketForm_Load(object sender, EventArgs e)
        {

        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (VentaTicketDetalleDataGridView.Rows.Count > 0 && VentaTicketDetalleDataGridView.CurrentRow != null)
            {
                List<VentaTicketDetalle> detalle = (List<VentaTicketDetalle>)VentaTicketDetalleDataGridView.DataSource;

                detalle.RemoveAt(VentaTicketDetalleDataGridView.CurrentRow.Index);

                VentaTicketDetalleDataGridView.DataSource = null;
                VentaTicketDetalleDataGridView.DataSource = detalle;

                RebajarValores();
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(VentaTicketIdNumericUpDown.Value);
            VentaTicket ventaTicket = VentaTicketBLL.Buscar(id);

            if (ventaTicket != null)
            {
                LlenarCampos(ventaTicket);
            }
            else
                MessageBox.Show("No se encontró!!!", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            ClienteComboBox.Text = ("");
            TicketComboBox.Text = ("");
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            VentaTicket ventaTicket;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos!!", "Validación!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ventaTicket = LlenaClase();

            if (VentaTicketIdNumericUpDown.Value == 0)
            {
                Paso = VentaTicketBLL.Guardar(ventaTicket);
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(VentaTicketIdNumericUpDown.Value);
                VentaTicket venta = VentaTicketBLL.Buscar(id);

                if (venta != null)
                {
                    Paso = VentaTicketBLL.Modificar(ventaTicket);
                    MessageBox.Show("Modificado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Id no existe", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Paso)
            {
                NuevoButton.PerformClick();
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(VentaTicketIdNumericUpDown.Value);

            VentaTicket ventaTicket = VentaTicketBLL.Buscar(id);

            if (ventaTicket != null)
            {
                if (VentaTicketBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CantidadTextBox_TextChanged(object sender, EventArgs e)
        {
            LlenarPrecio();
            LlenarImporte();
        }

        private void FormatoMoneda(object sender, ConvertEventArgs e)
        {
            int valor = 0;
            int.TryParse(e.Value.ToString(), out valor);
            //e.Value = valor.ToString("#,##.00;(#,##.00);0.00");
        }

        private void CambiarPrecio()
        {
            PrecioTextBox.DataBindings.Clear();
            Binding doBinding = new Binding("Text", TicketComboBox.DataSource, "Precio");
            doBinding.Format += new ConvertEventHandler(FormatoMoneda);
            PrecioTextBox.DataBindings.Add(doBinding);
        }
        private void TicketComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarPrecio();
            if (CantidadTextBox.Text != null)
            {
                LlenarImporte();
            }
            CambiarPrecio();
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);

            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}
