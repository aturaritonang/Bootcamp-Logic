using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic08
{
    public class Soal02 : BasicLogic
    {
        public Soal02(int n)
        {
            nilaiLebar = (n * 2) - 1;
            nilaiPanjang = nilaiLebar * n;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.cetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            //tentukan ruang untuk setiap bangunan (n * 2) - 1
            int sizeHeight = (n * 2) - 1;
            int sizeWidth = (n * 2) - 1;

            //tentukan nilai tengahnya
            int mid = sizeWidth / 2;

            for (int bangun = 0; bangun < n; bangun++)
            {
                //tentukan posisi bangun untuk cetak
                int posHor = sizeWidth * bangun;

                //tentukan area bangun
                int luasHor = sizeWidth * (bangun + 1); 

                //tentujan margin
                int marLeft = luasHor - mid - 1;
                int marRight = luasHor - mid - 1;

                for (int I = 0; I < sizeHeight; I++)
                {
                    for (int J = posHor; J < luasHor; J++)
                    {
                        if (J >= marLeft && J <= marRight)
                        {
                            array2D[I, J] = "*";
                        }
                    }

                    if (I < mid)
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
