using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic07
{
    public class Soal04 : BasicLogic
    {
        public Soal04(int n)
        {
            nilaiLebar = (n * 2) + 1;
            nilaiPanjang = (n * 4) - 1;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            //cari posisi tengah area
            int mid = ((n * 4) - 1) / 2;
            for (int bangun = 1; bangun <= n; bangun++)
            {
                //cari area untuk bangun
                int areaTinggi = (bangun * 2) + 1;
                int areaLebar = (bangun * 4) - 1;

                for (int I = 0; I < areaTinggi; I++)
                {
                    for (int J = 0; J < areaLebar; J++)
                    {
                        if (J == 0 || I == areaTinggi - 1 || J == areaLebar - 1)
                        {
                            //tentukan posisi cetak
                            int posV = I;
                            int posH = ((n - bangun) * 2) + J;
                            array2D[posV, posH] = "*";
                        }
                    }
                }
            }
        }
    }
}
