using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.DTOs
{
    public class EmployeesList
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public int PhoneNumber { get; set; }
    
    }
}
