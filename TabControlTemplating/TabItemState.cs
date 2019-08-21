#define LimitToTabItem // Define to attach IsHighlighted only to TabItem controls.

using System.Windows;

namespace TabControlTemplating
{
    // https://markheath.net/post/wpf-templates-attached-properties
    public class TabItemState : DependencyObject
    {
        public static readonly DependencyProperty IsHighlightedProperty = DependencyProperty.RegisterAttached(
            nameof(SetIsHighlighted).Substring(3), // "IsHighlighted",
            typeof(bool),
            typeof(TabItemState),
            new PropertyMetadata(false));

#if LimitToTabItem // Attach the property only to controls of type TabItem.
        public static void SetIsHighlighted(System.Windows.Controls.TabItem target, bool value) =>
            target.SetValue(IsHighlightedProperty, value);

        public static bool GetIsHighlighted(System.Windows.Controls.TabItem target) =>
            (bool)target.GetValue(IsHighlightedProperty);

#else // Attach the property to any control type.
        public static void SetIsHighlighted(DependencyObject target, bool value) =>
            target.SetValue(IsHighlightedProperty, value);

        public static bool GetIsHighlighted(DependencyObject target) =>
            (bool)target.GetValue(IsHighlightedProperty);
#endif
    }

}
