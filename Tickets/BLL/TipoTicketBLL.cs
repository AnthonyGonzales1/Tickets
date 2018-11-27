using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Linq.Expressions;
using Tickets.DAL;
using Tickets.Entidades;

namespace Tickets.BLL
{
    public class TipoTicketBLL
    {
        public static bool Guardar(TipoTicket tipoTicket)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.TipoTicket.Add(tipoTicket) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Modificar(TipoTicket tipoTicket)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(tipoTicket).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                TipoTicket tipoTicket = contexto.TipoTicket.Find(id);

                contexto.TipoTicket.Remove(tipoTicket);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();//Siempre hay que cerrar la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static TipoTicket Buscar(int id)
        {
            Contexto contexto = new Contexto();
            TipoTicket tipoTicket = new TipoTicket();
            try
            {
                tipoTicket = contexto.TipoTicket.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return tipoTicket;
        }


        public static List<TipoTicket> GetList(Expression<Func<TipoTicket, bool>> expression)
        {
            List<TipoTicket> tipoTicket = new List<TipoTicket>();
            Contexto contexto = new Contexto();

            try
            {
                tipoTicket = contexto.TipoTicket.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return tipoTicket;
        }
    }
}
