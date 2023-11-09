using RevenueCat;

namespace Tonestro.Maui.RevenueCat.iOS.UsageChecker;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window { get; set; }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        Window = new UIWindow(UIScreen.MainScreen.Bounds);

        RCPurchases.DebugLogsEnabled = true;
        RCPurchases.ConfigureWithAPIKey("theapikey");
        Console.WriteLine($"Bound RevenueCat iOS SDK Version: {RCPurchases.FrameworkVersion}");

        var vc = new UIViewController();

        vc.View!.AddSubview(new UILabel(Window!.Frame)
        {
            BackgroundColor = UIColor.SystemBackground,
            TextAlignment = UITextAlignment.Center,
            Text = $"RevenueCat iOS SDK Version: {RCPurchases.FrameworkVersion}",
            AutoresizingMask = UIViewAutoresizing.All,
        });
        Window.RootViewController = vc;
        // make the window visible
        Window.MakeKeyAndVisible();

        return true;
    }
}