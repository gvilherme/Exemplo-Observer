using BuilderExample.Entities;
using ExemploObserver.Extensions;
using System.Collections.Generic;

namespace ExemploObserver.Observers.CheckoutObservers
{
    abstract class CheckoutObserverActionChain : CheckoutObserver
    {
        private CheckoutObserverActionChain NextCheckoutObserver { get; set; }
        private List<CheckoutObserver> OtherCheckoutObservers { get; set; }
        public CheckoutObserverActionChain(CheckoutObserverActionChain checkoutObserver = null, IEnumerable<CheckoutObserver> otherCheckoutObservers = null)
        {
            NextCheckoutObserver = checkoutObserver;
            if (!otherCheckoutObservers.IsNull())
            {
                OtherCheckoutObservers = new List<CheckoutObserver>(otherCheckoutObservers);
            }            
        }
        public void DoAfterCheckoutBuild(Checkout checkout)
        {
            ExecuteChain(checkout);
            if (!OtherCheckoutObservers.IsNull())
            {
                OtherCheckoutObservers.ForEach(OCO => OCO.DoAfterCheckoutBuildImplementation(checkout));
            }
        }

        private void ExecuteChain(Checkout checkout)
        {
            if (!NextCheckoutObserver.IsNull())
            {
                DoAfterCheckoutBuildImplementation(checkout);
                NextCheckoutObserver.ExecuteChain(checkout);
                return;
            }
            DoAfterCheckoutBuildImplementation(checkout);
        }

        public abstract void DoAfterCheckoutBuildImplementation(Checkout checkout);
    }
}
