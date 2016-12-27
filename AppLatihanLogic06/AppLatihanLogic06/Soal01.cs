using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic06
{
    public class Soal01 : BasicLogic
    {
        public Soal01(int n)
        {
            nilaiLebar = Utility.multipleSegitiga(n);
            nilaiPanjang = Utility.faktorSegitiga(n) * 2;

            array2D = new string[nilaiLebar, nilaiPanjang];

            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n) 
        {
            //posisi kiri atau kanan, 0 kiri, 1 kanan
            int kiri = 0;

            for (int bangun = 0; bangun < n; bangun++)
            {
                //cari posisi untuk cetak
                int posV = bangun * n;
                int posH = Utility.faktorSegitiga(n * kiri);

                //cari ruang untuk cetak
                int nLebar = (bangun + 1) * n;
                int nPanjang = (kiri + 1) * ((n * 2) - 1);

                //cari nilai tengah
                int midL = nPanjang - n;
                int midR = nPanjang - n;

                for (int I = posV; I < nLebar; I++)
                {
                    for (int J = posH; J < nPanjang; J++)
                    {
                        if (J >= midL && J <= midR) {
                            array2D[I, J] = "*";
                        }
                    }
                    midL -= 1;
                    midR += 1;
                }
                //kiri = kiri == 0 ? 1 : 0;
                if (kiri == 0)
                    kiri = 1;
                else
                    kiri = 0;
                
            }
        }
    }
}
