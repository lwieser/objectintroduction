using System;

namespace ObjectIntroduction
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public string Display()
        {
            return Firstname + " " + Lastname;
        }
    }
}