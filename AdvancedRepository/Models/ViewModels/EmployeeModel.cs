using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.ViewModels
{
    public class EmployeeModel
    {
        public EmployeeModel()
        {
            Employees = new Employees();
        }
        public Employees Employees { get; set; }
        public string BtnHead { get; set; }
        public string BtnVal { get; set; }
        public string BtnClass { get; set; }
        public IQueryable<ManagersList> ManagerList { get; set; }
        public IQueryable<Counties> CountriesList { get; set; }

    }
}
