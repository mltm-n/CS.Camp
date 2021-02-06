using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Name = "Meltem";
            customer1.Surname = "*****";
            customer1.Id = 12;
            customer1.CustomerNumber = "123";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 15;
            customer2.CustomerNumber = "123";
            customer2.CompanyName = "Company";
            customer2.TaxNu = "4565";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManger = new CustomerManager();

            customerManger.Addition(customer1);
            customerManger.Addition(customer2);
            customerManger.Addition(customer3);
            customerManger.Addition(customer4);
        }
    }
}
