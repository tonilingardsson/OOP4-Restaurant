namespace RestaurantSystem
{
    // Private fields in this class
    public class Order
    {
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatic creation of id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        // Method to display the order
        public void DisplayOrder()
        {
         
            Console.WriteLine($"Order #{_orderId} - Bord #{_tableNumber}:");
            foreach (var orderItem in _orderItems)
            {
                Console.WriteLine($" - {orderItem}");
            }
        }

        // Allowing access to OrderId and TableNumber
        public int OrderId => _orderId;
        public int TableNumber => _tableNumber;
    }
}