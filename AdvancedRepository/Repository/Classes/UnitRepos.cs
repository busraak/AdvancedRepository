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
    public class UnitRepos : BaseRepository<Units>, IUnitRepos
    {
        public UnitRepos(SirketContext db) : base(db)
        {

        }

        public IQueryable<UnitList> GetUnitList()
        {
            return Set().Select(x => new UnitList
            {
                UnitId=x.Id,
                UnitName=x.UnitName
            });
        }
    }
}
