using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Pages
{
    public class AgentViewModel
    {
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public int ServiceId { get; set; }


        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string SurName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Job { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
    }
}
