using System;
using System.Threading;
using Microsoft.EntityFrameworkCore;

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
                        AddPerson(ps);
                        break;
                    case "2":
                        ListPersons(ps);
                        break;
                    case "3":
                        UpdatePerson(ps);
                        break;
                    case "4":
                        Delete(ps);
                        break;

                }

            } while (true);
        }

        private static void UpdatePerson(PersistanceService ps)
        {
            ListPersons(ps);
            Console.WriteLine("Sélectionner un Id ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("(prénom) (nom)");
            var name = Console.ReadLine().Split(" ");
            ps.Update(id, name[0], name[1]);
        }

        private static void Delete(PersistanceService ps)
        {
            ListPersons(ps);
            Console.WriteLine("Sélectionner un Id ");
            int id = int.Parse(Console.ReadLine());
            ps.Delete(id);
        }

        private static void ListPersons(PersistanceService ps)
        {
            var persons = ps.ListPersons();
            foreach (var person1 in persons)
            {
                Console.WriteLine($"{person1.Id} {person1.Firstname} {person1.Lastname}");
            }
        }

        private static void AddPerson(PersistanceService ps)
        {
            Console.WriteLine("(prénom) (nom)");
            var name = Console.ReadLine().Split(" ");
            var person = new Person()
            {
                Firstname = name[0],
                Lastname = name[1]
            };
            ps.AddPerson(person);
        }

        private static void ShowMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Choisir une action");
            Console.WriteLine("1/ Ajouter une personne");
            Console.WriteLine("2/ Lister les personnes");
            Console.WriteLine("3/ Mise à jour des utilisateurs");
            Console.WriteLine("4/ Suppression d'utilisateur");
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
