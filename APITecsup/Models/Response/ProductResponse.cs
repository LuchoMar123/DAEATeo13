using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITecsup.Models.Response
{
    public class ProductResponse
    {
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public double PrecioVenta { get; set; }
        public double Igv { get; set; }
        public DateTime CreatedON { get; set; }
        public string FechaVen { get; set; }

    }

}