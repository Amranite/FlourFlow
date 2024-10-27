using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlourFlowDesktop.Models
{
	internal class Order
	{
		[Key]
		public int OrderId { get; set; } // Primary Key

		[Required]
		public int IngredientId { get; set; } // Foreign Key
		
		[Required]
		public int SupplierId { get; set; }

		public DateTime OrderDate { get; set; } // Date when the order was placed

		public double QuantityOrdered { get; set; } // QuantityInStock ordered

		public decimal TotalCost { get; set; } // Total cost of the order

		[Required]
		public string Status { get; set; } // Status of the order (e.g. pending, delivered, etc.)

		[ForeignKey("IngredientId")]
		public Ingredient Ingredient { get; set; }

		[ForeignKey("SupplierId")]
		public Supplier Supplier { get; set; }

		// public Ingredient Ingredient { get; set; } // Navigation property for the related ingredient





	}
}
