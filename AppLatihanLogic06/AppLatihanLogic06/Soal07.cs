using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic06
{
    public class Soal07 : BasicLogic
    {
        public Soal07(int n)
        {
            nilaiLebar = n * n;
            nilaiPanjang = n * n;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n) 
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                //cari posisi tengah
                int midVer = (n - 1) / 2;
                int midHor = (n - 1) / 2;

                //cari margin Left dan margin Right
                int marL = midHor;
                int marR = midHor;

                for (int I = 0; I < n; I++)
                {
                    for (int J = 0; J < n; J++)
                    {
                        //cari posisi kolom dan baris
                        int posRow = I + ((n - 1 - bangun) * n);
                        int posCol = J + (bangun * n);

                        if (J >= marL && J <= marR)
                        {
                            array2D[posRow, posCol] = "*";
                        }
                    }
                    if (I < midVer)
                    {
                        marL -= 1;
                        marR += 1;
                    }
                    else
                    {
                        marL += 1;
                        marR -= 1;
                    }
                }
            }
        }
    }
}
