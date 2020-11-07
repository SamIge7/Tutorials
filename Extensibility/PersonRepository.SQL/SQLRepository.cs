using Microsoft.EntityFrameworkCore;
using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonRepository.SQL
{
    public class SQLRepository : IPersonReader
    {
        DbContextOptions<PersonContext> options;

        public SQLRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersonContext>();
            optionsBuilder.UseSqlite("Data Source=People.db");
            options = optionsBuilder.Options;
        }

        public IEnumerable<Person> GetPeople()
        {
            using (var context = new PersonContext(options))
            {
                return context.People.ToArray();
            }
        }

        public Person GetPerson(int id)
        {
            using (var context = new PersonContext(options))
            {
                return context.People.Where(p => p.Id == id).FirstOrDefault();
            }
        }
    }
}
