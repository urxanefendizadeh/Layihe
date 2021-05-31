using System;
using System.Collections.Generic;

namespace SatisSistemiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 1;
            List<Product> products = new List<Product>
            {
                new Product{ProductName = "Coca-cola",Category = Categories.Beverages,ProductCode = "123456",Quantity = 25,UnitPrice = 14},
                new Product{ProductName = "Pepsi",Category = Categories.Beverages,ProductCode = "654321",Quantity = 14,UnitPrice = 23},
            };
            List<string> operations = new List<string>
            {
                "Mehsullar uzerinde emeliyyat aparmaq",
                "Satislar uzerinde emeliyyat aparmaq",
                "Sistemden cixmaq"

            };
            List<string> productOptions = new List<string>
            {
                "Yeni mehsul elave et",
                "Mehsul uzerinde duzelis et",
                "Mehsulu sil",
                "Butun mehsullari goster",
                "Categoriyasina gore mehsullari goster",
                "Qiymet araligina gore mehsullari goster",
                "Mehsullar arasinda ada gore axtaris et"

            }; 
            List<string> orderOptions = new List<string>
            {
                "Yeni satis elave etmek",
                "Satisdaki hansisa mehsulun geri qaytarilmasi",
                "Satisin silinmesi",
                "Butun satislarin ekrana cixarilmasi",
                "Verilen tarix araligina gore satislarin gosterilmesi",
                "Verilen mebleg araligina gore satislarin gosterilmesi",
                "Verilmis bir tarixde olan satislarin gosterilmesi",
                "Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi"

            };

            for (int i = 0; i < operations.Count; i++)
            {
               
                Console.WriteLine($"\t-{counter++} {operations[i]} ");
            }
            
            var checkedOperation = Convert.ToInt32(Console.ReadLine());

            if (checkedOperation == 1)
            {
                counter = 1;
                for (int i = 0; i < productOptions.Count; i++)
                {
                    Console.WriteLine($"\t-{counter++} {productOptions[i]} ");
                }

                var productChecker = Convert.ToInt32(Console.ReadLine());

                if (productChecker == 1)
                {
                    ProductAdded(products);
                }else if (productChecker == 2)
                {
                    counter = 1;
                    foreach (var product in products)
                    {
                   
                        Console.WriteLine($"\t-{counter++} {product.ProductName}");
                       
                    }

                    Console.WriteLine("deyisiklik elemek isdediyiniz mehsulun adini yazin");
                    var productName = Console.ReadLine();

                    foreach (var product in products)
                    {
                        if (product.ProductName.ToLower() == productName.ToLower())
                        {
                           Console.WriteLine("Mehsulun Miqdarini daxil edin");
                           product.Quantity = Convert.ToInt16(Console.ReadLine());
                           Console.WriteLine("Mehsulun qiymetini daxil edin");
                           product.UnitPrice = Convert.ToDecimal(Console.ReadLine());
                           Console.WriteLine($"Yeni miqdar {product.Quantity} yeni qiymet {product.UnitPrice}");
                        }
                    }

                   
                }

            } 
            else if (checkedOperation == 2)
            {
                counter = 1;
                for (int i = 0; i < orderOptions.Count; i++)
                {
                    Console.WriteLine($"\t-{counter++} {orderOptions[i]} ");
                }

            }
            else
            {
                Console.Clear();
            }
        }

        private static void ProductAdded(List<Product> products)
        {
            Product product = new Product();
            Console.WriteLine("elave edeceyiniz mehsulin adini yazin");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("elave edeceyiniz mehsulun qiymetini daxil edin");
            product.UnitPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Gosterilen seceneklerden birini daxil edin");
            foreach (var category in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine(category);
            }

            var spelledCategory = Console.ReadLine();
            foreach (var category in Enum.GetValues(typeof(Categories)))
            {
                if (category.ToString() == spelledCategory)
                {
                    product.Category = (Categories) Enum.Parse(typeof(Categories), spelledCategory, true);
                }
            }

            Console.WriteLine("Mehsulun miqdarin daxil edin");
            product.Quantity = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Mehsulun kodun daxil edin");
            product.ProductCode = Console.ReadLine();
            ProductProcesses productProcesses = new ProductProcesses();
            productProcesses.Add(products, product);
            Console.WriteLine($"{product.ProductName} ugurla daxil elave edildi");
        }

        
    }

    enum Categories
    {
        Beverages, Condiments, Confection, DairyProducts, GrainsCereals, MeatPoultry, Produce, Seafood
    }
}
