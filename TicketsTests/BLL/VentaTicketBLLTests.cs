using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tickets.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tickets.Entidades;
using System.Linq.Expressions;
using Tickets.DAL;

namespace Tickets.BLL.Tests
{
    [TestClass()]
    public class VentaTicketBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            VentaTicket ventaTicket = new VentaTicket();
            ventaTicket.VentaTicketId = 01;
            ventaTicket.ClienteId = 01;
            ventaTicket.TicketId = 01;
            ventaTicket.Fecha =DateTime.Now;
            ventaTicket.SubTotal = 100;
            ventaTicket.Itbis = 18;
            ventaTicket.Total = 118;

            ventaTicket.Detalle.Add(new VentaTicketDetalle(0, 1, 1, 2, 5, 10, 50));
            //ventaTicket.Detalle.Add(new VentaTicketDetalle(0, 2, 3, 4, 10, 40, 400));
            
            paso = VentaTicketBLL.Guardar(ventaTicket);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarBienTest()
        {
            int idVentaTicket = VentaTicketBLL.GetList(x => true)[0].VentaTicketId;
            VentaTicket ventaTicket = VentaTicketBLL.Buscar(idVentaTicket);

            ventaTicket.Detalle.Add(new VentaTicketDetalle(0, ventaTicket.VentaTicketId, 2, 4, 2, 100, 200));
            bool paso = VentaTicketBLL.Modificar(ventaTicket);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            int idVentaTicket = VentaTicketBLL.GetList(x => true)[0].VentaTicketId;
            VentaTicket ventaTicket = VentaTicketBLL.Buscar(idVentaTicket);

            ventaTicket.Detalle.Add(new VentaTicketDetalle(0, ventaTicket.VentaTicketId, 2, 4, 2, 100, 200));
            bool paso = VentaTicketBLL.Modificar(ventaTicket);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int idVentaTicket = VentaTicketBLL.GetList(x => true)[0].VentaTicketId;
            bool paso = VentaTicketBLL.Eliminar(idVentaTicket);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]
        public void BuscarTest()
        {
            int idVentaTicket = VentaTicketBLL.GetList(x => true)[0].VentaTicketId;

            VentaTicket ventaTicket = VentaTicketBLL.Buscar(idVentaTicket);
            bool paso = ventaTicket.Detalle.Count > 0;
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<VentaTicket, bool>> expression)
        {
            Contexto contexto = new Contexto();

            List<VentaTicket> ListVentaTicket = new List<VentaTicket>();
            ListVentaTicket = contexto.VentaTicket.Where(expression).ToList();
            Assert.IsNotNull(ListVentaTicket);
        }

        [TestMethod()]
        public void ImporteTest()
        {
            Assert.Fail();
        }
    }
}