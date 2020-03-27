using System.Globalization;

namespace ThisExample
{
    class Product
    {
        public string Name;
        public double Price;
        public int StockQuantity;

        public Product()
        {
            StockQuantity = 10;
        }

        public Product(string name, double price) :this()
        {
            Name = name;
            Price = price;
        }

        public Product(string name, double price, int stockQuantity) : this(name, price)
        {
            StockQuantity = stockQuantity;
        }

        public double StockTotalValue()
        {
            return Price * StockQuantity;
        }

        public void AddProducts(int quantity)
        {
            StockQuantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            StockQuantity -= quantity;
        }

        public override string ToString()
        {
            return Name
                + ", $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + StockQuantity + " unitys, Total: $ "
                + StockTotalValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
