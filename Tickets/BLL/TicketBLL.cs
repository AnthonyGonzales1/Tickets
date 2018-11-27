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
    public class TicketBLL
    {
        public static bool Guardar(Ticket ticket)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Ticket.Add(ticket) != null)
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


        public static bool Modificar(Ticket ticket)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(ticket).State = EntityState.Modified;
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
                Ticket ticket = contexto.Ticket.Find(id);

                contexto.Ticket.Remove(ticket);

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


        public static Ticket Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ticket ticket = new Ticket();
            try
            {
                ticket = contexto.Ticket.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return ticket;
        }


        public static List<Ticket> GetList(Expression<Func<Ticket, bool>> expression)
        {
            List<Ticket> tickets = new List<Ticket>();
            Contexto contexto = new Contexto();

            try
            {
                tickets = contexto.Ticket.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return tickets;
        }
    }
}
