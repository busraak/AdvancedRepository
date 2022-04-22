using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.ViewModels
{
    public class UnitsModel
    {
        public UnitsModel()
        {
            Units = new Units();
        }
        public Units Units { get; set; }
        public string BtnHead { get; set; }
        public string BtnVal { get; set; }
        public string BtnClass { get; set; }
    }
}
