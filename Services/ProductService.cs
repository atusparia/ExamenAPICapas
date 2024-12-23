using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService
    {
        public void Insertar(Producto producto) 
        {
            using (var context = new AppDbContext()) 
            { 
                context.Productos.Add(producto);
                context.SaveChanges();
            }
        }

        public List<Producto> Get() 
        {
            using (var context = new AppDbContext()) 
            { 
                var products = context.Productos.ToList();
                return products;
            }
        }
    }
}
