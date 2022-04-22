using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Interfaces
{
    public interface ITable
    {
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime LastUpdated { get; set; }
        string WhoUpdated { get; set; }

    }
}
