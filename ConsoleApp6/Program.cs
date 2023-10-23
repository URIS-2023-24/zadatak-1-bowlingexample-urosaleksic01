using ConsoleApp6;
using System;
using static ConsoleApp6.Frame;

class Program
{



    static void Main(string[] args)
    {
        Random random = new Random();
        int rn1;
        int rn2;
        int rn3;
        int total = 0;

        Frame[] niz = new Frame[10];

        for (int i = 0; i < 10; i++)
        {
            rn1 = random.Next(0, 11);
            rn2 = random.Next(0, 11 - rn1);

            niz[i] = new Frame(rn1, rn2);


        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine();
            Console.WriteLine(i + 1 + ". Frame");
            Console.WriteLine();
            Console.WriteLine("Prvo bacanje: " + niz[i].prvoBacanje);
            if (niz[i].prvoBacanje == 10)
            {

                Console.WriteLine("STRIKE!");
                niz[i].bonus = (niz[i + 1].prvoBacanje + niz[i + 1].drugoBacanje);
                if (i == 9)
                {
                    rn3 = random.Next(1, 11 - niz[i].prvoBacanje - niz[i].drugoBacanje);
                }
                Console.WriteLine("Score za ovu rundu je: " + niz[i].Izracunaj());
                total += niz[i].Izracunaj();
                Console.WriteLine("Ukupan score je: " + total);
                continue;
            }
            Console.WriteLine("Drugo bacanje: " + niz[i].drugoBacanje);
            if ((niz[i].prvoBacanje + niz[i].drugoBacanje) == 10)
            {
                Console.WriteLine("SPARE!");
                niz[i].bonus = (niz[i + 1].prvoBacanje);
                if (i == 9)
                {
                    rn3 = random.Next(1, 11 - niz[i].prvoBacanje - niz[i].drugoBacanje);
                }

                Console.WriteLine("Score za ovu rundu je: " + niz[i].Izracunaj());
                total += niz[i].Izracunaj();
                Console.WriteLine("Ukupan score je: " + total);
                continue;
            }
            else
            {

                niz[i].Izracunaj();
                Console.WriteLine("Score za ovu rundu je: " + niz[i].Izracunaj());
                total += niz[i].Izracunaj();
                Console.WriteLine("Ukupan score je: " + total);


            }




        }
        Console.ReadLine();
    }
}

