using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCRM.BLL
{
    [Table("Profiles")]
    public class Profiles
    {
        [Key]
        [Required]
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public int CreatedUserId { get; set; }
        [Required]
        public string CreatedUserName { get; set; }
        [Required]
        public DateTime CreatedRegdate { get; set; }
        
        public int UpdatedUserId { get; set; }
        
        public String UpdatedUserName { get; set; }
        
        public DateTime UpdatedRegDate { get; set; }


    }
}
