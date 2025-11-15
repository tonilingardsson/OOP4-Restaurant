namespace RestaurantSystem
{
    // Class with auto-implemented properties
    public class MenuItem
    {
        // Every MenuItem needs to have id, name and price
        public int Id {get; set;}
        public string Name {get;set;}
        public decimal Price {get;set;}

        public MenuItem(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        // ToString() makes it possible to print with CW
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }
}