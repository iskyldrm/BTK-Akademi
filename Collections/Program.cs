using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dizilerde yaşanabilecek problemleri ortadan kaldırmak için yapılabilcek nesneleredir.

            string[] cities = new string[2] { "ankara", "istanbul" };

            cities = new string[3] { "", "2", "" };

            Console.WriteLine(cities[0]);

            Console.WriteLine(cities[1]);

            Paremetreler paremetreler = new Paremetreler();

            

            // listeler aynı isimler yeniden newlendiğinde garbage collettor diğer diziyi sileri

            ArrayList arrayList = new ArrayList();

            arrayList.Add("adana");
            arrayList.Add("bursa");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            List<Paremetreler> paremetrelers = new List<Paremetreler>
            {
                new Paremetreler{ Id=1, Name = "isak"},
                new Paremetreler{Id = 2, Name="ali"}
                
            };

            var parametre = new Paremetreler { 
            Id = 3 , 
            Name = "cop"};

            paremetrelers.Add(parametre);

            paremetrelers.AddRange(new Paremetreler[2]
            {
                new Paremetreler{ Id= 4 , Name = "nurka"},
                new Paremetreler{ Id = 5, Name = "cihan"}    
            });

            paremetrelers.Insert(0, new Paremetreler {Id = 0, Name="hasan" });
            var caunt =  paremetrelers.Count;

            foreach (var item in paremetrelers)
            {
                Console.WriteLine(item.Id + " " + item.Name + caunt);
            }

            

            Console.ReadLine();
        }

        class Paremetreler
        {
            public int Id { get; set; }
            public string Name { get; set; } 
            
            public void deneme()
            {
                Console.WriteLine("daksdnask");
            }
        }
    }
}
