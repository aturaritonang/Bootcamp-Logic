using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic07
{
    public class Soal05 : BasicLogic
    {
        public Soal05(int n)
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
                        if (I == 0 || J == 0 || J == areaLebar - 1)
                        {
                            //tentukan posisi cetak
                            int posV = ((n - bangun) * 2) + I;
                            int posH = ((n - bangun) * 2) + J;

                            //tentukan value isi
                            int value = 0;

                            if (J == 0 || J == areaLebar - 1)
                            { 
                                value = areaTinggi - I; 
                            }
                            else
                            {
                                if (J > areaLebar / 2)
                                {
                                    value = areaLebar - 1 - J;
                                }
                                else 
                                {
                                    value = J;
                                }
                            }
                            array2D[posV, posH] = value.ToString();
                        }
                    }
                }
            }
        }
    }
}
