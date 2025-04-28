class Sklad
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }

		public Product(int id, string name, decimal price, int quantity)
		{
			Id = id;
			Name = name;
			Price = price;
			Quantity = quantity;
		}
	}
	public class Supplier
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Contact { get; set; }

		public Supplier(int id, string name, string contact)
		{
			Id = id;
			Name = name;
			Contact = contact;
		}
	}
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }

		public Customer(int id, string name, string address)
		{
			Id = id;
			Name = name;
			Address = address;
		}
	}
	public class Warehouse
	{
		private List<Product> _products = new List<Product>();
		private List<Supplier> _suppliers = new List<Supplier>();
		private List<Customer> _customers = new List<Customer>();

		// Добавить товар
		public void AddProduct(Product product)
		{
			var existingProduct = _products.Find(p => p.Id == product.Id);
			if (existingProduct != null)
				existingProduct.Quantity += product.Quantity;
			else
				_products.Add(product);
		}

		// Удалить товар (продажа/списание)
		public bool RemoveProduct(int productId, int quantity)
		{
			var product = _products.Find(p => p.Id == productId);
			if (product == null || product.Quantity < quantity)
				return false;

			product.Quantity -= quantity;
			return true;
		}

		// Добавить поставщика
		public void AddSupplier(Supplier supplier)
		{
			_suppliers.Add(supplier);
		}

		// Добавить заказчика
		public void AddCustomer(Customer customer)
		{
			_customers.Add(customer);
		}

		// Получить список товаров
		public List<Product> GetProducts()
		{
			return _products;
		}
	}
	static void Main()
	{
		var warehouse = new Warehouse();

		// Добавление поставщиков
		warehouse.AddSupplier(new Supplier(1, "ООО Джон", "+7 (123) 456-7890"));
		warehouse.AddSupplier(new Supplier(2, "ЗАО Каштан", "kashtan@jobs.com"));

		// Добавление заказчиков
		warehouse.AddCustomer(new Customer(1, "Магазин 'Пал Палыч'", "ул. Победы, 1"));
		warehouse.AddCustomer(new Customer(2, "Онлайн-маркет", "www.shop.ru"));

		// Добавление товара
		warehouse.AddProduct(new Product(1, "Ноутбук", 53000, 10));
		warehouse.AddProduct(new Product(2, "Камера", 2500, 50));
		Console.WriteLine("Товары на складе:");
		foreach (var product in warehouse.GetProducts())
		{
			Console.WriteLine($"{product.Name}: {product.Quantity} шт.");
		}
		// Продажа товара
		bool success = warehouse.RemoveProduct(1, 2);
		Console.WriteLine(success ? "Товар продан!" : "Товара нет или недостаточно!");

		// Выводим список товаров
		Console.WriteLine("\nОстатки на складе:");
		foreach (var product in warehouse.GetProducts())
		{
			Console.WriteLine($"{product.Name}: {product.Quantity} шт.");
		}
	}
}
