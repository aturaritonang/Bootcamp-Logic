using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic05
{
    public class Soal02 : BaseLogic
    {
        public Soal02(int n)
        {
            nilaiLebar = Utility.FaktorialSegiEmpat(n);
            nilaiPanjang = Utility.FaktorialSegiEmpat(n);
            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            CetakArray();
        }

        public void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                int iPos = Utility.FaktorialSegiEmpat(bangun);
                for (int I = 0; I < nilaiLebar; I++)
                {
                    for (int J = 0; J < nilaiLebar; J++)
                    {
                        if (I >= iPos && nilaiLebar - 1 - J >= iPos && I <= iPos + bangun && nilaiLebar - 1 - J <= iPos + bangun)
                        {
                            array2D[I, J] = "*";
                        }
                    }
                }
            }
        }

        public void CetakArray()
        {
            for (int I = 0; I < array2D.GetLength(0); I++)
            {
                for (int J = 0; J < array2D.GetLength(1); J++)
                {
                    Console.Write(array2D[I,J] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.Write("Press any key to continue!");
            Console.ReadLine();
        }

    }
}
