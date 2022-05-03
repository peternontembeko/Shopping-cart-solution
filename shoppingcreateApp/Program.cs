using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace shoppingcreateApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            ShoppingCartItem item = new ShoppingCartItem("Laptop",3500);
            cart.AddShoppingItem(item);

            item = new ShoppingCartItem("Washing machine", 6700);
            cart.AddShoppingItem(item);

            item = new ShoppingCartItem("Microwave", 2500);
            cart.AddShoppingItem(item);


            List<ShoppingCartItem> items = cart.CartList();
            // [{ItemName: "XBox", Price: 2500},{ItemName: "XBox", Price: 2500},{ItemName: "XBox", Price: 2500}]
            //items.ItemName for name of item
            //items.Price for price
            foreach (ShoppingCartItem item_ in items)
            {
                Console.WriteLine(item_.ItemName+" "+ item_.Price);

            }
            //Console.WriteLine(items);

            Console.WriteLine("Sub total: "+cart.GetSubTotal());

            Console.WriteLine("With VAT :"+cart.Vat());


        }
    }
}
