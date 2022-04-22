using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRepository.Models.ViewModels
{
    public class FatDetailModel
    {
       
        public IQueryable<ProductSelect> ProductSelects { get; set; }
        public FatMaster FatMaster { get; set; }
        public FatDetail FatDetail { get; set; }
        public IQueryable<FatDetailList> FatDetailList { get; set; }
        public IQueryable<CustomerSelect> CustomerSelect { get; set; }

        public string Total { get; set; }

    }
}
