using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.ViewModels
{
    public class EmployeeDetail
    {
        public int Id { get; set; }
        public string Head { get; set; }
        public string FullName { get; set; }
        public decimal Salary  { get; set; }
    }
}
