using System;
using System.Collections.Generic;

namespace Squidofus.Models
{
    public partial class Class
    {
        public Class()
        {
            ClassDetail = new HashSet<ClassDetail>();
        }

        public int IdClass { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ClassDetail> ClassDetail { get; set; }
    }
}
