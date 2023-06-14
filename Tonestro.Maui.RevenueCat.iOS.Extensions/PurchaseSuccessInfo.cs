using RevenueCat;

namespace Tonestro.Maui.RevenueCat.iOS.Extensions
{
    public struct PurchaseSuccessInfo
    {
        public RCStoreTransaction Transaction { get; }
        public RCCustomerInfo CustomerInfo { get; }

        public PurchaseSuccessInfo(RCStoreTransaction transaction, RCCustomerInfo customerInfo)
        {
            Transaction = transaction;
            CustomerInfo = customerInfo;
        }
    }
}
