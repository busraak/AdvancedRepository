using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface IProductRepos:IBaseRepository<Products>
    {
        IQueryable<ProductList> GetProductList();
        IQueryable<ProductSelect> GetProductSelects();    

    }
}
