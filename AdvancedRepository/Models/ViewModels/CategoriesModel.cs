using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.ViewModels
{
    public class CategoriesModel
    {
            public CategoriesModel()
            {
                Categories = new Categories();
            }
            public Categories Categories { get; set; }
            public string BtnClass { get; set; }
            public string BtnVal { get; set; }
            public string BtnHead { get; set; }
           
    }
}
