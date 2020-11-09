using System;
using System.Collections.Generic;

namespace ObjectIntroduction
{
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

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}