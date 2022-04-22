using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Interfaces
{
    public interface IEnterPrize
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        public string ContactName { get; set; }
    }
}
