using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTO_s.Category
{
    public class UpdateCategory
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public int? ParentCategoryId { get; set; }
    }
}
