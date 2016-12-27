using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLatihanLogic08
{
    public class Program
    {
        static void Main(string[] args)
        {
                        int n = 0;
            string sLoop = "Y";
            while (sLoop == "Y")
            {
                try
                {
                    Console.Write("Masukkan Nomor Soal 08 : ");
                    int ns = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Nilai : ");
                    n = int.Parse(Console.ReadLine());
                    int n2, n3 = 0;
                    switch (ns)
                    {
                        case 1:
                            Soal01 soal01 = new Soal01(n);
                            break;
                        case 2:
                            Soal02 soal02 = new Soal02(n);
                            break;
                        case 3:
                            Console.Write("Masukkan Nilai 2 : ");
                            n2 = int.Parse(Console.ReadLine());
                            Soal03 soal03 = new Soal03(n, n2);
                            break;
                        case 4:
                            Console.Write("Masukkan Nilai 2 : ");
                            n2 = int.Parse(Console.ReadLine());
                            Soal04 soal04 = new Soal04(n, n2);
                            break;
                        case 5:
                            Console.Write("Masukkan Nilai 2 : ");
                            n2 = int.Parse(Console.ReadLine());
                            Soal05 soal05 = new Soal05(n, n2);
                            break;
                        case 6:
                            Console.Write("Masukkan Nilai 2 : ");
                            n2 = int.Parse(Console.ReadLine());
                            Soal06 soal06 = new Soal06(n, n2);
                            break;
                        case 7:
                            Console.Write("Masukkan Nilai 2 : ");
                            n2 = int.Parse(Console.ReadLine());
                            Soal07 soal07 = new Soal07(n, n2);
                            break;
                        case 8:
                            Console.Write("Masukkan Nilai 2 : ");
                            n2 = int.Parse(Console.ReadLine());
                            Soal08 soal08 = new Soal08(n, n2);
                            break;
                        case 9:
                            Console.Write("Masukkan Nilai 2 : ");
                            n2 = int.Parse(Console.ReadLine());
                            Console.Write("Masukkan Nilai 3 : ");
                            n2 = int.Parse(Console.ReadLine());
                            Soal09 soal09 = new Soal09(n, n2, n3);
                            break;

                        //case 10:
                        //    Soal10 soal10 = new Soal10(n);
                        //    break;
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
