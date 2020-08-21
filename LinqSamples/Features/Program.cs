using System;
using System.Collections.Generic;
using System.Linq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x,y) => x + y;
            Action<int> write = x => Console.WriteLine(x);
            write(add(3, 5));

            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Scott"},
                new Employee {Id = 2, Name = "Chris"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee{Id = 3, Name = "Alex"}
            };

            var query = developers.Where(e => e.Name.Length == 5)
                                                .OrderBy(e => e.Name);

            var query2 = from developer in developers
                         where developer.Name.Length == 5
                         orderby developer.Name
                         select developer;

            foreach (var employee in query)
            {
                Console.WriteLine(employee.Name);
            }
        }

        private static int Square(int arg)
        {
            throw new NotImplementedException();
        }
    }
}
