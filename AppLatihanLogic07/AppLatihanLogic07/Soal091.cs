using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic07
{
    public class Soal091: BasicLogic
    {
        public Soal091(int n)
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
                    //tentukan koordinat
                    int posV = bangun1 * n;
                    int posH = bangun2 * n;

                    //tentukan ruang cetak
                    int lLb = (bangun1 + 1) * n;
                    int lPj = (bangun2 + 1) * n;

                    for (int I = posV; I < lLb; I++)
                    {
                        for (int J = posH; J < lPj; J++)
                        {
                            if ((I == lLb - 1 || J == lPj - 1 || I == lPj - J - 1 + (bangun1 * n)) && (bangun1 == 0 || bangun2 == 0 || bangun1 == n - 1 || bangun2 == n - 1))
                            {
                                array2D[I, J] = angkaUrut.ToString();
                            }
                        }
                    }
                    if (bangun1 == 0 || bangun2 == 0 || bangun1 == n - 1 || bangun2 == n - 1)
                        angkaUrut++;
                }
            }
        }
    }
}
