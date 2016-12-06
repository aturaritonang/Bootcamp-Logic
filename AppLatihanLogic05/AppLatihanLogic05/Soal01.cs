using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic05
{
    public class Soal01 : BaseLogic
    {
        public Soal01(int n)
        {
            nilaiTinggi = Utility.FaktorialSegiEmpat(n);
            nilaiLebar = Utility.FaktorialSegiEmpat(n);

            array2D = new string[nilaiTinggi, nilaiLebar];
            IsiArray(n);
            CetakArray();
        }

        public void BuatSatu(int n) {
            array2D = new string[n, n];
            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < n; J++)
                {
                    array2D[I, J] = "*";
                }
            }
        }

        public void IsiArray(int n) 
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                int iPos = Utility.FaktorialSegiEmpat(bangun);
                for (int I = 0; I < nilaiTinggi; I++)
                {
                    for (int J = 0; J < nilaiTinggi; J++)
                    {
                        if (I >= iPos && J >= iPos && I <= iPos + bangun && J <= iPos + bangun)
                        {
                            array2D[I, J] = "*";
                        }
                    }
                }
            }
        }

        //public void IsiArray(int n)
        //{
        //    int iPos = 0;
        //    for (int bangun = 0; bangun < n; bangun++)
        //    {
        //        iPos = Utility.FaktorialSegiEmpat(bangun);
        //        for (int I = iPos; I <= iPos + bangun; I++)
        //        {
        //            for (int J = iPos; J <= iPos + bangun; J++)
        //            {
        //                array2D[I, J] = "*";
        //            }
        //        }
        //    }
        //}

        public void CetakArray() {
            for (int I = 0; I < array2D.GetLength(0); I++)
            {
                for (int J = 0; J < array2D.GetLength(1); J++)
                {
                    Console.Write(array2D[I, J] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.Write("Press any key to continue!");
            Console.ReadLine();
        }
    }
}
