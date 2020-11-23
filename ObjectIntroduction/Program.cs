using System;
using System.Threading;

namespace ObjectIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            PersistanceService ps = new PersistanceService();
            do
            {
                ShowMenu();
                var key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.WriteLine("(prénom) (nom)");
                        var name = Console.ReadLine().Split(" ");
                        var person = new Person()
                        {
                            Firstname = name[0],
                            Lastname = name[1]
                        };
                        ps.AddPerson(person);
                        break;
                    case "2":
                        var persons = ps.ListPersons();
                        foreach (var person1 in persons)
                        {
                            Console.WriteLine($"{person1.Id} {person1.Firstname} {person1.Lastname}");
                        }
                        break;
                }

            } while (true);
        }

        private static void ShowMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Choisir une action");
            Console.WriteLine("1/ Ajouter une personne");
            Console.WriteLine("2/ Lister les personnes");
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
