using System;
using System.Collections.Generic;

namespace ObjectIntroduction
{
    public abstract class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
    }
    public class Employee : Person
    {
        public string BadgeNumber { get; set; }
    }

    public class Customer : Person, ICustomer
    {
        public bool HasConsent { get; set; }
        public List<Order> Orders { get; set; }
        public void Visit()
        {
            throw new NotImplementedException();
        }

        public void Buy(Product product)
        {
            throw new NotImplementedException();
        }
    }
}