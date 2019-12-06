using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPal.Model
{
    public class BaseEntity
    {
        public int? CreatedBy { get; set; }
        public virtual DateTime? CreationDate { get; set; }
        public int? LastUpdateBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
    }
}
