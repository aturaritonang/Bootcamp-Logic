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
            nilaiLebar = n * n;
            nilaiPanjang = n * n;
            array2D = new string[nilaiLebar, nilaiPanjang];

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

                //tentukan ruang
                int nLebar = (bangun + 1) * n;
                int nPanjang = (n - bangun) * n;

                //arah cetakan
                bool kiri = true;

                for (int I = posV; I < nLebar; I++)
                {
                    if (kiri)
                    {
                        for (int J = posH; J < nPanjang; J++)
                        {
                            array2D[I, J] = angkaGanjil.ToString();
                            angkaGanjil += 2;
                        }
                        kiri = false;
                    }
                    else
                    {
                        for (int J = nPanjang - 1; J >= posH; J--)
                        {
                            array2D[I, J] = angkaGanjil.ToString();
                            angkaGanjil += 2;
                        }
                        kiri = true;
                    }
                }
            }
        }
    }
}
