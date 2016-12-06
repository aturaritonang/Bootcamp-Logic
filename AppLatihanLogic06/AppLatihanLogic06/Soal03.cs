using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic06
{
    public class Soal03 : BasicLogic
    {
        public Soal03(int n)
        {
            nilaiTinggi = Utility.multipleSegitiga(n);
            nilaiLebar = Utility.faktorSegitiga(n) * 2;

            array2D = new string[nilaiTinggi, nilaiLebar];

            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            //posisi kiri atau kanan, 0 kiri, 1 kanan
            int leftRight = 0;

            int[] deretAngka = new int[n * n];


            for (int bangun = 0; bangun < n; bangun++)
            {
                //Tentukan isi deret angka sesuai posisi
                if (leftRight == 0)
                {
                    for (int f = 0; f < deretAngka.Length; f++)
                    {
                        if (f <= 1)
                        {
                            deretAngka[f] = 1;
                        }
                        else
                        {
                            deretAngka[f] = deretAngka[f - 2] + deretAngka[f - 1];
                        }
                    }
                }
                else
                {
                    for (int f = 0; f < deretAngka.Length; f++)
                    {
                        if (f == 0)
                        {
                            deretAngka[f] = 1;
                        }
                        else
                        {
                            deretAngka[f] = deretAngka[f - 1] + 2;
                        }
                    }
                }

                //cari posisi untuk cetak
                int posV = bangun * n;
                int posH = Utility.faktorSegitiga(n * leftRight);

                //cari ruang untuk cetak
                int nT = (bangun + 1) * n;
                int nL = (leftRight + 1) * ((n * 2) - 1);

                //cari nilai tengah
                int midL = nL - n;
                int midR = nL - n;

                //posisi deret angka
                int posDeret = 0;

                for (int I = posV; I < nT; I++)
                {
                    for (int J = posH; J < nL; J++)
                    {
                        if (J >= midL && J <= midR)
                        {
                            array2D[I, J] = deretAngka[posDeret].ToString();
                            posDeret++;
                        }
                    }
                    midL -= 1;
                    midR += 1;
                }
                leftRight = leftRight == 0 ? 1 : 0;
            }
        }

    }
}
