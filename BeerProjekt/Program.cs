using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beer beer1 = new Beer("Tuborg", "Tuborg grøn", BeerType.Porter, 33, 4.6);
            Beer beer2 = new Beer("Royal Unibrew", "Pilsner", BeerType.Münchener, 33, 4.2);

            Beer beer3 = new Beer("carlsberg", "Sort Guld", BeerType.Bock, 33, 6.3);
            Beer beer4 = new Beer("FedBryg", "Nice Øl", BeerType.Lager, 33, 10);

            Console.WriteLine("første øl uden sortering:");
            Console.WriteLine(beer1);
            Console.WriteLine(beer2);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine("Øl med ADD:");
            beer1.add(beer2);
            Console.WriteLine(beer1);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine("Øl med første mix:");
            beer3 = beer3.mix(beer4);
            Console.WriteLine(beer3);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine("Øl med anden mix:");
            beer3 = Beer.Mix(beer3, beer4);
            Console.WriteLine(beer3);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Beer[] beers = new Beer[4];
            beers[0] = beer1;
            beers[1] = beer2;
            beers[2] = beer3;
            beers[3] = beer4;

            Console.WriteLine("sortert by procent");
            Array.Sort(beers, new SortingbeerBy(SortBy.UNIT));
            Console.WriteLine("\nsorted");
            foreach (var item in beers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine("Sorteret by Volume:");
            SortingbeerBy compareByVolume = new SortingbeerBy(SortBy.VOLUME);
            Array.Sort(beers, compareByVolume);
            foreach (var item in beers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
