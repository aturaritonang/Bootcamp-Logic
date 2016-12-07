using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 0;
            string sLoop = "Y";
            while (sLoop == "Y")
            {
                try
                {
                    Console.Write("Masukkan Nomor Soal 06 : ");
                    int ns = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Nilai : ");
                    n = int.Parse(Console.ReadLine());
                    switch (ns)
                    {
                        case 1:
                            Soal01 soal01 = new Soal01(n);
                            break;
                        case 2:
                            Soal02 soal02 = new Soal02(n);
                            break;
                        case 3:
                            Soal03 soal03 = new Soal03(n);
                            break;
                        case 4:
                            Soal04 soal04 = new Soal04(n);
                            break;
                        case 5:
                            Soal05 soal05 = new Soal05(n);
                            break;
                        case 6:
                            Soal06 soal06 = new Soal06(n);
                            break;
                        case 7:
                            Soal07 soal07 = new Soal07(n);
                            break;
                        case 8:
                            Soal08 soal08 = new Soal08(n);
                            break;
                        case 9:
                            Soal09 soal09 = new Soal09(n);
                            break;
                        case 10:
                            Soal10 soal10 = new Soal10(n);
                            break;
                        default:
                            break;
                    }
                    //Soal01 soal01 = new Soal01(n);
                    Console.Write("Apakah akan diulang? [Y/y] untuk ya, tombol apapun untuk tidak : ");
                    sLoop = (Console.ReadLine()).ToUpper();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
