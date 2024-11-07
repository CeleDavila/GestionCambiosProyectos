﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLimpia.Dominio.Entidades
{
    public class Rol
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}