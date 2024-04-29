﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Application.Handlers.Queries.BookController.FindAll
{
    public class BokkFindResponse
    {
        public int Book_id { get; set; }
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Portada { get; set; }

        public string Idioma { get; set; }
        public string Descripcion { get; set; }

        public DateTime Fecha_ini { get; set; }
        public string Estado { get; set; }
    }
}