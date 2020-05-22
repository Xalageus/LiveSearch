using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSearch
{
    class Strings
    {
        public string CONTAINS_DESCRIPTION = "Searches using the C# built-in .contains (or .IndexOf when doing case insensitive searching) on the list";
        public string MANUAL_DESCRIPTION = "Searches through the list checking character by character until the full term was found";
        public string SPREAD_DESCRIPTION = "Same as 'Manual Contains' except a break between characters in the term is allowed";
    }
}
