using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Classes
{
    public class Customers:EnterPrize
    {
        public int Rating { get; set; }

        [ForeignKey("CountryId")]
        public Counties Counties { get; set; }
        public ICollection<FatMaster> FatMaster { get; set; }
    }
}
