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

        public static int progPlus(int n, int plus) {
            int result = 0;
            for (int I = 1; I <= n; I++)
            {
                result += I + plus;
            }
            return result;
        }

        public static void CetakArray(string[,] array) 
        {
            CetakArray(array, true);
        }

        public static void CetakArray(string[,] array, bool bTab) {
            for (int I = 0; I < array.GetLongLength(0); I++)
            {
                for (int J = 0; J < array.GetLongLength(1); J++)
                {
                    if (bTab)
                    {
                        Console.Write(array[I, J] + "\t");
                    }
                    else 
                    {
                        if (array[I, J] != null)
                        {
                            Console.Write(array[I, J]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        
                    }
                    
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Press anykey to continue!");
            Console.ReadKey();
        }
    }
}
