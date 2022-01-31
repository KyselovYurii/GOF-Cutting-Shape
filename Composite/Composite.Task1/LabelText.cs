using System;

namespace Composite.Task1
{
    public class LabelText
    {
        private string _value;

        public LabelText(string value)
        {
            _value = value;
        }

        public string ConvertToString()
        {
            return $"<label value='{_value}'/>";
        }
    }
}
