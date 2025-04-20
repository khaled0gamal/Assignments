using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_assignment_1.Models
{
    class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        /// Navigation property
        public List<Product> Products { get; set; }
    }
}
