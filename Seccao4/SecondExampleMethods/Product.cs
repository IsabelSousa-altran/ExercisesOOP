using System.Globalization;

namespace SecondExampleMethods
{
    class Product
    {
        public string Name;
        public double Price;
        public int StockQuantity;

        public double TotalValueInStock()
        {
            return Price * StockQuantity;
        }

        public override string ToString()
        {
            return Name 
                + ", $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + StockQuantity
                + " unitys, Total: $ "
                + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
