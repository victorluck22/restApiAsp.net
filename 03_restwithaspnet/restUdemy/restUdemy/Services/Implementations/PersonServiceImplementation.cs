using restUdemy.Models;

namespace restUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(Person person)
        {
            
        }

        public Person Get(long id)
        {
            return new Person { 
                Id        = id ,
                FirstName = "Victor",
                LastName  = "Luck",
                Address   = "Rua 1",
                Gender    = "Male"
            };
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
