﻿using System;

namespace ObjectIntroduction
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public string Display()
        {
            return Firstname + " " + Lastname;
        }
    }
    public abstract class AbstractPerson
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public abstract string Display();
    }
}