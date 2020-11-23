using System.Collections.Generic;
using System.Linq;

namespace ObjectIntroduction
{
    public class PersistanceService
    {
        private ObjectIntroductionContext _context;

        public PersistanceService()
        {
            _context = new ObjectIntroductionContext();
        }

        public void AddPerson(Person product)
        {
            _context.Persons.Add(product);
            _context.SaveChanges();
        }

        public Person Get(int id)
        {
            return _context.Persons.FirstOrDefault(x => x.Id == id);
        }

        public List<Person> ListPersons()
        {
            return _context.Persons.ToList();
        }

        public void Update(int id, string firstname, string lastname)
        {
            Person prs = Get(id);
            prs.Lastname = lastname;
            prs.Firstname = firstname;
            _context.SaveChanges();
        }

        public void Delete(in int id)
        {
            _context.Persons.Remove(Get(id));
            _context.SaveChanges();
        }
    }
}
