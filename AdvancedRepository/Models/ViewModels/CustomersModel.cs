using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.ViewModels
{
    public class CustomersModel
    {
        public CustomersModel()
        {
            Customers = new Customers();
        }
        public Customers Customers { get; set; }
        public string BtnHead { get; set; }
        public string BtnVal { get; set; }
        public string BtnClass { get; set; }
        public IQueryable<CountryList> CountriesList { get; set; }

    }
}