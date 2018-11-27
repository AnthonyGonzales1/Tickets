using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Tickets.Entidades
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string TipoTicket { get; set; }
        public string NombreEvento { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public Ticket()
        {
            TicketId = 0;
            TipoTicket = string.Empty;
            NombreEvento = string.Empty;
            Cantidad = 0;
            Precio = 0;
        }
    }
}
