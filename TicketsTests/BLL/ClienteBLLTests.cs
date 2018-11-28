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
    public class ClienteBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Cliente cliente = new Cliente();
            cliente.ClienteId = 03;
            cliente.Nombres = "Anthony";
            cliente.Telefono = "8091444420";
            cliente.Deuda = 100;
            
            paso = ClienteBLL.Guardar(cliente);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Cliente cliente = new Cliente();
            cliente.ClienteId = 03;
            cliente.Nombres = "Anthonys";
            cliente.Telefono = "8091433420";
            cliente.Deuda = 140;

            paso = ClienteBLL.Modificar(cliente);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 03;
            bool paso;

            paso = ClienteBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 02;
            Cliente cliente = new Cliente();

            cliente = ClienteBLL.Buscar(id);
            Assert.IsNotNull(cliente);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<Cliente, bool>> expression)
        {
            Contexto contexto = new Contexto();

            List<Cliente> ListCliente = new List<Cliente>();
            ListCliente = contexto.Cliente.Where(expression).ToList();
            Assert.IsNotNull(ListCliente);
        }
    }
}