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
    public class CountryRepos : BaseRepository<Counties>, ICountryRepos
    {
        public CountryRepos(SirketContext db) : base(db)
        {

        }

        public IQueryable<CountryList> GetCountryList()
        {
            return Set().Select(x => new CountryList
            {
                CountryId = x.Id,
                CountyName = x.CountryName,
                CityName=x.Cities.CityName
            });
        }
    }
}
