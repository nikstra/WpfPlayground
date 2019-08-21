using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CustomDialogs
{
    public class MarginValidationRule : ValidationRule
    {
        public double MinMargin { get; set; }
        public double MaxMargin { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return new ValidationResult(true, null);
        }
    }
}
