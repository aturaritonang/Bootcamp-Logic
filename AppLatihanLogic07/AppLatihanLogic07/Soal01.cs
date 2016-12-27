using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic07
{
    public class Soal01 : BasicLogic
    {
        public Soal01(int n)
        {
            nilaiLebar = ((n * 2) - 1) + (n * 2);
            nilaiPanjang = ((n * 2) - 1) + (n * 2);

            array2D = new string[nilaiLebar, nilaiPanjang];
            IsiArray(n);
            Utility.CetakArray(array2D);
        }

        public void IsiArray(int n) 
        {
            //tentukan tengah vertical & horizontal
            //Karena nilai tinggi dan lebar adalah sama, maka ambil dari nilai tinggi saja.
            int mid = nilaiLebar / 2;

            for (int bangun = 0; bangun < 4; bangun++)
            {
                //tentukan area untuk bangun, tinggi dan lebarnya
                int areaTinggi = 0;
                int areaLebar = 0;

                if (bangun % 2 == 0)
                {
                    areaTinggi = n;
                    areaLebar = (n * 2) - 1;
                }
                else 
                {
                    areaTinggi = (n * 2) - 1;
                    areaLebar = n;
                }

                //tentukan nilai margin
                int margin1 = 0;
                int margin2 = 0;

                if (bangun == 0)
                {
                    margin1 = mid;
                    margin2 = mid;
                }
                else if (bangun == 1)
                {
                    margin1 = nilaiPanjang - n;
                    margin2 = nilaiPanjang - n;
                }
                else if (bangun == 2)
                {
                    margin1 = n;
                    margin2 = n + (n * 2) - 2;
                }
                else
                {
                    margin1 = n - 1;
                    margin2 = n - 1;
                }

                //tentukan posisi cetak
                int posV = 0;
                int posH = 0;

                for (int I = 0; I < areaTinggi; I++)
                {
                    for (int J = 0; J < areaLebar; J++)
                    {
                        //untuk menentukan perputaran bangun, boleh atas bawah dulu baru kiri kanan atau kebalikan arah jarum jam.
                        //contoh dibuat seperti cetak dengan arah jarum jam.
                        //bangun = 0 atas, bangun = 1 kanan, bangun = 2 bawah, bangun = 3 kiri

                        if (bangun == 0) {
                            posV = I;
                            posH = n + J;
                        }
                        else if (bangun == 1)
                        {
                            posV = n + I;
                            posH = nilaiPanjang - n + J;
                        }
                        else if (bangun == 2)
                        {
                            posV = nilaiLebar - n + I;
                            posH = n + J;
                        }
                        else 
                        {
                            posV = n + I;
                            posH = J;
                        }

                        if (posH >= margin1 && posH <= margin2)
                        {
                            array2D[posV, posH] = "*";
                        }
                    }

                    if (bangun == 0)
                    {
                        margin1 -= 1;
                        margin2 += 1;
                    }
                    else if (bangun == 1)
                    {
                        if (I < areaTinggi / 2)
                            margin2 += 1;
                        else
                            margin2 -= 1;
                    }
                    else if (bangun == 2)
                    {
                        margin1 += 1;
                        margin2 -= 1;
                    }
                    else 
                    {
                        if (I < areaTinggi / 2)
                            margin1 -= 1;
                        else
                            margin1 += 1;
                    }
                }
            }
        }
    }
}
