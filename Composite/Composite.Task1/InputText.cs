using System;

namespace Composite.Task1
{
    public class InputText
    {
        private string _name;
        private string _value;

        public InputText(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public string ConvertToString()
        {
            return $"<inputText name='{_name}' value='{_value}'/>";
        }
    }
}
