using NodaTime;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExample.Entities
{
    class Checkout
    {
        public List<SaleProduct> Products { get; private set; }
        public double FinalValue { get; private set; }
        public String BuyerName { get; private set; }
        public String BuyerCnpj { get; private set; }
        public double Taxes { get; private set; }
        public Instant Date { get; set; }
        public String Obs { get; private set; }

        public Checkout(List<SaleProduct> products, double finalValue, string buyerName, string buyerCnpj, double taxes, Instant date, String obs = "Sem Observações.")
        {
            Products = products ?? throw new ArgumentNullException(nameof(products));
            FinalValue = finalValue;
            BuyerName = buyerName ?? throw new ArgumentNullException(nameof(buyerName));
            BuyerCnpj = buyerCnpj ?? throw new ArgumentNullException(nameof(buyerCnpj));
            Taxes = taxes;
            Date = date;
            Obs = obs;
        }

        public override string ToString()
        {
            return $"Comprador: {BuyerName}\nProdutos:\n{ProductsList()}Valor total: {FinalValue}\nImpostos: {Taxes}\nData: {Date}\nObs: {Obs}";
        }

        private string ProductsList()
        {
            string text = "";
            Products.ForEach(P => text += $"{P.ProductName}, Preço: {P.Unit_Value}, Quantidade: {P.Qnt}\n");
            return text;
        }
    }
}
