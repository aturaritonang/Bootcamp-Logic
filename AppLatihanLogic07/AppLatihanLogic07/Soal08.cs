using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic07
{
    public class Soal08 : BasicLogic
    {
        public Soal08(int n1, int n2, int n3)
        {
            nilaiLebar = n1;
            nilaiPanjang = n2 * n3 + (n3 - 1);

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n1, n2, n3);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n1, int n2, int n3)
        {
            for (int bangun = 0; bangun < n3; bangun++)
            {
                //angka perulangan
                int deretAngka = 1;

                for (int I = 0; I < n2 - 1; I++)
                {
                    //tentukan posisi horizontal
                    int posVer = 0;
                    int posHor = (bangun * n2) + bangun + I;

                    array2D[posVer, posHor] = deretAngka.ToString();
                    deretAngka += 2;
                }

                for (int I = 0; I < n1 - 1; I++)
                {
                    //tentukan posisi horizontal
                    int posVer = I;
                    int posHor = (bangun * n2) + bangun + n2 - 1;

                    array2D[posVer, posHor] = deretAngka.ToString();
                    deretAngka += 2;
                }

                for (int I = 0; I < n2 - 1; I++)
                {
                    //tentukan posisi horizontal
                    int posVer = n1 - 1;
                    int posHor = (bangun * n2) + bangun + n2 - 1 - I;

                    array2D[posVer, posHor] = deretAngka.ToString();
                    deretAngka += 2;
                }

                for (int I = 0; I < n1 - 1; I++)
                {
                    //tentukan posisi horizontal
                    int posVer = n1 - 1 - I;
                    int posHor = (bangun * n2) + bangun;

                    array2D[posVer, posHor] = deretAngka.ToString();
                    deretAngka += 2;
                }

            }
        }
    }
}
