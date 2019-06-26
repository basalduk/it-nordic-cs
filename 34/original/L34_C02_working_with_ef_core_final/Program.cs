using L34_C02_working_with_ef_core_final.Data;
using L34_C02_working_with_ef_core_final.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace L34_C02_working_with_ef_core_final
{
	class Program
	{
        private static OnlineStoreContext _context = new OnlineStoreContext();

		static void Main(string[] args)
		{
            //Console.WriteLine("Hello World!");
            //InsertCustomers();
            //InsertProduct();

            //SelectCustomer();
            //MoreQuereis();
            //MoreProduct();
            //UpdateCustomers();
            //UpdateCustomersDisconnected();
            DeletedCustomers();
        }

        private static void DeletedCustomers()
        {
            //var customer = _context.Customers.First(c => c.Id==3);
            var customer = new Customer { Id = 2 };
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        private static void UpdateCustomersDisconnected()
        {
            var product = new Product
            {
                Id = 1,
                Name = "TEST",
                Price = 10m - 10m * 0.1m
            };
            
            using (var newContext = new OnlineStoreContext())
            {
                newContext.Products.Update(product);
                newContext.SaveChanges();

            }
        }

        private static void UpdateCustomers()
        {
            var customer = _context.Customers.First();
            customer.Name = "Mr." + customer.Name;
            _context.SaveChanges();
        }

        private static void MoreProduct()
        {
            var products = _context.Products
                .Where(p=>EF.Functions.Like( p.Name, "%olo%"))
                .ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} ({product.Id}): {product.Price}");
            }

        }

        private static void MoreQuereis()
        {
            //_context.Customers.Where(c => c.Name.StartsWith("M")).ToList();
            var customers = _context
                .Customers
                .OrderBy(c => c.Id)
                .Last(x=> x.Name.Length>6);
        }

        private static void SelectCustomer()
        {
            using (var context = new OnlineStoreContext())
            {
                //string p = "Mikhail";
                //var allCustomers = context
                //    .Customers
                //    .Where(x=> x.Name==p)
                //    .ToList();

                var customers = context.Customers.ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.Id}, {customer.Name}");
                }
            }
        }

        private static void InsertCustomers()
        {
            var customer = new Customer { Name = "Nikolay" };

            using (var context = new OnlineStoreContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();

            }
        }

        private static void InsertProduct()
        {
            var product = new Product { Name = "Ryazenka", Price = 5};
            var products = new Product[]
            {
                new Product {Name = "kefir", Price = 4 },
                new Product {Name = "Yogurt", Price = 5 }

            };

            using (var context = new OnlineStoreContext())
            {
                context.Products.Add(product);

                context.AddRange(products);
                context.SaveChanges();

            }


        }

    }
}
