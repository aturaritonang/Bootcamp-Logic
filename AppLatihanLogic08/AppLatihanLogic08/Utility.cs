using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic08
{
    public class Utility
    {
        public Utility()
        {

        }

        public static void cetakArray(string[,] array)
        {
            for (int I = 0; I < array.GetLongLength(0); I++)
            {
                for (int J = 0; J < array.GetLongLength(1); J++)
                {
                    Console.Write(array[I, J] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();
        }
    }
}
