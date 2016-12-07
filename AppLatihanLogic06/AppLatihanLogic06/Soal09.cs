using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic06
{
    public class Soal09 : BasicLogic
    {
        public Soal09(int n)
        {
            nilaiTinggi = n + 2;
            nilaiLebar = Utility.progPlus(n, 2);

            array2D = new string[nilaiTinggi, nilaiLebar];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            //for (int I = 0; I < nilaiTinggi; I++)
            //{
            //    for (int J = 0; J < nilaiLebar; J++)
            //    {
            //        array2D[I, J] = J.ToString();
            //    }
            //}

            int batasBawah = nilaiTinggi - 1;

            //menentukan batas-batas
            int marginL = 0;
            int marginR = 0;

            for (int bangun = 1; bangun <= n; bangun++)
            {
                marginR = marginL + bangun + 2;

                int marginV = bangun + 2;

                for (int I = 0; I <= bangun + 1; I++)
                {
                    for (int J = 0; J <= bangun + 1; J++)
                    {
                        int posRow = batasBawah - I;
                        int posCol = marginL + J;
                        if (I == J || I == 0 || J == bangun + 1)
                        {
                            array2D[posRow, posCol] = (posCol + 1).ToString();
                        }
                    }
                }
                marginL = marginR;
            }
        }
    }
}
