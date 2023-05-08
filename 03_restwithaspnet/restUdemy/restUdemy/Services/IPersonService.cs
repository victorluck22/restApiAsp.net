using restUdemy.Models;

namespace restUdemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);
        void Delete(long id);
        Person Get(long id);
        List<Person> GetAll();


    }
}
