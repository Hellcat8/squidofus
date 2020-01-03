using System;
using System.Collections.Generic;

namespace Squidofus.Models
{
    public partial class Class
    {
        public Class()
        {
            ClassDetail = new HashSet<ClassDetail>();
            Spell = new HashSet<Spell>();
        }

        public int IdClass { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ClassDetail> ClassDetail { get; set; }
        public virtual ICollection<Spell> Spell { get; set; }
    }
}
