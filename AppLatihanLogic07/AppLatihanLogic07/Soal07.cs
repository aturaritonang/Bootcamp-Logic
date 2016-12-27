using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic07
{
    public class Soal07 : BasicLogic
    {
        public Soal07(int n)
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
                //angka perulangan
                int deretAngka = 1;
                
                for (int I = 0; I < n - 1; I++)
                {
                    //tentukan posisi horizontal
                    int posVer = 0;
                    int posHor = (bangun * n) + bangun + I;

                    array2D[posVer, posHor] = deretAngka.ToString();
                    deretAngka++;
                }

                for (int I = 0; I < n - 1; I++)
                {
                    //tentukan posisi horizontal
                    int posVer = I;
                    int posHor = (bangun * n) + bangun + n - 1;

                    array2D[posVer, posHor] = deretAngka.ToString();
                    deretAngka++;
                }

                for (int I = 0; I < n - 1; I++)
                {
                    //tentukan posisi horizontal
                    int posVer = n - 1;
                    int posHor = (bangun * n) + bangun + n - 1 - I;

                    array2D[posVer, posHor] = deretAngka.ToString();
                    deretAngka++;
                }

                for (int I = 0; I < n - 1; I++)
                {
                    //tentukan posisi horizontal
                    int posVer = n - 1 - I;
                    int posHor = (bangun * n) + bangun;

                    array2D[posVer, posHor] = deretAngka.ToString();
                    deretAngka++;
                }

            }
        }
    }
}
