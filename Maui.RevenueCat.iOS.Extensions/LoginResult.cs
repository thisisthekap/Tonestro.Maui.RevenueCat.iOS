using RevenueCat;

namespace Maui.RevenueCat.iOS.Extensions;

public struct LoginResult
{
    public RCCustomerInfo CustomerInfo { get; }
    public bool Created { get; }

    public LoginResult(RCCustomerInfo customerInfo, bool created)
    {
        CustomerInfo = customerInfo;
        Created = created;
    }
}