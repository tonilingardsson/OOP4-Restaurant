namespace RestaurantSystem
{
    // Private fields in this class
    public class Order
    {
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;
        // Allowing access to OrderId and TableNumber. Keep all fields together!
        public int OrderId => _orderId;
        public int TableNumber => _tableNumber;

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
 Console.WriteLine($"Order {_orderId}:");
    
    // Keep track of which items we've already printed
    List<string> processedItems = new List<string>();
    decimal total = 0;
    
    foreach (var item in _orderItems)
    {
        // Skip if we already counted this item
        if (processedItems.Contains(item.Name))
            continue;
            
        // Count how many of this item
        int quantity = 0;
        foreach (var orderItem in _orderItems)
        {
            if (orderItem.Name == item.Name)
                quantity++;
        }
        
        // Display and add to total
        Console.WriteLine($"{quantity} st {item.Name}");
        total += item.Price * quantity;
        
        // Mark as processed so we don't count it again
        processedItems.Add(item.Name);
    }
    
    Console.WriteLine($"Summa: {total:C}");
    Console.WriteLine($"Till bord nummer {_tableNumber}");
}
    }
}