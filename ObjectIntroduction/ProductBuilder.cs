namespace ObjectIntroduction
{
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