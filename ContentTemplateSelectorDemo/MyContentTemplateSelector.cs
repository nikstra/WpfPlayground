using System.Windows;
using System.Windows.Controls;

namespace ContentTemplateSelectorDemo
{
    public class MyContentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate BorderTemplate { get; set; }
        public DataTemplate TwoTextBlockTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is string value)
            {
                if (value == "Border Template String")
                {
                    return BorderTemplate;
                }
                else if (value == "Two TextBlock Template String")
                {
                    return TwoTextBlockTemplate;
                }
            }

            return base.SelectTemplate(item, container);
        }
    }
}
