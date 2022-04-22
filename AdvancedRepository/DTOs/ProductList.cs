using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.DTOs
{
    public class ProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
        public string UnitName { get; set; }
        public int CategoryId { get; set; }


    }
}
