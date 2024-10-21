using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlourFlowDesktop.Models
{
	internal class Supplier
	{
		public int SupplierId { get; set; } // Primary Key
		public string SupplierName { get; set; } // Name of the supplier
		public string ContactInfo { get; set; } // Contact information of the supplier

		// Navigation property for the related ingredients
		public ICollection<Ingredient> Ingredient { get; set; } = new List<Ingredient>();
	}
}
