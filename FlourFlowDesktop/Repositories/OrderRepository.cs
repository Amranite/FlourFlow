using FlourFlowDesktop.Data;
using FlourFlowDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlourFlowDesktop.Repositories
{
	internal class OrderRepository
	{
		private readonly FlourFlowContext _context;

		public OrderRepository(FlourFlowContext context)
		{
			_context = context;
		}

		public List<Order> GetAll()
		{
			return _context.Orders.ToList();
		}

		public Order GetById(int id)
		{
			return _context.Orders.Find(id);
		}

		public void Add(Order order)
		{
			_context.Orders.Add(order);
			_context.SaveChanges();
		}

		public void Update(Order order)
		{
			_context.Orders.Update(order);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			var order = _context.Orders.Find(id);
			if (order != null)
			{
				_context.Orders.Remove(order);
				_context.SaveChanges();
			}
		}
	}
}
