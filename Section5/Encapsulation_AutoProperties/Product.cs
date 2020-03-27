using System.Globalization;

namespace Encapsulation_AutoProperties
{
    class Product
    {
        private string name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public Product()
        {
        }

        public Product(string name, double price, int stockQuantity)
        {
            this.name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        // O nome possui uma lógica particular daí não puder ser utilizado as auto properties
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    name = value;
                }
            }
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
