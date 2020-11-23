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

        public List<Person> ListPersons()
        {
            return _context.Persons.ToList();
        }
    }
}
