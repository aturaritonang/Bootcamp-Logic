using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic08
{
    public class Soal05 : BasicLogic
    {
        public Soal05(int n1, int n2)
        {
            nilaiLebar = n1 + n2 - 1;
            nilaiPanjang = (n2 * 2) - 1;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n1, n2);
            Utility.cetakArray(array2D);
        }

        public void IsiArray(int n1, int n2) 
        {
            //mempermudah posisi balik atau pantul
            int peekPos = 0;

            for (int bangun = 0; bangun < nilaiPanjang; bangun++)
            {
                for (int I = 0; I < n1; I++)
                {
                    array2D[peekPos + I, bangun] = "*";
                }
                if (bangun < n2 - 1)
                {
                    peekPos++;
                }
                else
                {
                    peekPos--;
                }
            }
        }
    }
}
