﻿namespace MainTour.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine> ();
        public void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines.Where(p => p.Product?.ProductID == product.ProductID).FirstOrDefault();
            if (line == null)
            {
                {
                    Lines.Add(new CartLine
                    {
                        Product = product,
                        Quantity = quantity
                    });
                }
            }
            else
            {
                line.Quantity = quantity;
            }
        }
        public void RemoveLine(Product product) => Lines.RemoveAll(l => l.Product?.ProductID == product.ProductID);
        public decimal ComputeTotalVualue() => (decimal)Lines.Sum(e => e.Product?.ProductPridce*(1- e.Product?.PriceDiscount) * e.Quantity);

        public void Clear() =>Lines.Clear();    
    }
    //cartline 
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product? Product { get; set; } = new();
        public int Quantity { get; set; }

    }
}
