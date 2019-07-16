using Foundation;
using System;
using UIKit;

namespace BadgeViewDemo
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton197_TouchUpInside(UIButton sender)
        {
            BadgeView.iOS.LFBadge badge = new BadgeView.iOS.LFBadge();
            badge.Count = "12";
            badge.NeedDisappearEffects = true;
            badge.ClearBlock = new Action(()=> { });
            badge.AddToView(sender);
        }
    }
}