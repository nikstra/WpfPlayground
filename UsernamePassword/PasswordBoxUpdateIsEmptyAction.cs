using System.Windows.Controls;
using Microsoft.Xaml.Behaviors;

namespace UsernamePassword
{
    public class PasswordBoxUpdateIsEmptyAction : TriggerAction<PasswordBox>
    {
        protected override void Invoke(object parameter)
        {
            bool isEmpty = AssociatedObject?.SecurePassword.Length == 0;
            AssociatedObject?.SetCurrentValue(PasswordBoxExtensions.IsEmptyProperty, isEmpty);

            // An alternate way of setting an attached property.
            // PasswordBoxExtensions.SetIsEmpty(AssociatedObject, isEmpty);
        }
    }
}
