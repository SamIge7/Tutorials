﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pluralsight.ConcurrentCollections.SellShirts
{
	public class SalesPerson
	{
		public string Name { get; }
		public SalesPerson(string name)
		{
			this.Name = name;
		}
		public void Work(TimeSpan workDay, StockController controller)
		{
			DateTime start = DateTime.Now;
			while (DateTime.Now - start < workDay)
			{
				var result = ServeCustomer(controller);
				if (result.Status != null)
					Console.WriteLine($"{Name}: {result.Status}");
				if (!result.ShirtsInStock)
					break;
			}
		}
		public (bool ShirtsInStock, string Status) ServeCustomer(
			StockController controller)
		{
			var result = controller.SelectRandomShirt();
			TShirt shirt = result.Tshirt;
			if (result.Result == SelectResult.NoStockLeft)
				return (false, "All shirts sold");
			else if (result.Result == SelectResult.ChosenTShirtSold)
				return (true, "Chosen Tshirt sold already");

			Thread.Sleep(Rnd.NextInt(30));

			// customer chooses to buy with only 20% probability
			if (Rnd.TrueWithProb(0.2))
			{
				bool sold = controller.Sell(shirt.Code);
				if (sold)
					return (true, $"Sold {shirt.Name}");
				else
					return (false, $"Can't sell {shirt.Name}, it has already been sold");
			}
			return (true, null);
		}



	}
}
