using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Classes
{
    public class CategoryRepos: BaseRepository<Categories>, ICategoryRepos
    {
        public CategoryRepos(SirketContext db) : base(db)
        {

        }

        public IQueryable<CategoriesList> GetCategoryList()
        {
            return Set().Select(x => new CategoriesList
            {
                CategoryId = x.Id,
                CategoryName = x.CategoryName
                
            });
        }
    }
}
