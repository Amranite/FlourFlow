using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlourFlowDesktop.Models
{
	internal class Order
	{
		public int OrderId { get; set; } // Primary Key
		public int IngredientId { get; set; } // Foreign Key
		public Ingredient Ingredient { get; set; } // Navigation property for the related ingredient

		public decimal Quantity { get; set; } // Quantity ordered
		public DateTime OrderDate { get; set; } // Date when the order was placed
	}
}
