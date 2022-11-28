using APITecsup.Models.Request;
using APITecsup.Models.Response;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace APITecsup.Controllers
{
    public class ProductController : ApiController
    {

        public List<ProductResponse> Get()
        {

            var service = new ProductService();
            var product = service.Get();

            //Convert Domaint to Response
            var response = product.Select(x => new ProductResponse
            {
                Name = x.Name,
                Descripcion = x.Descripcion,
                PrecioVenta = x.PrecioVenta,
                Igv = x.PrecioVenta*0.18,
                CreatedON = x.CreatedON,
                FechaVen = x.FechaVen
            }).ToList();

            return response;
        }
        [HttpPost]
        public bool Insert(ProductRequest request)
        {
            var response = true;
            try
            {
                var service = new ProductService();
                service.Insert(new Domain.Product
                {
                    Name = request.Name,
                    Descripcion = request.Descripcion,
                    PrecioVenta = request.PrecioVenta,
                    FechaVen = request.FechaVen
                });
            }
            catch (Exception)
            {
                //log ex
                response = false;
            }
            return response;
        }
    }

}
