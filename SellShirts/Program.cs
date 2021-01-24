using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pluralsight.ConcurrentCollections.SellShirts
{
	class Program
	{
		static void Main(string[] args)
		{
			StockController controller = new StockController(TShirtProvider.AllShirts);
			TimeSpan workDay = new TimeSpan(0, 0, 0, 0, 500);

			new SalesPerson("Kim").Work(workDay, controller);

			controller.DisplayStock();
		}
	}
}
