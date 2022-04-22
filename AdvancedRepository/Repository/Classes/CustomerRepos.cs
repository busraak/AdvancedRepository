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
    public class CustomerRepos:BaseRepository<Customers>,ICustomerRepos
    {
        public CustomerRepos(SirketContext db):base(db)
        {

        }

        public IQueryable<CustomerSelect> GetCustomerSelects()
        {
            return Set().Select(x=>new CustomerSelect
            {
                Id = x.Id,
                CompanyName = x.CompanyName,
            });
        }

        public IQueryable<CustomersList> GetCustomersList()
        {
            return Set().Select(x => new CustomersList
            {
                CustomerId = x.Id,
                Rating = x.Rating,
                Street = x.Street,
                CountryName = x.Counties.CountryName,
                CompanyName = x.CompanyName
            });
        }

    
    }
}
