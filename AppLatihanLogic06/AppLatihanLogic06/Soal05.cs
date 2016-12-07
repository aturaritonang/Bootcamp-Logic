using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic06
{
    public class Soal05 : BasicLogic
    {
        public Soal05(int n)
        {
            nilaiTinggi = n * n;
            nilaiLebar = n * n;
            array2D = new string[nilaiTinggi, nilaiLebar];

            IsiArray(n);

            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n) 
        {
            //tentukan deret angka
            int angkaGanjil = 1;

            for (int bangun = 0; bangun < n; bangun++)
            {
                //tentukan posisi
                int posV = bangun * n;
                int posH = (n - 1 - bangun) * n;

                for (int I = 0; I < n; I++)
                {
                    for (int J = 0; J < n; J++)
                    {
                        int posRow = I + posV;
                        int posCol = J;

                        if (I % 2 == 0)
                        {
                            posCol = J + posH;
                        }
                        else
                        {
                            posCol = n - J - 1 + posH;
                        }

                        array2D[posRow, posCol] = angkaGanjil.ToString();
                        angkaGanjil += 2;
                    }
                }
            }
        }
    }
}
