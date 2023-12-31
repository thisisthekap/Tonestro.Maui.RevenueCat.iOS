using RevenueCat;

namespace Tonestro.Maui.RevenueCat.iOS.UsageChecker;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window { get; set; }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        // create a new window instance based on the screen size
        Window = new UIWindow(UIScreen.MainScreen.Bounds);

        // create a UIViewController with a single UILabel
        var vc = new UIViewController();
        vc.View!.AddSubview(new UILabel(Window!.Frame)
        {
            BackgroundColor = UIColor.SystemBackground,
            TextAlignment = UITextAlignment.Center,
            Text = "Hello, iOS!",
            AutoresizingMask = UIViewAutoresizing.All,
        });
        Window.RootViewController = vc;

        // make the window visible
        Window.MakeKeyAndVisible();

        RCPurchases.DebugLogsEnabled = true;
        RCPurchases.ConfigureWithAPIKey("theapikey");
        Console.WriteLine($"Bound RevenueCat iOS SDK Version: {RCPurchases.FrameworkVersion}");

        return true;
    }
}