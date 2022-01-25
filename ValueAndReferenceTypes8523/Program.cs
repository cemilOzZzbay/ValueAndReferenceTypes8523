using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes8523
{
    // (int-bool-double-char) gibi primitive tipler değer tiplerdir
    // (string-array-class-interface-abstract) referans tiplerdir  
    class Program
    {
        static void Main(string[] args)
        {
            #region Value Types
            
            // number1: 30 - number2: 10
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine("No2: " + number2 + ", No1: " + number1);

            #endregion

            #region Reference Types
           
            string[] cities1 = { "Ankara", "Adana", "Afyon" };
            string[] cities2 = { "Bursa", "Bolu", "Balıkesir" };
            cities2 = cities1;
            cities1[0] = "İstanbul";
            Console.WriteLine("Cities1: " + cities1[0] + ", Cities2: " + cities2[0]); // İstanbul,İstanbul

            City city1 = new City("Ankara");
            City city2 = new City("İstanbul");
            city2 = city1;
            city1.Name = "İzmir";
            Console.WriteLine("City1: " + city1.Name + ", City2: " + city2.Name); // İzmir, İzmir 

            City city3 = new City("Edirne");
            SehirGuncelle(city3);
            Console.WriteLine("City3: " + city3.Name); // Zonguldak
            
            #endregion
            
            Console.ReadLine();
        }
        static void SehirGuncelle(City sehir)
        {
            sehir.Name = "Zonguldak";
        }
        class City
        {
            public string Name { get; set; }

            public City(string name)
            {
                Name = name;
            }
        }
    }
}
