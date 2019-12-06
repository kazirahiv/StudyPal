using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model
{
    public class Teacher
    {
        public Teacher()
        {
            Payments = new List<Payment>();
            Skills = new List<Skill>();
            TuitionRequests = new List<TuitionRequest>();
        }
           
        [Key]
        public int TeacherId { get; set; }
        public int? UserId { get; set; }
        public int PhoneNumber { get; set; }
        public Decimal ChargeAmount { get; set; }
        public string ChargeType { get; set; }
        public bool AvailableToHire { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<TuitionRequest> TuitionRequests { get; set; }

    }
}
