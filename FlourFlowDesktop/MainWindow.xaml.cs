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
		private readonly OrderRepository _orderRepository;
		private readonly SupplierRepository _supplierRepository;
		public MainWindow()
		{
			InitializeComponent();
			_ingredientRepository = new IngredientRepository(new FlourFlowContext());
			_orderRepository = new OrderRepository(new FlourFlowContext());
			_supplierRepository = new SupplierRepository(new FlourFlowContext());
			LoadIngredients();
			LoadOrders();
			LoadSuppliers();
		}

		private void LoadIngredients()
		{
			IngredientsDataGrid.ItemsSource = _ingredientRepository.GetAll();
		}

		private void LoadOrders()
		{
			OrdersDataGrid.ItemsSource = _orderRepository.GetAll();
		}

		private void LoadSuppliers()
		{
			SuppliersDataGrid.ItemsSource = _supplierRepository.GetAll();
		}

		private void AddIngredient_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				var ingredient = new Ingredient
				{
					Name = IngredientNameTextBox.Text,
					QuantityInStock = decimal.TryParse(QuantityTextBox.Text, out var qty) ? qty : 0,
					Unit = UnitTextBox.Text,
					PricePerUnit = decimal.TryParse(PriceTextBox.Text, out var price) ? price : 0
				};

				_ingredientRepository.Add(ingredient);
				LoadIngredients();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while adding the ingredient: {ex.Message}");
			}
		}

		private void AddOrder_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				var order = new Order
				{
					OrderId = int.TryParse(OrderIDTextBox.Text, out var orderId) ? orderId : 0,
					// CustomerName = CustomerNameTextBox.Text,
					OrderDate = DateTime.TryParse(OrderDateTextBox.Text, out var orderDate) ? orderDate : DateTime.Now,
					IngredientId = 0 /* get from the UI or select an ingredient */
				};

				_orderRepository.Add(order);
				LoadOrders();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while adding the order: {ex.Message}");
			}
		}

		private void AddSupplier_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				var supplier = new Supplier
				{
					Name = SupplierNameTextBox.Text,
					ContactNumber = ContactTextBox.Text
				};

				_supplierRepository.Add(supplier);
				LoadSuppliers();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while adding the supplier: {ex.Message}");
			}

		}
	}
}