using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITecsup.Models.Request
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public double PrecioVenta { get; set; }
        public string FechaVen { get; set; }
    }
}