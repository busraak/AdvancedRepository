using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Classes
{
    public class Suppliers:EnterPrize
    {
        public Suppliers()
        {
            Products = new HashSet<Products>();

        }

        public bool Procuder { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
