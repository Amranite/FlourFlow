using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlourFlowDesktop.Models
{
	internal class Ingredient
	{
		public int IngredientId { get; set; } // Primary Key
		public string Name { get; set; } // Name of the ingredient


		public decimal Quantity { get; set; } // Current quantity in stock
		public string Unit { get; set; } // Unit of measurement (e.g. kilograms, grams, liters, etc.)

		public int SupplierId { get; set; } // Foreign Key
		public Supplier Supplier { get; set; } // Navigation property for the related supplier

	}
}
