using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic07
{
    public class Soal06 : BasicLogic
    {
        public Soal06(int n)
        {
            nilaiLebar = n;
            nilaiPanjang = n * n + (n - 1);

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                for (int I = 0; I < n; I++)
                {
                    for (int J = 0; J < n; J++)
                    {
                        //cari posisi untuk masukkan angka
                        int posVer = I ;
                        int posHor = (bangun * n) + bangun + J;
                        if(I == 0 || J == 0 || I == n - 1 || J == n - 1)
                        array2D[posVer, posHor] = "*";
                    }
                }
            }
        }
    }
}
