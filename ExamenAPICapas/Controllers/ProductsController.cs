using Domain;
using ExamenAPICapas.Request;
using ExamenAPICapas.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ExamenAPICapas.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        public void Insert(ProductRequestInsert request) 
        { 
            ProductService service = new ProductService();

            Producto domain = new Producto
            {
                Nombre = request.Nombre,
                Precio = request.Precio,
                CategoriaID = request.CategoriaID,
            };

            service.Insertar(domain);
        }

        [HttpGet]
        public List<ProductResponseGet> Get()
        {
            ProductService service = new ProductService();

            service.Get();

            var products = service.Get();

            var response = products.Select(p => new ProductResponseGet 
            { 
                Nombre= p.Nombre,
                Precio= p.Precio,  
            }).ToList();

            return response;
        }
    }
}
