using System;

namespace ClassMetotDemo
{
	class Program
	{
		private static object costumer1;

		static void Main(string[] args)
		{
			CustomerManager customerManager = new CustomerManager();
			Customer customer1 = new Customer();
			customer1.Id = 1001;
			customer1.Adi = "Nisa";
			customer1.Soyadi = "Küçükkömürcü";
			customer1.City = "Ankara";



			Customer customer2 = new Customer();
			customer2.Id = 1002;
			customer2.Adi = "Nur";
			customer2.Soyadi = "Küçüükkömürcü";
			customer2.City = "Adana";



			Customer customer3 = new Customer();
			customer3.Id = 1003;
			customer3.Adi = "Ada";
			customer3.Soyadi = "Güzel";
			customer3.City = "İstanbul";

			////customerManager.Add(customer1);
			//customerManager.Update(customer2);
			//customerManager.Delete(customer3);


			Customer[] customers = new Customer[ ]{customer1,customer2,customer3 };
			foreach (Customer customer in customers)
			{
				Console.WriteLine("MÜşteri Adi: " + customer.Adi);
			}

		
			
			
		}
	}
}
