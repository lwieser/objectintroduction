using System;

namespace ObjectIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Firstname = "Laurent";
            customer.Lastname = "Wieser";

            CustomerStruct customerStruct = new CustomerStruct();
            customerStruct.Firstname = "Laurent";
            customerStruct.Lastname = "Wieser";

            Anonymize(customerStruct);
            Anonymize(customer);

            Console.WriteLine("Prénom customer " + customer.Firstname);
            Console.WriteLine("Prénom customerStruct " + customerStruct.Firstname);
        }

        public static void Anonymize(Customer customer)
        {
            customer.Firstname = "N/A";
        }

        public static void Anonymize(CustomerStruct customer)
        {
            customer.Firstname = "N/A";
        }
    }
}
