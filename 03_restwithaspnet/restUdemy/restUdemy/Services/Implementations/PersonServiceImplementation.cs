using restUdemy.Models;

namespace restUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
                
        }

        public Person Get(long id)
        {
            return new Person { 
                Id        = IncrementAndGet(),
                FirstName = "Victor",
                LastName  = "Luck",
                Address   = "Rua 1",
                Gender    = "Male"
            };
        }

        public List<Person> GetAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person); 
            }
            return persons;
        }

        

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Victor - " + i,
                LastName = "Luck - "+ i,
                Address = "Rua 1 - "+ i,
                Gender = "Male - " + i 
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
