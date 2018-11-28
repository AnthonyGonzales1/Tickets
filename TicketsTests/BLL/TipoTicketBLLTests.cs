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
    public class TipoTicketBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            TipoTicket tipoTicket = new TipoTicket();
            tipoTicket.TipoTicketId = 03;
            tipoTicket.Descripcion = "Concierto Anthony Santos";
            tipoTicket.Lugar = "Pimentel";

            paso = TipoTicketBLL.Guardar(tipoTicket);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            TipoTicket tipoTicket = new TipoTicket();
            tipoTicket.TipoTicketId = 03;
            tipoTicket.Descripcion = "Conciertos Romeo Santos";
            tipoTicket.Lugar = "Cotui";
            
            paso = TipoTicketBLL.Modificar(tipoTicket);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 03;
            bool paso;

            paso = TipoTicketBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 02;
            TipoTicket tipoTicket = new TipoTicket();

            tipoTicket = TipoTicketBLL.Buscar(id);
            Assert.IsNotNull(tipoTicket);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<TipoTicket, bool>> expression)
        {
            Contexto contexto = new Contexto();

            List<TipoTicket> ListTipoTicket = new List<TipoTicket>();
            ListTipoTicket = contexto.TipoTicket.Where(expression).ToList();
            Assert.IsNotNull(ListTipoTicket);
        }
    }
}