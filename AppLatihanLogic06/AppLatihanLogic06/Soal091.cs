using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic06
{
    public class Soal091: BasicLogic
    {
        public Soal091(int n)
        {
            nilaiLebar = n + 2;
            nilaiPanjang = Utility.progPlus(n);

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n)
        {
            for (int bangun = 0; bangun < n; bangun++)
            {
                //tentukan posisi
                int posV = n - (bangun + 1);
                int posH = Utility.progPlus(bangun);

                //tentukan luas bangun
                int lPj = Utility.progPlus(bangun + 1);
                int lLb = nilaiLebar;

                for (int I = posV; I < lLb; I++)
                {
                    for (int J = posH; J < lPj; J++)
                    {
                        if (I + J == lPj + n - (bangun + 2) || I == lLb - 1 || J == lPj - 1)
                        {
                            array2D[I, J] = (J + 1).ToString();
                        }
                    }
                }
            }
        }
    }
}
