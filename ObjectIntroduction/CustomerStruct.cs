using System;
using System.Collections.Generic;

namespace ObjectIntroduction
{
    public struct CustomerStruct
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public bool HasConsent { get; set; }
        public List<Order> Orders { get; set; }
    }
}