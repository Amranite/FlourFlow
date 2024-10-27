/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlourFlowDesktop.Models;

namespace FlourFlowDesktop.Data
{
	internal class Seeder
	{
		private readonly FlourFlowContext _context; // Database context for seeding data to the database

		public Seeder(FlourFlowContext context)
		{
			_context = context;
		}

		public void Seed() {
			// Check if the database is empty
			if (!_context.Ingredients.Any())
			{
				// Add ingredients to the database
				_context.Ingredients.AddRange(new List<Ingredient>
				{
					new Ingredient { Name = "Flour", QuantityInStock = 100, Unit = "kg" },
					new Ingredient { Name = "Sugar", QuantityInStock = 50, Unit = "kg" },
					new Ingredient { Name = "Butter", QuantityInStock = 20, Unit = "kg" },
					new Ingredient { Name = "Eggs", QuantityInStock = 200, Unit = "pcs" },
					new Ingredient { Name = "Milk", QuantityInStock = 100, Unit = "liters" }
				});
				_context.SaveChanges(); // Save changes to the database
			}

			if (!_context.Suppliers.Any())
			{
				// Add suppliers to the database
				_context.Suppliers.AddRange(new List<Supplier>
				{
					new Supplier { Name = "Supplier A", ContactInfo = "123-456-7890" },
					new Supplier { Name = "Supplier B", ContactInfo = "098-765-4321" },
					new Supplier { Name = "Supplier C", ContactInfo = "111-222-3333" }
				});
				_context.SaveChanges(); // Save changes to the database
			}

			if (!_context.Orders.Any())
			{
				// Add orders to the database
				_context.Orders.AddRange(new List<Order>
				{
					new Order { IngredientId = 1, Quantity = 10, OrderDate = DateTime.Now },
					new Order { IngredientId = 2, Quantity = 5, OrderDate = DateTime.Now },
					new Order { IngredientId = 3, Quantity = 2, OrderDate = DateTime.Now },
					new Order { IngredientId = 4, Quantity = 20, OrderDate = DateTime.Now },
					new Order { IngredientId = 5, Quantity = 10, OrderDate = DateTime.Now }
				});
			}

			_context.SaveChanges(); // Save changes to the database
		}
	}
}
*/