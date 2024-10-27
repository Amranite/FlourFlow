using FlourFlowDesktop.Data;
using FlourFlowDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlourFlowDesktop.Repositories
{
	internal class IngredientRepository
	{
		private readonly FlourFlowContext _context;

		public IngredientRepository(FlourFlowContext context)
		{
			_context = context;
		}

		public List<Ingredient> GetAll()
		{
			return _context.Ingredients.ToList();
		}

		public Ingredient GetById(int id)
		{
			return _context.Ingredients.Find(id);
		}

		public void Add(Ingredient ingredient)
		{
			_context.Ingredients.Add(ingredient);
			_context.SaveChanges();
		}

		public void Update(Ingredient ingredient)
		{
			_context.Ingredients.Update(ingredient);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			var ingredient = _context.Ingredients.Find(id);
			if (ingredient != null)
			{
				_context.Ingredients.Remove(ingredient);
				_context.SaveChanges();
			}
		}
	}
}
