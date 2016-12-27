using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic08
{
    public class Soal01 : BasicLogic
    {
        public Soal01(int n)
        {
            nilaiLebar = n * 2;
            nilaiPanjang = (n * 2 - 1) * n;
            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.cetakArray(array2D);
        }

        public void IsiArray(int n) 
        {
            //cari posisi tengah keseluruhan
            int mid = (((n * 2) - 1) / 2)  + 1;

            //cari luas bangun
            int sizeHeight = n;
            int sizeWidth = ((n * 2) - 1);

            //tentukan margin
            int marLeft = 0;
            int marRight = 0;

            for (int bangun = 0; bangun < n; bangun++)
            {
                //tentukan ruang setiap bangun
                int posVer = 0;
                int posHor = ((n * 2) - 1) * bangun;

                if (bangun % 2 == 0)
                {
                    marLeft = posHor + mid - 1;
                    marRight = posHor + mid - 1;
                }
                else
                {
                    posVer = n; 
                    marLeft = posHor;
                    marRight = posHor + sizeWidth - 1;
                }

                for (int I = 0; I < sizeHeight; I++)
                {
                    for (int J = 0; J < sizeWidth; J++)
                    {
                        if (posHor + J >= marLeft && posHor + J <= marRight)
                        array2D[posVer + I, posHor + J] = "*";
                    }

                    if (bangun % 2 == 0) 
                    {
                        marLeft -= 1;
                        marRight += 1;
                    }
                    else
                    {
                        marLeft += 1;
                        marRight -= 1;
                    }
                }

            }
        }
    }
}
