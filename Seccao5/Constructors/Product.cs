﻿using System.Globalization;

namespace Constructors
{
    class Product
    {
        public string Name; 
        public double Price; 
        public int StockQuantity;

        public Product(string name, double price, int stockQuantity)
        {
            Name = name;
            Price = price;
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
