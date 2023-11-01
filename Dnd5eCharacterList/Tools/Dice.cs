
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Dnd5eCharacterList.Tools
{
    internal static class Dice
    {
        public static int D2(int count)
        {
            return RngProvider.Random.Next(1, 3);
        }

        public static int D4(int count)
        {
            return RngProvider.Random.Next(1, 5);
        }

        public static int D8(int count)
        {
            return RngProvider.Random.Next(1, 9);
        }

        public static int D10(int count)
        {
            return RngProvider.Random.Next(1, 11);
        }

        public static int D12(int count)
        {
            return RngProvider.Random.Next(1, 13);
        }

        public static int D20(int count)
        {
            return RngProvider.Random.Next(1, 21);
        }
    }
}