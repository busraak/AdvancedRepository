using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Classes
{
    public class FatMaster:Base
    {
       
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public ICollection<FatDetail> FatDetail { get; set; }
        
        [ForeignKey("CustomerId")]
        public Customers Customers { get; set; }

        //public List<FatDetail> FatDetails { get; set; }


    }
}
