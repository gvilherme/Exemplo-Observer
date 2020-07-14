using BuilderExample.Entities;

namespace ExemploObserver.Observers.CheckoutObservers
{
    internal interface CheckoutObserver
    {
        public abstract void DoAfterCheckoutBuildImplementation(Checkout checkout);
    }
}