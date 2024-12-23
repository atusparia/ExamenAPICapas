using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService
    {
        public void Insertar(Categoria categoria)
        {
            using (var context = new AppDbContext())
            {
                context.Categorias.Add(categoria);
                context.SaveChanges();
            }
        }

        public List<Categoria> Get() 
        {
            using (var context = new AppDbContext())
            {
                var categories = context.Categorias.ToList();
                return categories;
            }
        }

    }
}
