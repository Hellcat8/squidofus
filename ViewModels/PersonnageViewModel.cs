using System.Collections.Generic;
using Squidofus.Models;

namespace Squidofus.ViewModels
{
    public class PersonnageViewModel
    {
        public Class Class { get; set; }
        public IEnumerable<ClassDetail> ClassDetail { get; set; }
    }
}