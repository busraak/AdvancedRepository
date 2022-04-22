using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedRepository.Models.Classes
{
    public class BascetMaster:Base
    {
        public DateTime Date { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public Users Users { get; set; }

    }
}
