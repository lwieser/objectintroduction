using System.Net;

namespace ObjectIntroduction
{
    public class Product
    {
        public string SerialNumber { get; set; }
    }

    public class ProductBuilder
    {
        public static Product Build(string serial)
        {
            return new Product()
            {
                SerialNumber = serial
            };
        }

        public static Product Build(long serial)
        {
            return Build(serial.ToString());
        }
    }
}