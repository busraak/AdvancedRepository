using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRepository.Repository.Classes
{
    public class FatMasterRepos:BaseRepository<FatMaster>, IFatMasterRepos
    {
        public FatMasterRepos(SirketContext db):base(db)
        {

        }

     
        public IQueryable<FatMasterList> GetFatMasterList()
        {
            return Set().Select(x => new FatMasterList
            {
                FatMasterId=x.Id,
                Date=x.Date,
                CompanyName=x.Customers.CompanyName
            });
        }
    }
}
