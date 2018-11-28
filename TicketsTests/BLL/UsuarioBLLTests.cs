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
    public class UsuarioBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Usuario usuario = new Usuario();
            usuario.UsuarioId = 03;
            usuario.Nombres = "Anthony Junior";

            paso = UsuarioBLL.Guardar(usuario);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Usuario usuario = new Usuario();
            usuario.UsuarioId = 03;
            usuario.Nombres = "Antonio Junior";

            paso = UsuarioBLL.Modificar(usuario);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 03;
            bool paso;

            paso = UsuarioBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 02;
            Usuario usuario = new Usuario();

            usuario = UsuarioBLL.Buscar(id);
            Assert.IsNotNull(usuario);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<Usuario, bool>> expression)
        {
            Contexto contexto = new Contexto();

            List<Usuario> ListUsuario = new List<Usuario>();
            ListUsuario = contexto.Usuario.Where(expression).ToList();
            Assert.IsNotNull(ListUsuario);
        }
    }
}