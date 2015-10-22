using System.Collections.Generic;

namespace PeopleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PeopleService : IGetPeopleService
    {
        public Person[] GetPeopleData(int value)
        {
            List<Person> people = new List<Person>();
            var creator = new PeopleConstants();
            for (int i = 0; i < value; i++)
            {
                var person = creator.CreatePerson();
                person.Id = i + 1;
                people.Add(person);

            }

            return people.ToArray();
        }

    }
}
