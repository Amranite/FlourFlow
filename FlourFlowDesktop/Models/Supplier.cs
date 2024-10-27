using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlourFlowDesktop.Models
{
	internal class Supplier
	{
		[Key]
		public int SupplierId { get; set; } // Primary Key
		[Required]
		public string Name { get; set; } // Name of the supplier
		public string ContactNumber { get; set; } // Contact information of the supplier
		public string Address { get; set; } // Address of the supplier

		// Navigation property for the related ingredients
		// public ICollection<Ingredient> Ingredient { get; set; } = new List<Ingredient>();
	}
}
