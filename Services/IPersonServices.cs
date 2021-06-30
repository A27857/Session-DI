using System.Collections.Generic;
using SessionDI.Models;

public interface IPersonServices
{
    List<Person> GetAll();

    Person GetOne(int id);

    void Create(Person person);

    void Update(Person person);

    void Delete(int id);
}