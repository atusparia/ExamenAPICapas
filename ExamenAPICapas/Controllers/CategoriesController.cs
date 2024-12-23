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
    public class CategoriesController : ControllerBase
    {
        [HttpPost]
        public void Insert(CategoryRequestInsert request)
        {
            CategoryService service = new CategoryService();

            Categoria domain = new Categoria
            {
                Nombre = request.Nombre,
                Descripcion = request.Descripcion,
            };

            service.Insertar(domain);
        }


        [HttpGet]
        public List<CategoryResponseGet> Get()
        {
            CategoryService service = new CategoryService();

            service.Get();

            var categories = service.Get();

            var response = categories.Select(x => new CategoryResponseGet 
            { 
                CategoriaID = x.CategoriaID,
                Nombre = x.Nombre,
                Descripcion= x.Descripcion, 
            }).ToList();

            return response;
        }

    }
}
