using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DapperNorthwindProject.DTOs.ProductRepositories
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int CategoryId { get; set; }
    }
}
