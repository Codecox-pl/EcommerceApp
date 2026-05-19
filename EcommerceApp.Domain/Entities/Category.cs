using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //Relacion jerarquica (subcategorias)
        public int? ParentCategoryId { get; set; }
        public Category? ParentCategory { get; set; }
        public ICollection<Category> SubCategories { get; set; }


        //Relacion con Productos
        public ICollection<Product> Products { get; set; }

        //Constructor para inicializar las colecciones
        public Category()
        {
            SubCategories = new List<Category>();
            Products = new List<Product>();
        }
    }
}
