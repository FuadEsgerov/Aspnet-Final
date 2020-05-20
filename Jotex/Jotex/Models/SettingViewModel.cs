using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class SettingViewModel
    {
       
        public string Logo { get; set; }


    
        public string NeedHelpNumber { get; set; }

        public string Address { get; set; }

      
        public string Phone { get; set; }

        
        public string Email { get; set; }
      
        public string WorkTime { get; set; }

        public ICollection<SocialMediaAccount> Accounts { get; set; }
    }
}
