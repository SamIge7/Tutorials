using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasAndDelegates
{
    public delegate int BizRulesDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            var custs = new List<Customer>
            {
                new Customer{FirstName = "Sam", LastName = "Ige", City = "London", ID = 1},
                new Customer{FirstName = "Nicole", LastName = "Kendall", City = "London", ID = 2},
                new Customer{FirstName = "Lewis", LastName = "Marshall", City = "Bedford", ID = 3},
                new Customer{FirstName = "Adrienne", LastName = "Rennie", City = "Glasgow", ID = 4}
            };

            var londonCusts = custs.Where(c => c.City == "London");

            foreach (var cust in londonCusts)
            {
                Console.WriteLine("Name: " + cust.FirstName + " " + cust.LastName);
            }

            //var data = new ProcessData();
            //BizRulesDelegate addDel = (x, y) => x + y;
            //BizRulesDelegate multiplyDel = (x, y) => x * y;
            //BizRulesDelegate subtractDel = (x, y) => x - y;
            //BizRulesDelegate divideDel = (x, y) => x / y;
            ////data.Process(2, 3, multiplyDel);

            //Func<int, int, int> funcAddDel = (x, y) => x + y;
            //Func<int, int, int> funcMultiplyDel = (x, y) => x * y;
            //Func<int, int, int> funcSubtractDel = (x, y) => x - y;
            //Func<int, int, int> funcDivideDel = (x, y) => x / y;
            //data.ProcessFunc(2, 3, funcMultiplyDel);

            //Action<int, int> myAdditionAction = (x, y) => Console.WriteLine(x + y);
            //Action<int, int> myMultiplicationAction = (x, y) => Console.WriteLine(x * y);
            //Action<int, int> mySubtractionAction = (x, y) => Console.WriteLine(x - y);
            //Action<int, int> myDivisionAction = (x, y) => Console.WriteLine(x / y);
            //data.ProcessAction(2, 3, myAdditionAction);

            //var worker = new Worker();
            //worker.WorkPerformed += (s,e) => Console.WriteLine("Worked: " + e.Hours + " hour(s) doing: " + e.WorkType);
            //worker.WorkCompleted += (s,e) => Console.WriteLine("Work is complete!");
            //worker.DoWork(8, WorkType.GenerateReports);

            Console.Read();
        }

        //static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine("Worked: " + e.Hours + " hour(s) doing: " + e.WorkType);
        //}

        //static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Work is complete!");
        //}
    }
}
