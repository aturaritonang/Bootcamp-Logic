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
                        case 41:
                            Soal041 soal041 = new Soal041(n);
                            break;
                        case 51:
                            Soal051 soal051 = new Soal051(n);
                            break;
                        case 61:
                            Soal061 soal061 = new Soal061(n);
                            break;
                        case 71:
                            Soal071 soal071 = new Soal071(n);
                            break;
                        case 81:
                            Soal081 soal081 = new Soal081(n);
                            break;
                        case 91:
                            Soal091 soal091 = new Soal091(n);
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
