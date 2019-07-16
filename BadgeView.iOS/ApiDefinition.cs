using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace BadgeView.iOS
{

    // @interface LFBadge : UIView
    [BaseType(typeof(UIView))]
    interface LFBadge
    {
        // @property (nonatomic, strong) UIColor * badgeCorlor;
        [Export("badgeCorlor", ArgumentSemantic.Strong)]
        UIColor BadgeCorlor { get; set; }

        // @property (nonatomic, strong) UILabel * lbText;
        [Export("lbText", ArgumentSemantic.Strong)]
        UILabel LbText { get; set; }

        // @property (nonatomic) BOOL needDisappearEffects;
        [Export("needDisappearEffects")]
        bool NeedDisappearEffects { get; set; }

        // @property (assign, nonatomic) NSInteger maxCount;
        [Export("maxCount")]
        nint MaxCount { get; set; }

        // @property (copy, nonatomic) NSString * count;
        [Export("count")]
        string Count { get; set; }

        // @property (assign, nonatomic) CGFloat redDotSize;
        [Export("redDotSize")]
        nfloat RedDotSize { get; set; }

        // @property (assign, nonatomic) CGFloat maxDistance;
        [Export("maxDistance")]
        nfloat MaxDistance { get; set; }

        // @property (nonatomic) UIEdgeInsets edgeInsets;
        [Export("edgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets EdgeInsets { get; set; }

        // @property (nonatomic) LFBadgeType type;
        [Export("type", ArgumentSemantic.Assign)]
        LFBadgeType Type { get; set; }

        // @property (copy, nonatomic) void (^clearBlock)();
        [Export("clearBlock", ArgumentSemantic.Copy)]
        Action ClearBlock { get; set; }

        // -(void)addToView:(UIView *)superview;
        [Export("addToView:")]
        void AddToView(UIView superview);

        // -(void)addToTabBarItem:(UITabBarItem *)tabBarItem;
        [Export("addToTabBarItem:")]
        void AddToTabBarItem(UITabBarItem tabBarItem);

        // -(void)addToBarButtonItem:(UIBarButtonItem *)barButtonItem;
        [Export("addToBarButtonItem:")]
        void AddToBarButtonItem(UIBarButtonItem barButtonItem);

        // -(void)clearBadgeConstraint;
        [Export("clearBadgeConstraint")]
        void ClearBadgeConstraint();
    }
}
    