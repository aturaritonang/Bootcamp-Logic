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
            nilaiLebar = n + 2;
            nilaiPanjang = Utility.progPlus(n, 2);

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            int batasBawah = nilaiLebar - 1;

            //menentukan batas-batas
            int marginL = 0;
            int marginR = 0;

            for (int bangun = 1; bangun <= n; bangun++)
            {
                //tentukan margin
                marginR = marginL + bangun + 2;

                for (int I = 0; I <= bangun + 1; I++)
                {
                    for (int J = 0; J <= bangun + 1; J++)
                    {
                        //tentukan posisi koordinat
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
