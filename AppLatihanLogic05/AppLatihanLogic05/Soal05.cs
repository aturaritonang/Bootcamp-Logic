using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic05
{
    public class Soal05 : BaseLogic
    {
        public Soal05(int n)
        {
            nilaiLebar = Utility.Faktorial(n);
            nilaiPanjang = Utility.FaktorialSegiTiga(n);

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            CetakArray();
        }

        public void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                //cari posisi untuk cetak
                int posV = Utility.Faktorial(bangun);
                int posH = Utility.FaktorialSegiTiga(bangun);

                //cari besaran cetak
                int nT = Utility.Faktorial(bangun + 1);
                int nL = Utility.FaktorialSegiTiga(bangun + 1);

                //cari nilai tengah
                int limL = posH;
                int limR = nL - 1;

                for (int I = 0; I < nilaiLebar; I++)
                {
                    for (int J = 0; J < nilaiPanjang; J++)
                    {
                        if (I >= posV && I < nT && J >= limL && J <= limR) 
                        {
                            array2D[I, J] = "*";
                        }
                    }
                    if (I >= posV && I < nT) 
                    {
                        limL += 1;
                        limR -= 1;
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
