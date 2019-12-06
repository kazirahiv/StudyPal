using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model
{
    public class Payment : BaseEntity
    {
        [Key]
        public int PaymentId { get; set; }
        public Decimal PaymentAmount { get; set; } 
        public Decimal PaidAmount { get; set; } 
        public Decimal Due { get; set; } 
        public Decimal Discount { get; set; } 
        public string Remark { get; set; }
        public DateTime? PaymentDate { get; set; }
        public virtual Student Student { get; set; }

    }
}
