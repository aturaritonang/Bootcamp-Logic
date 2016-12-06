using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic05
{
    public class Utility
    {
        public Utility()
        {

        }

        public static int Faktorial(int n)
        {
            int result = 0;
            for (int I = 1; I <= n; I++) {
                result += I;
            }
            return result;
        }

        public static int FaktorialSegiEmpat(int n) {
            int result = 0;
            for (int I = 1; I <= n; I++)
            {
                result += I;
            }
            return result;
        }

        public static int FaktorialSegiTiga(int n)
        {
            int result = 0;
            for (int I = 1; I <= n; I++) {
                result += (((I - 1)) * 2) + 1;
            }
            return result;
        }

        public static void CetakArray(string[,] array) 
        {
            for (int I = 0; I < array.GetLength(0); I++)
            {
                for (int J = 0; J < array.GetLength(1); J++)
                {
                    Console.Write(array[I, J] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.Write("Press any key to continue!");
            Console.ReadLine();

        }
    }
}
