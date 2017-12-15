using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Class
{
    public class Stock
    {
        private int id = 0;
        private int quantity = 0;
        private bool active;
        private int fk_Product = 0;
        private char name;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public bool Active
        {
            get => active;
            set => active = value;
        }

        public int Fk_Product
        {
            get => fk_Product;
            set => fk_Product = value;
        }

        public char Name
        {
            get => name;
            set => name = value;
        }

        public Stock(int id, int quantity, bool active, int fk_Product, char name)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Active = active;
            this.Fk_Product = fk_Product;
            this.Name = name;
        }
    }
}
