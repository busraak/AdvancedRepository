using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.ViewModels
{
    public class CountriesModel
    {
        public CountriesModel()
        {
            Counties = new Counties();
        }
        public Counties Counties { get; set; }
        public string BtnHead { get; set; }
        public string BtnVal { get; set; }
        public string BtnClass { get; set; }
        public IQueryable<Cities> CitiesList { get; set; }
    }
}
