using System;

namespace ObjectIntroduction
{
    public abstract class AbstractPerson
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public abstract string Display();
    }
}