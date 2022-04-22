using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRepository.Models.ViewModels
{
    public class FatMasterModel
    {
        public FatMasterModel()
        {
            FatMaster=new FatMaster();
        }
        public FatMaster FatMaster { get; set; }
        public string BtnHead { get; set; }
        public string BtnVal { get; set; }
        public string BtnClass { get; set; }
        public IQueryable<CustomerSelect> Customers { get; set; }
        
    }
}
