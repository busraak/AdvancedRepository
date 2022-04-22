using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface IFatMasterRepos:IBaseRepository<FatMaster>
    {
        IQueryable<FatMasterList> GetFatMasterList();
        

    }

}
