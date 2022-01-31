using System;

namespace Composite.Task2
{
    public class InputText : IComponent
    {
        private string _name;
        private string _value;

        public InputText(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public string ConvertToString(int depth = 0)
        {
            return $"{new string(' ', depth)}<inputText name='{_name}' value='{_value}'/>";
        }
    }
}
