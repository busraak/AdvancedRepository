using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.ViewModels
{
    public class ProductsModel
    {
        public ProductsModel()
        {
            Products = new Products();
        }
        public Products Products { get; set; }
        public string BtnClass { get; set; }
        public string BtnVal { get; set; }
        public string BtnHead { get; set; }
        public IQueryable<CategoriesList> CategoriesList { get; set; }
        public IQueryable<SuppliersList> SuppliersList { get; set; }
        public IQueryable<UnitList> UnitList { get; set; }



    }
}
