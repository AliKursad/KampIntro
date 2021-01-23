using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Ali";
            customer1.Surname = "Kürşad";
            customer1.TcNo = "123456789";


            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerNo = "67890";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "123456";


            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
