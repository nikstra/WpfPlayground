using System.Windows;
using System.Windows.Controls;

namespace UsernamePassword
{
    public class PasswordBoxExtensions : DependencyObject
    {
        public static readonly DependencyProperty IsEmptyProperty = DependencyProperty.RegisterAttached(
            nameof(SetIsEmpty).Substring(3), // Simpler than nameof(IsEmptyProperty).Replace("Property", string.Empty)
            typeof(bool),
            typeof(PasswordBoxExtensions),
            new PropertyMetadata(
                true,
                null, // new PropertyChangedCallback((d, e) => {}),
                new CoerceValueCallback((d, o) => (d as PasswordBox)?.SecurePassword.Length == 0)));

        public static void SetIsEmpty(UIElement target, bool value) =>
            target.SetValue(IsEmptyProperty, value);

        public static bool GetIsEmpty(UIElement target) =>
            (bool)target.GetValue(IsEmptyProperty);
    }
}
