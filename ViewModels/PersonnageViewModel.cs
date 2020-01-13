using System.Collections.Generic;
using Squidofus.Models;
using System.Linq;

namespace Squidofus.ViewModels
{
    public class PersonnageViewModel
    {
        public Class Class { get; set; }
        public IEnumerable<ClassDetail> ClassDetail { get; set; }
        
        public IEnumerable<Spell> Spells { get; set; }

        // Spells columns management
        private int _mid
        {
            get 
            { 
                if (Spells.Count() % 2 == 1)
                {
                    return (Spells.Count() / 2) + 1;
                }
                return Spells.Count() / 2; 
            }
        }

        public IEnumerable<Spell> SpellsFirstHalf
        {
            get { return Spells.OrderBy(x => x.Order).Take(_mid); }
        }

        public IEnumerable<Spell> SpellsSecondHalf
        {
            get { return Spells.OrderBy(x => x.Order).Skip(_mid); }
        }
        // END OF : Spells columns management
    }
}