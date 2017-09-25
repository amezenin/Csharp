using System;

namespace kodutoo1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Valige tegevust?");
            
            Console.WriteLine("1 - Celsiusist Feringeitiks ");
            Console.WriteLine("2 - Sonade arv");
            Console.WriteLine("3 - Kas taisskasvanud?");
            Console.WriteLine("4 - Kolmnurk");
            Console.WriteLine("5 - Laus tagurpidi");
            Console.WriteLine("6 - Kuupaev");
            int valik = kusiArv("Valige tegevus, sisestage number");


            object day = null;
            object nowDay = null;
            switch (valik)
            {
                case 1:
                    double tempC = kusiArv("Sisesta temperatuur celsiusis");
                    double tempFar = celToFar(tempC);
                    Console.WriteLine("Temperatuur fahringeitides on: " + tempFar);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Kirjutage laus, et lugeda sonade arvu");
                    string lause = Console.ReadLine();
                    Console.WriteLine("Sonade arv sisestatud lauses on: " + sonadeArv(lause));
                    Console.ReadLine();
                    break;
                case 3:
                    double age = kusiArv("Sisesta vanus");
                    if (age >= 18)
                    {
                        Console.WriteLine("Taisealine");
                        Console.ReadLine();
                    } else
                    {
                        Console.WriteLine("Allaealine");
                    }
                    break;
                case 4:
                    int a = kusiArv("Sisesta esimese kulje pikkus");
                    int b = kusiArv("Sisesta teise kulje pikkus");
                    int c = kusiArv("Sisesta kolmanda kulje pikkus");
                    int perimetr = a + b + c;
                    Console.WriteLine(kolmnurk(a, b, c) ? "Kolmnurk" : "Ei ole kolmnurk");
                    Console.WriteLine("Perimetr on: " +perimetr);
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Umber poora sisestatud sonum");
                    lause = Console.ReadLine();
                    Console.WriteLine("Umber pooratud lause on: " + tagurpidi(lause));
                    Console.ReadLine();
                    break;
                case 6:

                    var today = DateTime.Today;
                    Console.WriteLine(today.ToString("d"));
                    
                    Console.WriteLine("Kirjutage kuupaev");

                    if (today.ToString("d") == Console.ReadLine())
                    {
                        Console.WriteLine("Sisestatud ja reaalne kuupaev on samasugused");
                    } else 
                    {
                        Console.WriteLine("Sisestatud ja reaalne kuupaev ei ole samasugused");
                        
                    }
                    Console.ReadLine();

                    break;
            }
        }

       

        static int kusiArv(string tekst)
        {
            Console.WriteLine(tekst);
            string vastus = Console.ReadLine();
            

            int a;

            if (int.TryParse(vastus, out a) == true)
            {
                
                return a;
                
            }
            else
            {
                return kusiArv("Kirjutage taissarv. Eelmine kord te sisestasite: " +vastus);
            }

        }

        //Luua meetod, mis saab sisendiks kolm arvu, mis on kolmnurga külgede pikkused, 
        //ja tagastab kas tegemist on kolmnurgaga
        static bool kolmnurk(int a, int b, int c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }

        static double celToFar(double celsius)
        {
            return celsius * 1.8 + 32;
        }

        static int sonadeArv(string lause)
        {
            return lause.Split(' ').Length;
        }

        static bool taiskasvanud(int vanus)
        {

            return vanus >= 18;
        }

        static string tagurpidi(string lause)
        {
            string tagurpidi = "";
            for (int i = 1; i < lause.Length + 1; i++)
            {
                tagurpidi += lause[lause.Length - i];
            }
            return tagurpidi;
        }

        static void Date(DateTime thisDay)
        {
            DateTime day = DateTime.Today;
            Console.WriteLine(day.ToString());
            Console.WriteLine("Hetkel: " + day);
        }

    }
}
