using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic06
{
    public class Utility
    {
        public Utility()
        {
        }

        //faktor segitiga untuk 2 bersap
        public static int faktorSegitiga(int n)
        {
            int result = 0;
            if (n > 0)
                result = (n * 2) - 1;
            return result;
        }

        //faktor kelipatan
        public static int multipleSegitiga(int n) 
        {
            int result = 0;
            result = n * n;
            return result;
        }

        public static void CetakArray(string[,] array) 
        {
            for (int I = 0; I < array.GetLongLength(0); I++)
            {
                for (int J = 0; J < array.GetLongLength(1); J++)
                {
                    Console.Write(array[I, J] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Press anykey to continue!");
            Console.ReadKey();
        }
    }
}
