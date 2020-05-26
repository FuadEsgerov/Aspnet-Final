using Repository.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class ContactUsViewModel
    {
        
        public string Name { get; set; }
        
        public string Email { get; set; }
      
        public string Phone { get; set; }
     

        public string Description { get; set; }
        
        public ContactSubject Subject { get; set; }
      
        public string EndPoint { get; set; }
    }
}
