using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.Classes
{
    public class Products:Base
    {
     

        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitId { get; set; }
        public int Stock { get; set; } 
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ProductionDate { get; set; }

        [ForeignKey("CategoryId")]
        public Categories Categories { get; set; }

        [ForeignKey("SupplierId")]
        public Suppliers Suppliers { get; set; }

        [ForeignKey("UnitId")]
        public Units Unit { get; set; }
        [ForeignKey("EmployeeId")]
        public Employees Employees { get; set; }


        //public ICollection<FatDetail> FatDetail { get; set; }
        //public List<FatDetail> FatDetails { get; set; }


    }
}
