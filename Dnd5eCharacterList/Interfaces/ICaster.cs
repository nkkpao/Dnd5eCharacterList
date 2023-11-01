using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dnd5eCharacterList.Interfaces
{
    internal interface ICaster
    {
        Dictionary<int, string> Spells { get; set; }
        Dictionary<int, int> SpellPoints { get; set;}

        void Cast(){ }
    }
}
