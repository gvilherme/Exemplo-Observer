using BuilderExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploObserver.Observers.CheckoutObservers
{
    class SendSMSCheckoutObserver : CheckoutObserverActionChain
    {
        public override void DoAfterCheckoutBuildImplementation(Checkout checkout)
        {
            Console.WriteLine("SMS enviado.");
        }
    }
}
