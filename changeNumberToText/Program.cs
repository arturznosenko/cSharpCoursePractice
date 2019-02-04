using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -999999; //rezis1
            int b = 999999; //rezis2
            int c = 0; //as skaicius
            string zodziai = "";
            bool wordisnumber = false;
            bool ifnumber;
            int skaicius2int = 0;
            string ArReziuoseMain;
            bool ArminusinisYesNo = false;


            Console.WriteLine($"Iveskite skaiciu tarp {a} ir {b}");
            string skaicius2 = Console.ReadLine();

            string zodis = skaicius2;

            for (int i = 0; i < zodis.Length; i++)
            {
                char simbolis = zodis[i];

                ifnumber = ArSkaicius((Convert.ToString(simbolis)), i);
                if (ifnumber == false)
                { c = c + 1; }
                if (i == 0)
                { ArminusinisYesNo = Arminusinis((Convert.ToString(simbolis)), i); }
            }

            //Console.WriteLine("Ilgis" + ilgis + "Ar minusinis " + ArminusinisYesNo + zodziai);

            // ar skaicius?
            if (c > 0)
            {
                Console.WriteLine("Ar ivesta reiksme yra skaicius: NE");
                wordisnumber = false;
            }
            else
            {
                Console.WriteLine("Ar ivesta reiksme yra skaicius: TAIP");
                wordisnumber = true;
            }

            // konvertuojame i int ir tikrina ar reziuose
            //ar reziuose? jeigu taip tai grazinit zodziais su metodu GrazinaZodius 

            if (wordisnumber == true)
            {
                skaicius2int = konversija(skaicius2);
                ArReziuoseMain = ArReziuose(skaicius2int, a, b);
                Console.WriteLine("Ar skaicius yra reziuose: " + ArReziuoseMain);


                //ArReziuoseMain = ArReziuose(skaicius2int, a, b);  //kode sito nepaima is virsaus

                if (ArReziuoseMain == "Skaicius reziuose" && ArminusinisYesNo == true)
                {
                    zodziai = GrazinaZodius(Math.Abs(skaicius2int));
                    Console.WriteLine("Minus " + zodziai);
                }
                else if (ArReziuoseMain == "Skaicius reziuose" && ArminusinisYesNo == false)
                {
                    zodziai = GrazinaZodius(Math.Abs(skaicius2int));
                    Console.WriteLine(zodziai);
                }
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();
        }


        static bool Arminusinis(string Arminusinis, int i)
        {
            if (i == 0 && Arminusinis == "-")
            {
                bool ArminusinisYesNo = true;
                return ArminusinisYesNo;
            }
            else
            {
                bool ArminusinisYesNo = false;
                return ArminusinisYesNo;
            }
        }

        static bool ArSkaicius(string ArSkaicius, int i)
        {
            if (i == 0 && ArSkaicius == "-")
            { return true; }
            if (ArSkaicius == "1")
            { return true; }
            else if (ArSkaicius == "2")
            { return true; }
            else if (ArSkaicius == "3")
            { return true; }
            else if (ArSkaicius == "4")
            { return true; }
            else if (ArSkaicius == "5")
            { return true; }
            else if (ArSkaicius == "6")
            { return true; }
            else if (ArSkaicius == "7")
            { return true; }
            else if (ArSkaicius == "8")
            { return true; }
            else if (ArSkaicius == "9")
            { return true; }
            else if (ArSkaicius == "0")
            { return true; }
            else
            { return false; }

        }

        static int konversija(string info2)
        {
            int a = Convert.ToInt32(info2);
            return a;
        }

        static string ArReziuose(int skaicius, int a, int b)
        {
            string ArReziuose;

            if ((skaicius > a) && (skaicius > b))
            {
                ArReziuose = ("Skaicius nereziuose");
                return ArReziuose;
            }
            else if ((skaicius < a) && (skaicius < b))
            {
                ArReziuose = "Skaicius nereziuose";
                return ArReziuose;
            }
            else
            {
                ArReziuose = "Skaicius reziuose";
                return ArReziuose;
            }
        }

        static string GrazinaZodius(int a)
        {
            string text;
            if (a < 20)
            {
                if (a == 0)
                {
                    text = "Nulis";
                    return text;
                }
                if (a == 1)
                {
                    text = "Vienas";
                    return text;
                }
                else if (a == 2)
                {
                    text = "Du";
                    return text;
                }
                else if (a == 3)
                {
                    text = "Tris";
                    return text;
                }
                else if (a == 4)
                {
                    text = "Keturi";
                    return text;
                }
                else if (a == 5)
                {
                    text = "Penki";
                    return text;
                }
                else if (a == 6)
                {
                    text = "Sesi";
                    return text;
                }
                else if (a == 7)
                {
                    text = "Septyni";
                    return text;
                }
                else if (a == 8)
                {
                    text = "Astuoni";
                    return text;
                }
                else if (a == 9)
                {
                    text = "Devyni";
                    return text;
                }
                else if (a == 10)
                {
                    text = "Desimt";
                    return text;
                }
                else if (a == 11)
                {
                    text = "Vienuolika";
                    return text;
                }
                else if (a == 12)
                {
                    text = "Dvylika";
                    return text;
                }
                else if (a == 13)
                {
                    text = "Trylika";
                    return text;
                }
                else if (a > 13)
                {
                    text = GrazinaZodius(a - 10) + "olika";
                    return text;
                }

                else
                {
                    text = "Error";
                    return text;
                }

            }
            /*    else if (a >= 200000)
                {
                    {
                        int d = Convert.ToInt32(a.ToString().Substring(0, 3));
                        text = GrazinaZodius(d) + " Tukstantciai " + ((a - d * 1000 == 0) ? "" : GrazinaZodius(a - d * 1000));
                        return text;
                    }
                }*/

            else if (a >= 100000)   /// cia su tukstantis, tukstanciu ir tukstancii neveikia gerai
            {
                {
                    int d = Convert.ToInt32(a.ToString().Substring(0, 3));
                    int e = Convert.ToInt32(a.ToString().Substring(2, 1));
                    text = GrazinaZodius(d) + ((e == 1) ? " Tukstantis " : " Tukstanciai") + ((a - d * 1000 == 0) ? "" : GrazinaZodius(a - d * 1000));
                    return text;
                }
            }
            else if (a >= 20000)
            {
                {
                    int d = Convert.ToInt32(a.ToString().Substring(0, 2));
                    text = GrazinaZodius(d) + " Tukstantciai " + ((a - d * 1000 == 0) ? "" : GrazinaZodius(a - d * 1000));
                    return text;
                }
            }

            else if (a >= 10000)
            {
                {
                    int d = Convert.ToInt32(a.ToString().Substring(0, 2));
                    text = GrazinaZodius(d) + " Tukstantciu " + ((a - d * 1000 == 0) ? "" : GrazinaZodius(a - d * 1000));
                    return text;
                }
            }
            else if (a >= 2000)
            {
                {
                    int d = Convert.ToInt32(a.ToString().Substring(0, 1));
                    text = GrazinaZodius(d) + " Tukstantciai " + ((a - d * 1000 == 0) ? "" : GrazinaZodius(a - d * 1000));
                    return text;
                }
            }

            else if (a >= 1000)
            {
                {
                    int d = Convert.ToInt32(a.ToString().Substring(0, 1));
                    text = GrazinaZodius(d) + " Tukstantis " + ((a - d * 1000 == 0) ? "" : GrazinaZodius(a - d * 1000));
                    return text;
                }
            }

            else if (a >= 200)
            {
                {
                    int d = Convert.ToInt32(a.ToString().Substring(0, 1));
                    text = GrazinaZodius(d) + " Simtai " + ((a - d * 100 == 0) ? "" : GrazinaZodius(a - d * 100));
                    return text;
                }
            }

            else if (a >= 100)
            {
                {
                    text = "Simtas " + ((a - 100 == 0) ? "" : GrazinaZodius(a - 100));
                    return text;
                }
            }

            else if (a >= 90)
            {
                text = "Devyniasdesimt " + ((a - 90 == 0) ? "" : GrazinaZodius(a - 90));
                return text;
            }

            else if (a >= 80)
            {
                text = "Astuoniasdesimt " + ((a - 80 == 0) ? "" : GrazinaZodius(a - 80));
                return text;
            }

            else if (a >= 70)
            {
                text = "Septniasdesimt " + ((a - 70 == 0) ? "" : GrazinaZodius(a - 70));
                return text;
            }

            else if (a >= 60)
            {
                text = "Sesiasdesimt " + ((a - 60 == 0) ? "" : GrazinaZodius(a - 60));
                return text;
            }

            else if (a >= 50)
            {
                text = "Penkiasdesimt " + ((a - 50 == 0) ? "" : GrazinaZodius(a - 50));
                return text;
            }


            else if (a >= 40)
            {
                text = "Keturiasdesimt " + ((a - 40 == 0) ? "" : GrazinaZodius(a - 40));
                return text;
            }

            else if (a >= 30)
            {
                text = "Trisdesimt " + ((a - 30 == 0) ? "" : GrazinaZodius(a - 30));
                return text;
            }

            else if (a >= 20)
            {
                text = "Dvidesimt " + ((a - 20 == 0) ? "" : GrazinaZodius(a - 20));
                return text;
            }

            else
            {
                text = "Error";
                return text;
            }

        }

    }
}

