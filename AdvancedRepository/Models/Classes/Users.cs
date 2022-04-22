using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdvancedRepository.Models.Classes
{
    public class Users
    {
        public Users()
        {
            BascetMaster=new HashSet<BascetMaster>();
        }
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public ICollection<BascetMaster> BascetMaster { get; set; }
    }
}
