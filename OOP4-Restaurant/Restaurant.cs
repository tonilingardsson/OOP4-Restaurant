namespace RestaurantSystem
{
    public class RestaurantSystem
    {
        private List<MenuItem> _menu;
        private Queue<Order> _orderQueue;

        public Restaurant()
        {
            _menu = new List<MenuItem>();
            _orderQueue = new Queue<Order>();
        }

        // Add a new dish in the menu
        public void AddToMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"✓ Lade till '{menuItem.Name}' i menyn");
        }

        // Write out all the dishes on the menu
        public void ShowMenu()
        {
            Console.WriteLine("\n===== MENY =====");
            if (_menu.Count == 0)
            {
                Console.WriteLine("Meny är tom...");
            }
            else
            {
                foreach (var dish in _menu)
                {
                    Console.WriteLine($"{dish.Id} - {dish}");
                }
            }
            Console.WriteLine("================\n");
        }

        // Add a new order in queue
        public void CreateOrder(Order order)
        {
            _orderQueue.Enqueue(order);
            Console.WriteLine($"✓ Ny beställning #{order.OrderId} tillagd i kön (Bord {order.TableNumber})");
        }

        // Handles the first order in the queue and deletes from the queue
        public void HandleOrder()
        {
            if (_orderQueue.Count == 0)
            {
                Console.WriteLine("⚠ Inga beställningar att hantera");
                return;            
            }

            Order HandleOrder = _orderQueue.Dequeue();
            Console.WriteLine($"✓ Hanterade beställning #{handledOrder.OrderId} från Bord {handledOrder.TableNumber}");
        }

        // Writes out all the orders in queue
        public void ShowOrders()
        {
            Console.WriteLine("\n===== ALLA BESTÅLLNINGAR I KÖN =====");
            if (_orderQueue.Count() == 0)
            {
                Console.WriteLine("Kön är tom...");
            }
            else
            {
                foreach (var order in _orderQueue)
                {
                    order.DisplayOrder();
                    Console.WriteLine();
                }
            }
            Console.WriteLine("====================================\n");
        }

        // Writes the order next in Queue
        public void ShowNextOrder()
        {
            Console.WriteLine("\n===== NÄSTA BESTÄLLNING =====");
            if (_orderQueue == 0)
            {
                System.Console.WriteLine("Inga beställningar i kön...");
            }
            else
            {
                Order nextOrder = _orderQueue.Peek();
                nextOrder.DisplayOrder();
            }
            Console.WriteLine("====================================\n");
        }

        // Writes down the number of orders in queue
        public void ShowOrderCount()
        {
            Console.WriteLine($"📊 Antal beställningar i kön: {_orderQueue.Count}");
        }
    }
}