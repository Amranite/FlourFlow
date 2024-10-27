using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlourFlowDesktop.Models
{
	internal class Ingredient
	{
		[Key]
		public int IngredientId { get; set; } // Primary Key
		[Required]
		public string Name { get; set; } // Name of the ingredient

		public decimal QuantityInStock { get; set; } // Current quantity in stock
		[Required]
		public string Unit { get; set; } // Unit of measurement (e.g. kilograms, grams, liters, etc.)

		public double ReorderLevel { get; set; } // Reorder level for the ingredient
		public decimal PricePerUnit { get; set; } // Price per unit of the ingredient

		// public int SupplierId { get; set; } // Foreign Key
		// public Supplier Supplier { get; set; } // Navigation property for the related supplier

	}
}
