using BuilderExample.Entities;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExample.Builders
{
    class CheckoutBuilder
    {
        public List<SaleProduct> CheckoutProducts { get; private set; }
        public double CheckoutTotalValue { get; private set; }
        public string CheckoutBuyerName { get; private set; }
        public string CheckoutBuyerCNPJ { get; private set; }
        public string Obs { get; private set; }

        public CheckoutBuilder AddProducts(IEnumerable<SaleProduct> products)
        {
            if (CheckoutProducts == null)
            {
                CheckoutProducts = new List<SaleProduct>(products);
                return this;
            }
            CheckoutProducts.AddRange(products);
            return this;
        }

        private double CheckoutValue()
        {
            CheckoutTotalValue = 0;
            CheckoutProducts.ForEach(P => CheckoutTotalValue += P.Unit_Value * P.Qnt);
            return CheckoutTotalValue;
        }

        public CheckoutBuilder BuyerName(string buyerName)
        {
            CheckoutBuyerName = buyerName;
            return this;
        }
        public CheckoutBuilder BuyerCNPJ(string buyerCNPJ)
        {
            CheckoutBuyerCNPJ = buyerCNPJ;
            return this;
        }
        public CheckoutBuilder HaveTheObs(string obs = "Sem Observações.")
        {
            Obs = obs;
            return this;
        }
        public Checkout Build()
        {
            return new Checkout(CheckoutProducts, CheckoutValue(), CheckoutBuyerName, CheckoutBuyerCNPJ, CheckoutTaxes(), Now(), Obs);
        }

        private double CheckoutTaxes()
        {
            return CheckoutTotalValue * 0.05;
        }

        private Instant Now()
        {
            return SystemClock.Instance.GetCurrentInstant();
        }
    }
}
