using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tickets.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tickets.Entidades;
using Tickets.DAL;
using System.Linq.Expressions;

namespace Tickets.BLL.Tests
{
    [TestClass()]
    public class TicketBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Ticket ticket = new Ticket();
            ticket.TicketId = 03;
            ticket.NombreEvento = "Anthony Santos";
            ticket.Cantidad = 30;
            ticket.TipoTicket = "Concert";
            ticket.Precio = 100;

            paso = TicketBLL.Guardar(ticket);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Ticket ticket = new Ticket();
            ticket.TicketId = 03;
            ticket.NombreEvento = "Anthony Santos";
            ticket.Cantidad = 33;
            ticket.TipoTicket = "Concerts";
            ticket.Precio = 130;

            paso = TicketBLL.Modificar(ticket);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 03;
            bool paso;

            paso = TicketBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 02;
            Ticket ticket = new Ticket();

            ticket = TicketBLL.Buscar(id);
            Assert.IsNotNull(ticket);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<Ticket, bool>> expression)
        {
            Contexto contexto = new Contexto();

            List<Ticket> ListTicket = new List<Ticket>();
            ListTicket = contexto.Ticket.Where(expression).ToList();
            Assert.IsNotNull(ListTicket);
        }
    }
}