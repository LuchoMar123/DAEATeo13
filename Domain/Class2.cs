using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public double PrecioVenta { get; set; }
        public DateTime CreatedON { get; set; }
        public bool IsEnable { get; set; }
        public string FechaVen { get; set; }
        public double Igv { get; set; }

    }

}
