﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Linq.Expressions;
using Tickets.DAL;
using Tickets.Entidades;

namespace Tickets.BLL
{
    public class VentaTicketBLL
    {
        public static bool Guardar(VentaTicket ventaTicket)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.VentaTicket.Add(ventaTicket) != null)
                {
                    foreach (var item in ventaTicket.Detalle)
                    {
                        contexto.Ticket.Find(item.TicketId).Cantidad -= item.Cantidad;
                    }

                    contexto.Cliente.Find(ventaTicket.ClienteId).Deuda += Convert.ToInt32(ventaTicket.Total);
                    
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

        public static void ModificarBien(VentaTicket ventaTicket, VentaTicket ventaTicketAnt)
        {
            Contexto contexto = new Contexto();
            var Cliente = contexto.Cliente.Find(ventaTicket.ClienteId);
            var ClienteAnt = contexto.Cliente.Find(ventaTicketAnt.ClienteId);

            if (ClienteAnt.ClienteId != Cliente.ClienteId)
            {
                Cliente.Deuda += Convert.ToInt32(ventaTicket.Total);
                ClienteAnt.Deuda -= Convert.ToInt32(ventaTicketAnt.Total);
                ClienteBLL.Modificar(Cliente);
                ClienteBLL.Modificar(ClienteAnt);
            }
        }

        public static bool Modificar(VentaTicket ventaTicket)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                var VentAnt = VentaTicketBLL.Buscar(ventaTicket.VentaTicketId);

                ModificarBien(ventaTicket, VentAnt);

                foreach (var item in VentAnt.Detalle)
                {
                    contexto.Ticket.Find(item.TicketId).Cantidad += item.Cantidad;

                    if (!ventaTicket.Detalle.ToList().Exists(v => v.Id == item.Id))
                    {
                        item.Tickets = null;
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach (var item in ventaTicket.Detalle)
                {
                    contexto.Ticket.Find(item.TicketId).Cantidad -= item.Cantidad;
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;
                }

                VentaTicket VentaAnterior = VentaTicketBLL.Buscar(ventaTicket.VentaTicketId);
                double modificado = ventaTicket.Total - VentaAnterior.Total;

                var cliente = contexto.Cliente.Find(ventaTicket.ClienteId);
                cliente.Deuda += Convert.ToInt32(modificado);
                ClienteBLL.Modificar(cliente);

                contexto.Entry(ventaTicket).State = EntityState.Modified;
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
                VentaTicket ventaTicket = contexto.VentaTicket.Find(id);

                foreach (var item in ventaTicket.Detalle)
                {
                    var Elimininar = contexto.Ticket.Find(item.TicketId);
                    Elimininar.Cantidad += item.Cantidad;
                }

                contexto.Cliente.Find(ventaTicket.ClienteId).Deuda -= Convert.ToInt32(ventaTicket.Total);
                
                contexto.VentaTicket.Remove(ventaTicket);

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


        public static VentaTicket Buscar(int id)
        {
            Contexto contexto = new Contexto();
            VentaTicket ventaTicket = new VentaTicket();
            try
            {
                ventaTicket = contexto.VentaTicket.Find(id);

                if (ventaTicket != null)
                {
                    ventaTicket.Detalle.Count();

                    foreach (var item in ventaTicket.Detalle)
                    {
                        string ss = item.Cliente.Nombres;
                        string sss = item.Tickets.NombreEvento;
                    }
                }

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return ventaTicket;
        }


        public static List<VentaTicket> GetList(Expression<Func<VentaTicket, bool>> expression)
        {
            List<VentaTicket> ventaTickets = new List<VentaTicket>();
            Contexto contexto = new Contexto();

            try
            {
                ventaTickets = contexto.VentaTicket.Where(expression).ToList();
                //contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return ventaTickets;
        }

        public static int Importe(int cantidad, int precio)
        {
            return cantidad * precio;
        }
    }
}
