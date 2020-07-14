using BuilderExample.Builders;
using BuilderExample.Entities;
using System;
using System.Collections.Generic;

namespace BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SaleProduct> products = new List<SaleProduct>(new SaleProduct[] { new SaleProduct("item 1",1,400.0,2)
                , new SaleProduct("item 2", 2, 500.0, 2), new SaleProduct("item 3",3,600.0,1) });
            CheckoutBuilder checkoutBuilder = new CheckoutBuilder();
            checkoutBuilder.AddProducts(products).
                BuyerCNPJ("357,464,808-19").
                BuyerName("Braia").
                HaveTheObs("Testing.");
            var checkout = checkoutBuilder.Build();
            Console.WriteLine(checkout);
        }
    }
}
