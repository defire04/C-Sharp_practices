using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9.util
{
    class Randomize
    {
        private static List<ConsoleColor> colors = ConsoleColor.GetValues(typeof(ConsoleColor)).OfType<ConsoleColor>().ToList().FindAll(color => color != ConsoleColor.Black).ToList();
        private static Random random = new Random();


        public static ConsoleColor Color()
        {
            return colors[random.Next(colors.Count)];
        }

        public static int Size()
        {
            return random.Next(4, 8);
        }

    }
}
