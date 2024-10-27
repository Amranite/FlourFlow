using FlourFlowDesktop.Data;
using FlourFlowDesktop.Repositories;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FlourFlowDesktop.Models;


namespace FlourFlowDesktop
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly IngredientRepository _ingredientRepository;
		public MainWindow()
		{
			InitializeComponent();
			_ingredientRepository = new IngredientRepository(new FlourFlowContext());
			LoadIngredients();
		}

		private void LoadIngredients()
		{
			IngredientsDataGrid.ItemsSource = _ingredientRepository.GetAll();
		}

		private void AddIngredient_Click(object sender, RoutedEventArgs e)
		{
			var ingredient = new Ingredient
			{
				Name = IngredientNameTextBox.Text,
				QuantityInStock = decimal.TryParse(QuantityTextBox.Text, out var qty) ? qty : 0m, // Change to decimal
				Unit = UnitTextBox.Text,
				PricePerUnit = decimal.TryParse(PriceTextBox.Text, out var price) ? price : 0m // Use '0m' for decimal
			};

			_ingredientRepository.Add(ingredient);
			LoadIngredients();
		}
	}
}