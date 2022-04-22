using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.DTOs
{
    public class ManagersList
    {
        public int ManagerId { get; set; }
        public string FullName { get; set; }
        public bool IsManager { get; set; }
    }
}
