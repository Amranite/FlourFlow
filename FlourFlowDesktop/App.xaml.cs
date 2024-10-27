using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows;
using FlourFlowDesktop.Data;
using FlourFlowDesktop.Models;
using FlourFlowDesktop.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FlourFlowDesktop
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		// This was just to check if the CRUD operations work
		/*protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			// Set up the database context and repositories
			using (var context = new FlourFlowContext())
			{
				// Ensure database is created
				context.Database.EnsureCreated();

				var ingredientRepo = new IngredientRepository(context);
				var supplierRepo = new SupplierRepository(context);
				var orderRepo = new OrderRepository(context);

				// Test the CRUD operations for Ingredient
				var ingredient = new Ingredient
				{
					Name = "Flour",
					QuantityInStock = 100,
					Unit = "kg",
					ReorderLevel = 20,
					PricePerUnit = 1.50m
				};

				// Create
				ingredientRepo.Add(ingredient);
				Debug.WriteLine("Ingredient added: " + ingredient.Name);

				// Read
				var allIngredients = ingredientRepo.GetAll();
				Debug.WriteLine("All ingredients:");
				foreach (var ing in allIngredients)
				{
					Debug.WriteLine($"- {ing.Name}, Stock: {ing.QuantityInStock} {ing.Unit}, Price: {ing.PricePerUnit}");
				}

				// Update
				ingredient.QuantityInStock = 80;
				ingredientRepo.Update(ingredient);
				Debug.WriteLine("Ingredient updated: " + ingredient.Name);

				// Delete
				ingredientRepo.Delete(ingredient.IngredientId);
				Debug.WriteLine("Ingredient deleted: " + ingredient.Name);
			}
		}*/

	}

}
