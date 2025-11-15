namespace RestaurantSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🍽️  RESTAURANGSYSTEM STARTAR 🍽️\n");

            // Create a new object of the Restaurant class
            Restaurant pizzeria = new Restaurant();

            // Add 4 different pizzas in the menu
            Console.WriteLine("--- Lägger till pizzor i menyn ---");
            pizzeria.AddToMenu(new MenuItem(1, "Margherita", 95.00m));
            pizzeria.AddToMenu(new MenuItem(1, "Pepperoni", 105.00m));
            pizzeria.AddToMenu(new MenuItem(1, "4 formaggi", 115.00m));
            pizzeria.AddToMenu(new MenuItem(1, "Marinara", 115.00m));

            // Write it to the console
            pizzeria.ShowMenu();

            // Create 3 new orders with at least two different pizzas per order
            Console.WriteLine("--- Skapa beställningar ---");

            Order order1 = new Order(
                new List<MenuItem>
                {
                    new MenuItem(1, "Margherita", 95.00m),
                    new MenuItem(2, "Pepperoni", 105.00m)
                },
                tableNumber: 2
            );
            pizzeria.CreateOrder(order1);

            Order order2 = new Order(
                new List<MenuItem>
                {
                    new MenuItem(3, "4 Formaggi", 115.00m),
                    new MenuItem(4, "Marinara", 125.00m)
                },
                tableNumber: 3
            );
            pizzeria.CreateOrder(order2);

            Order order3 = new Order(
                new List<MenuItem>
                {
                    new MenuItem(2, "Pepperoni", 105.00m),
                    new MenuItem(4, "Marinara", 125.00m)
                },
                tableNumber: 1
            );
            pizzeria.CreateOrder(order3);

            // Display all orders
            pizzeria.ShowOrders();

            // Display total orders in queue
            pizzeria.ShowOrderCount();
            Console.WriteLine();

            // Display next order in queue
            pizzeria.ShowNextOrder();

            // Handle an order
            Console.WriteLine("--- Hantera beställningar ---");
            pizzeria.HandleOrder();
            Console.WriteLine();

            // Display total orders in queue
            pizzeria.ShowOrderCount();
            Console.WriteLine();

            // Add a new order
            Console.WriteLine("--- Lägger till ny beställning ---");
            Order order4 = new Order(
                new List<MenuItem>
                {
                    new MenuItem(4, "Marinara", 125.00m),
                    new MenuItem(1, "Margherita", 95.00m)
                },
                tableNumber: 4
            );
            pizzeria.CreateOrder(order4);
            Console.WriteLine();

            // Display orders in queue
            pizzeria.ShowOrderCount();
            Console.WriteLine();

            // Handle two orders
            Console.WriteLine("--- Hantera två beställningar ---");
            pizzeria.HandleOrder();
            pizzeria.HandleOrder();
            Console.WriteLine();

            // Display total orders in queue
            pizzeria.ShowOrderCount();
            Console.WriteLine();

            // Display next order in queue
            pizzeria.ShowNextOrder();

             // Handle an order
            Console.WriteLine("--- Hantera sista beställningen ---");
            pizzeria.HandleOrder();
            Console.WriteLine();

            // Display total orders in queue
            pizzeria.ShowOrderCount();

            // Finish the application
            Console.WriteLine("\n🎉 SIMULERING KLAR! 🎉");
        }
    }
}