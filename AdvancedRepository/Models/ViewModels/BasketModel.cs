using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRepository.Models.ViewModels
{
    public class BasketModel
    {
        public IQueryable<ProductSelect> ProductSelect { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }

        public int Id { get; set; }

    }
}
