using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnd5eCharacterList.Spells
{
    internal abstract class BasicSpell
    {
        public int SpellLevel { get; set; }
        bool Verbal { get; set; }
        bool Somatic { get; set; }
        bool Material { get; set; }
        string? MaterialDescription { get; set; }
        string? Description { get; set; }
        string? AtHighterLevels { get; set; }

        public virtual void Cast() { }
    }
}
