using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic07
{
    public class Soal10 : BasicLogic
    {
        public Soal10(int n)
        {
            nilaiLebar = n * n;
            nilaiPanjang = n * n;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            //tentukan urutan setiap bangun
            int angkaUrut = 1;
            for (int bangun1 = 0; bangun1 < n; bangun1++)
            {
                for (int bangun2 = 0; bangun2 < n; bangun2++)
                {
                    //pakai atau tidak
                    bool bPakai = false;
                    for (int I = 0; I < n; I++)
                    {
                        for (int J = 0; J < n; J++)
                        {
                            //cari posisi untuk cetak
                            int posVer = bangun1 * n + I;
                            int posHor = bangun2 * n + J;
                            if (bangun1 == 0 || bangun2 == 0 || bangun1 == n - 1 || bangun2 == n - 1)
                            {
                                //if (I >= n - 1 - J )
                                if (I == n - 1 || J == 0 || I == J)
                                {
                                    bPakai = true;
                                    array2D[posVer, posHor] = angkaUrut.ToString();
                                }
                            }
                        }
                    }
                    if (bPakai)
                        angkaUrut++;
                }
            }
        }
    }
}
