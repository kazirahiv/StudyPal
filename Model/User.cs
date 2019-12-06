using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model
{
    public class User : BaseEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool UserEnabled { get; set; }
        public string UserAvatar { get; set; } 
        public String PhoneNumber { get; set; }
        public String Address { get; set; }
    }
}
