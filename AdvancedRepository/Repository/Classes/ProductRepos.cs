using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Classes
{
    public class ProductRepos : BaseRepository<Products>, IProductRepos
    {
       

        public ProductRepos(SirketContext db): base(db)
        {
            
        }
        public IQueryable<ProductList> GetProductList()
        {
            return Set().Select(x => new ProductList
            {
                ProductId = x.Id,
                ProductName = x.ProductName,
                CompanyName = x.Suppliers.CompanyName,
                CategoryName=x.Categories.CategoryName,
                UnitName=x.Unit.UnitName

            });
            

        }

        public IQueryable<ProductSelect> GetProductSelects()
        {
            return Set().Select(x => new ProductSelect
            {
                ProductId = x.Id,
                ProductName = x.ProductName
            });
        }
    }
}
