using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic05
{
    public class Soal10 : BaseLogic
    {
        public Soal10(int n)
        {
            nilaiTinggi = Utility.FaktorialSegiEmpat(n);
            nilaiLebar = (n * 2) - 1;

            array2D = new string[nilaiTinggi, nilaiLebar];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n) 
        {
            //apakah fibonacci?
            bool bFibonacci = false;
            for (int bangun = 1; bangun <= n; bangun++)
            {
                //tentukan nilai fibonacci
                int[] deretAngka = new int[n * n];

                for (int f = 0; f < deretAngka.Length; f++)
                {
                    if (bFibonacci)
                    {
                        if (f <= 1)
                        {
                            deretAngka[f] = 1;
                        }
                        else
                        {
                            deretAngka[f] = deretAngka[f - 2] + deretAngka[f - 1];
                        }
                    }
                    else 
                    {
                        if (f == 0)
                        {
                            deretAngka[f] = 1;
                        }
                        else 
                        {
                            deretAngka[f] = deretAngka[f - 1] + 2;
                        }
                    }  
                }

                //posisi nilai fibonacci
                int posDeret = 0;

                int marginL = ((n * 2) - 1) / 2;
                int marginR = ((n * 2) - 1) / 2;

                //cari posisi untuk cetak
                int posV = Utility.FaktorialSegiEmpat(bangun - 1);

                //cari ruang untuk cetak
                int nT = Utility.FaktorialSegiEmpat(bangun);
                int lebar = (bangun * 2) - 1;

                for (int I = posV; I < nT; I++)
                {
                    for (int J = marginL; J <= marginR; J++)
                    {
                        array2D[I, J] = deretAngka[posDeret].ToString();
                        posDeret++;
                    }
                    marginL -= 1;
                    marginR += 1;
                }

                //Switch Fibonacci true false
                if (bFibonacci)
                { bFibonacci = false; }
                else
                { bFibonacci = true; }
            }
        }
    }
}
