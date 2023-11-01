using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnd5eCharacterList.Tools
{
    internal class RngProvider
    {
        public static Random Random { get; }

        static RngProvider()
        {
            Random = new Random();
        }
    }
}
