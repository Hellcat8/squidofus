using System;
using System.Collections.Generic;

namespace Squidofus.Models
{
    public partial class Spell
    {
        public Spell()
        {
            SpellDetail = new HashSet<SpellDetail>();
        }

        public int IdSpell { get; set; }
        public string Label { get; set; }
        public string ImgFilename { get; set; }
        public string Description { get; set; }
        public int IdClass { get; set; }
        public int Order { get; set; }

        public virtual Class IdClassNavigation { get; set; }
        public virtual ICollection<SpellDetail> SpellDetail { get; set; }
    }
}
