using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Statue - King Peguin", "P001", 25, 1);
        Product product2 = new Product("Sweater - Black/White", "P002", 50, 2);
        Product product3 = new Product("Orca Repellent", "P003", 25, 10);
        Product product4 = new Product("Scarf - Red/White", "P003", 10, 3);

        // Create customers with addresses
        Address address1 = new Address("123 Pigeon Poop Lane", "Eastport", "04631", "ME", "USA");
        Customer customer1 = new Customer("Penguin Bill Johnson", address1);

        Address address2 = new Address("Casilla 56", "Correo Puerto Williams Cabo de Hornos", "6350000", "Magallanes", "Chile"); 
        Customer customer2 = new Customer("Jaime Moreno", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display results
        Console.Clear();
        Console.WriteLine("Program 2: Encapsulation with Online Ordering");
        Console.WriteLine("---------------------------------------------------------------------------------");
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Order 1:                                                                         ");
        Console.ResetColor();
        Console.WriteLine("--------------------------------- Packing Label ---------------------------------");
        order1.DisplayPackingLabel();
        Console.Write("Total Price: $");
        order1.DisplayCostOfOrder();
        Console.WriteLine();
        Console.WriteLine("-------------------------------- Shipping Label --------------------------------");
        customer1.DisplayShippingLabel();
        
        Console.WriteLine();

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Order 2:                                                                         ");
        Console.ResetColor();
        Console.WriteLine("--------------------------------- Packing Label ---------------------------------");
        order2.DisplayPackingLabel();
        Console.Write("Total Price: $");
        order2.DisplayCostOfOrder();
        Console.WriteLine();
        Console.WriteLine("-------------------------------- Shipping Label --------------------------------");
        customer2.DisplayShippingLabel();
        Console.Write("Total Price: $");
        order2.DisplayCostOfOrder();
    
    }
}