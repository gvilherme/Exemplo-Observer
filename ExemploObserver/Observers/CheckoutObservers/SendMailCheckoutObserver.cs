using BuilderExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploObserver.Observers.CheckoutObservers
{
    class SendMailCheckoutObserver : CheckoutObserverActionChain
    {
        public SendMailCheckoutObserver(CheckoutObserverActionChain checkoutObserverActionChain = null
            , IEnumerable<CheckoutObserver> checkoutObservers = null) : base(checkoutObserverActionChain, checkoutObservers)
        {

        }
        public override void DoAfterCheckoutBuildImplementation(Checkout checkout)
        {
            Console.WriteLine("E-mail enviado.");
        }
    }
}
