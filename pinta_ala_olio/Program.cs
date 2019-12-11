using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace pinta_ala_olio
{
   static class Program
    {
     

        private static void Main(string[] args)
        {

            //tässä luetaan Pinta-ala laskimen manuaali teksti-tiedostosta//
            string filePath = @"C:\pinta_ala_olio\Manuaali.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();


            /*https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2019 rakennetaan 
                case-lauseella valintapainikkeet laskimelle*/
            double u_lukuX, u_lukuY; ;
            
            Console.WriteLine("Valitse laskettavan pinta-alan muoto:");
            Console.WriteLine("\t[k] - Kolmio");
            Console.WriteLine("\t[n] - Neliö");
            Console.WriteLine("\t[y] - Ympyrä");
            Console.Write("Valintasi?:  ");

           
            


            switch (Console.ReadLine())
            {
                

                case "k":
                    try
                    {
                        Console.Write("Anna kolmion kannan pituus: ");
                        u_lukuX = double.Parse(Console.ReadLine());
                        Console.Write("\nAnna kolmion korkeus: ");
                        u_lukuY = double.Parse(Console.ReadLine());
                        Kolmio kolmio = new Kolmio();//siirretään arvot luokalle setterien avulla
                        kolmio.Kanta = u_lukuX; //aktivoidaan Kanta setterin arvo
                        kolmio.Korkeus = u_lukuY; //aktivoidaan Korkeus setterin arvo
                        Console.Write("\nKolmion pinta-ala on: " + kolmio.Laskuri());
                        
                    }
                    catch
                    {
                        Console.Write("Virheellinen syöte.");
                    }
                    
                    Console.Write("\n\nPaina jotain näppäintä jatkaaksesi...");
                    Console.ReadKey(true);
                    break;

                case "n":
                    try
                    {
                        Console.Write("Anna Neliön kannan pituus: ");
                        u_lukuX = double.Parse(Console.ReadLine());
                        Console.Write("\nAnna neliön korkeus: ");
                        u_lukuY = double.Parse(Console.ReadLine());
                        Nelio nelio = new Nelio();//siirretään arvot luokalle setterien avulla
                        nelio.Kanta = u_lukuX;//aktivoidaan Kanta setterin arvo
                        nelio.Korkeus = u_lukuY;//aktivoidaan Korkeus setterin arvo
                        Console.Write("\nKolmion pinta-ala on: " + nelio.Laskuri());

                    }
                    catch
                    {
                        Console.Write("Virheellinen syöte.");
                    }

                    Console.Write("\n\nPaina jotain näppäintä jatkaaksesi...");
                    Console.ReadKey(true);
                    break;

                case "y":
                    try
                    {
                        //Console.Write("Anna Neliön kannan pituus: ");
                        //u_LukuX = double.Parse(Console.ReadLine());
                        Console.Write("\nAnna ympyrän säde: ");
                        u_lukuY = double.Parse(Console.ReadLine());
                        Ympyra ympyra = new Ympyra();//siirretään arvot luokalle setterien avulla
                        //ympyra.Pii = u_LukuX;
                        ympyra.Sade = u_lukuY;
                        Console.Write("\nYmpyran pinta-ala on: " + ympyra.Laskuri());

                    }
                    catch
                    {
                        Console.Write("Virheellinen syöte.");
                    }

                    Console.Write("\n\nPaina jotain näppäintä jatkaaksesi...");
                    Console.ReadKey(true);
                    break;



            }
        }
    }
}
