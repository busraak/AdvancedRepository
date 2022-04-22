using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface IFatDetailRepos:IBaseRepository<FatDetail>
    {
        IQueryable<FatDetailList> GetFatDetailLists(int id);
        string FatTotal(IQueryable<FatDetailList> fd);
    }
}
