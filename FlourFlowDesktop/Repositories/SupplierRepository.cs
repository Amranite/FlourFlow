using FlourFlowDesktop.Data;
using FlourFlowDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlourFlowDesktop.Repositories
{
	internal class SupplierRepository
	{
		private readonly FlourFlowContext _context;

		public SupplierRepository(FlourFlowContext context)
		{
			_context = context;
		}

		public List<Supplier> GetAll()
		{
			return _context.Suppliers.ToList();
		}

		public Supplier GetById(int id)
		{
			return _context.Suppliers.Find(id);
		}

		public void Add(Supplier supplier)
		{
			_context.Suppliers.Add(supplier);
			_context.SaveChanges();
		}

		public void Update(Supplier supplier)
		{
			_context.Suppliers.Update(supplier);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			var supplier = _context.Suppliers.Find(id);
			if (supplier != null)
			{
				_context.Suppliers.Remove(supplier);
				_context.SaveChanges();
			}
		}
	}
}
