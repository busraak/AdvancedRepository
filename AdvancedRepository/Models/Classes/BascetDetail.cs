using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedRepository.Models.Classes
{
    public class BascetDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
 
        [ForeignKey("ProductId")]
        public Products Products { get; set; }
    }
}
