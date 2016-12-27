using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic08
{
    public class Soal07: BasicLogic
    {
        public Soal07(int n1, int n2)
        {
            nilaiPanjang = n1 + n2 - 1;
            nilaiLebar = (n2 * 2) - 1;

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n1, n2);
            Utility.cetakArray(array2D);
        }

        public void IsiArray(int n1, int n2)
        {
            //mempermudah posisi balik atau pantul
            int peekPos = 0;

            //deret angka genap
            int nilaiGenap = 0;

            for (int bangun = 0; bangun < nilaiLebar; bangun++)
            {
                for (int J = 0; J < n1; J++)
                {
                    array2D[bangun, nilaiPanjang - 1 - peekPos - J] = nilaiGenap.ToString();
                    nilaiGenap += 2;
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
