using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnd5eCharacterList.Classes
{
    internal abstract class CharacterClass
    {
        public string? ClassName {get; set;}
        public string? SubClass { get; set;}
        public int ClassLevel { get; set;}
        
        public virtual void LevelUp()
        {
            throw new NotImplementedException();
        }
    }
}
