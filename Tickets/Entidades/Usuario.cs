﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Tickets.Entidades
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }

        public Usuario()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            Email = string.Empty;
            Clave = string.Empty;
        }

        public override string ToString()
        {
            return Nombres;
        }
    }
}
