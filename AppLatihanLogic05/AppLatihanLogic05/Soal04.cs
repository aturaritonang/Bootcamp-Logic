using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic05
{
    public class Soal04 : BaseLogic
    {
        public Soal04(int n)
        {
            nilaiTinggi = Utility.Faktorial(n);
            nilaiLebar = Utility.FaktorialSegiTiga(n);
            array2D = new string[nilaiTinggi, nilaiLebar];
            IsiArray(n);
            CetakArray();
        }

        public void IsiArray(int n) 
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                //Cari dulu posisi untuk cetak
                int posV = Utility.Faktorial(bangun);
                int posH = Utility.FaktorialSegiTiga(bangun);

                //Cari luas untuk pencetakan
                int nT = Utility.Faktorial(bangun + 1);
                int nL = Utility.FaktorialSegiTiga(bangun + 1);

                //Cari middlenya
                int limL = nL - (bangun + 1);
                int limR = nL - (bangun + 1);

                for (int I = 0; I < nilaiTinggi; I++)
                {
                    for (int J = 0; J < nilaiLebar; J++)
                    {
                        if (I >= posV && I < nT && nilaiLebar - 1 - J >= limL && nilaiLebar - 1 - J <= limR)
                        {
                            array2D[I, J] = "*";
                        }
                    }
                    if (I >= posV && I < nT)
                    {
                        limL -= 1;
                        limR += 1;
                    }
                }
            }
        }

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
