using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.DTOs
{
    public class CustomersList
    {
        public int CustomerId { get; set; }
        public int Rating { get; set; }
        public string Street { get; set; }
        public string CountryName { get; set; }
        public string CompanyName { get; set; }


    }
}
