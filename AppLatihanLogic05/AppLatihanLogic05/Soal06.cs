using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic05
{
    public class Soal06 : BaseLogic
    {
        public Soal06(int n)
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
                //cari posisi untuk cetak
                int posV = Utility.FaktorialSegiEmpat(bangun);
                int posH = Utility.FaktorialSegiEmpat(bangun);

                //cari ruang untuk cetak
                int nT = Utility.FaktorialSegiEmpat(bangun + 1);
                int nL = Utility.FaktorialSegiEmpat(bangun + 1);

                //nilai angka urut
                int iUrut = 0;

                for (int I = 0; I < array2D.GetLength(0); I++)
                {
                    for (int J = 0; J < array2D.GetLength(1); J++)
                    {
                        if (I >= posV && I < nT && J >= posH && J < nL) {
                            iUrut++;
                            array2D[I, J] = iUrut.ToString();
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
                    Console.Write(array2D[I, J] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.Write("Press any key to continue!");
            Console.ReadLine();
        }
    }
}
