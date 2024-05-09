using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class Product
    { 
       public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Id={Id}, Name={Name}, Company={Company}, Price={Price}"; 
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 101, Name = "Laptop", Company = "HP", Price = 34500 },
                new Product { Id = 102, Name = "Laptop", Company = "Dell", Price = 37500 },
                new Product { Id = 103, Name = "Laptop", Company = "Lenovo", Price = 32500 },
                new Product { Id = 104, Name = "Mouse", Company = "Dell", Price = 799 },
                new Product { Id = 105, Name = "Mobile", Company = "Apple", Price = 78500 },
                new Product { Id = 106, Name = "Mobile", Company = "MI", Price = 12500 },
                new Product { Id = 107, Name = "Keyboard", Company = "Microsoft", Price = 899 },

            };
            Console.WriteLine("--------------BY using LINQ queries----------------");
            // display product whose price is >1000
            var qry = from p in products
                      where p.Price > 1000
                      select p;
            foreach (var p in qry) 
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");
            //display products of company name dell

            var qry1= from p in products
                     where p.Company.Contains("Dell")
                     select p;
            foreach (var p in qry1)
            { 
            Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");
            //display products whose company name start with "M"
            var qry2 = from p in products
                       where p.Company.StartsWith("M")
                       select p;
            foreach (var p in qry2)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");

            //display products whose price is >1000 and order by price
            var qry3 = from p in products
                      where p.Price > 1000
                      orderby p.Price
                      select p;
            foreach (var p in qry3)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            Console.WriteLine("--------------BY using Lambda Expression----------------");

            // display product whose price is >1000
            var qry4=products.Where(x=>x.Price >1000).ToList();
            foreach (var p in qry4)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");

            //display products of company name dell

            var qry5 = products.Where(x => x.Company == "Dell").ToList();

            foreach (var p in qry5)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");

            //display products whose company name start with "M"
            var qry6 = products.Where(x => x.Company.StartsWith("M")).ToList();
            foreach (var p in qry6)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("------------------------------------------------");

            //display products whose price is >1000 and order by price
            var qry7 = products.Where(x => x.Price > 1000).OrderBy(x=>x.Price).ToList();
            foreach (var p in qry7)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            Console.WriteLine("--------------Assignment BY using LINQ Queries----------------");

            //Display all products using LINQ query

            var qry8 = from p in products
                       select p;
            foreach (var p in qry8)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("------------------------------------------------");

            //Display products whose price is greater than 1500
            var qry9 = from p in products
                      where p.Price > 1500
                      select p;
            foreach (var p in qry9)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");


            //Display products whose price is in between 10000 to 40000
            var qry10 = from p in products
                       where p.Price >=10000 && p.Price <=40000
                       select p;
            foreach (var p in qry10)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");

            //Display all company laptops

            var qry11 = from p in products
                       where p.Name.Contains("Laptop")
                       select p;
            foreach (var p in qry11)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");

            //Display all company mouse whose price is less than 1000
            var qry12 = from p in products
                        where p.Name == "Mouse" && p.Price < 1000
                        select p;
            foreach (var p in qry12)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");

            //Display all products descending order by their price

            var qry13= from p in products
                   orderby p.Price descending
                   select p;
            foreach (var p in qry13)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");

            //Display all products accessing order by their company name
            var qry14 = from p in products
                        orderby p.Company ascending 
                        select p;
            foreach (var p in qry14)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");



            //Display all keyboards accessing order by their price
            var qry15 = from p in products
                         where p.Name=="Keyboard" 
                        orderby p.Price 
                        select p;
            foreach (var p in qry15)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("--------------Assignment BY using Lambda Expression----------------");

            //Display all products descending order by their price
            var qry16=products.OrderByDescending(x=>x.Price).ToList();
            foreach (var p in qry16)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");


            //Display product whose Id is 5
            var qry17 = products.Where(x => x.Id == 105).FirstOrDefault();
            Console.WriteLine(qry17);
            Console.WriteLine("------------------------------------------------");


            //Display all products whose price less than 5000
            var qry18 = products.Where(x=>x.Price<5000).ToList();
            foreach (var p in qry18)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");

            //Display 3 products which have maximum price
            var qry19 = products.OrderByDescending(x => x.Price).Take(3);
            foreach (var p in qry19)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------------");

            //Display 5 products which have minimum price
            var qry20 = products.OrderBy(x => x.Price).Take(5);
            foreach (var p in qry20)
            {
                Console.WriteLine(p);
            }
        }
        
   

    }
}
