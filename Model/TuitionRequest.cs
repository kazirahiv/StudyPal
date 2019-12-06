using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model
{
    public class TuitionRequest : BaseEntity
    {
        [Key]
        public int TRequestId { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public bool Delivered { get; set; }
        public string Note { get; set; }
        public bool PaymentCleared { get; set; }
    }
}
