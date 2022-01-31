using System;

namespace Composite.Task2
{
    public class LabelText : IComponent
    {
        private string _value;

        public LabelText(string value)
        {
            _value = value;
        }

        public string ConvertToString(int depth = 0)
        {
            return $"{new string(' ', depth)}<label value='{_value}'/>";
        }
    }
}
