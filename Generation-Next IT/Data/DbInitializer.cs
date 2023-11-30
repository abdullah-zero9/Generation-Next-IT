using MonjurTask.Models;

namespace MonjurTask.Data
{
    //public static class DbInitializer
    //{
    //    public static void Initialize(ApplicationDbContext context)
    //    {
    //        context.Database.EnsureCreated();

    //        // Check if the database has been seeded
    //        if (context.Meeting_Minutes_Master_Tbl.Any())
    //        {
    //            return;
    //        }

    //        // Seed data here
    //        SeedProducts(context);
    //        SeedCorporateCustomers(context);
    //        SeedIndividualCustomers(context);
    //    }

    //    private static void SeedProducts(ApplicationDbContext context)
    //    {
    //        var products = new ProductService[]
    //        {

    //            // need to add unit, see data model


    //            new ProductService { ProductServiceID = 1, ProductServiceName = "Laptop" },
    //            new ProductService { ProductServiceID = 2, ProductServiceName = "Website making" },
    //            new ProductService { ProductServiceID = 3, ProductServiceName = "Mouse" },
    //            new ProductService { ProductServiceID = 4, ProductServiceName = "Keyboard" },
    //            new ProductService { ProductServiceID = 5, ProductServiceName = "web hosting" }
    //        };

    //        context.Products_Service_Tbl.AddRange(products);
    //        context.SaveChanges();
    //    }

    //    private static void SeedCorporateCustomers(ApplicationDbContext context)
    //    {
    //        var corporateCustomers = new CorporateCustomer[]
    //        {
    //            new CorporateCustomer { CorporateCustomerID = 1, CorporateCustomerName = "Abdullah" },
    //            new CorporateCustomer { CorporateCustomerID = 2, CorporateCustomerName = "Sultana" },
    //            new CorporateCustomer { CorporateCustomerID = 3, CorporateCustomerName = "Nayeem" }
    //        };

    //        context.Corporate_Customer_Tbl.AddRange(corporateCustomers);
    //        context.SaveChanges();
    //    }

    //    private static void SeedIndividualCustomers(ApplicationDbContext context)
    //    {
    //        var individualCustomers = new IndividualCustomer[]
    //        {
    //            new IndividualCustomer { IndividualCustomerID = 1, IndividualCustomerName = "Nayeem" },
    //            new IndividualCustomer { IndividualCustomerID = 2, IndividualCustomerName = "Emran" },
    //            new IndividualCustomer { IndividualCustomerID = 3, IndividualCustomerName = "Saleh" }
    //        };

    //        context.Individual_Customer_Tbl.AddRange(individualCustomers);
    //        context.SaveChanges();
    //    }
    //}
}
