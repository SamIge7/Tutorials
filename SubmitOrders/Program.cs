using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SubmitOrders
{
	class Program
	{
		static void Main(string[] args)
		{
			var ordersQueue = new Queue<string>();
			PlaceOrders(ordersQueue, "Xavier", 5);
			PlaceOrders(ordersQueue, "Ramdevi", 5);

			foreach (string order in ordersQueue)
				Console.WriteLine("ORDER: " + order);
		}

		static void PlaceOrders(Queue<string> orders, string customerName, int nOrders)
		{
			for (int i = 1; i <= nOrders; i++)
			{
				Thread.Sleep(1);
				string orderName = $"{customerName} wants t-shirt {i}";
				orders.Enqueue(orderName);
			}
		}
	}
}