using PersonRepository.Interface;
using System;
using System.Collections.Generic;

namespace PersonRepository.Fake
{
    public class FakeRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            var people = new List<Person>()
            {
                new Person() {Id = 1, GivenName = "Sam", FamilyName = "Ige",  Rating = 7, StartDate = new DateTime(2020, 11, 6)},
                new Person() {Id = 2, GivenName = "Nicole", FamilyName = "Kendall", Rating = 9, StartDate = new DateTime(2020, 11,6)},
            };

            return people;
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int id, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
