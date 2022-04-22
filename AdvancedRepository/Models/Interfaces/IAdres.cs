using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Interfaces
{
    public interface IAdres
    {
        string Street { get; set; }
        string Avenue { get; set; }
        int CountryId { get; set; }
        int OutDoorNumber { get; set; }
        int PhoneNumber { get; set; }
        
    }
}
