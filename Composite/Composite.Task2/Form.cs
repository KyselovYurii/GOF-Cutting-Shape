using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Task2
{
    public class Form : IComponent
    {
        private readonly string _name;
        private readonly List<IComponent> _components = new List<IComponent>();

        public Form(String name)
        {
            _name = name;
        }

        public void AddComponent(IComponent component)
        {
            _components.Add(component);
        }

        public string ConvertToString(int depth = 0)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{new string(' ', depth)}<form name='{_name}'>");

            var newDepth = depth + 1;
            foreach (var component in _components)
            {
                sb.AppendLine(component.ConvertToString(newDepth));
            }

            sb.Append($"{new string(' ', depth)}</form>");

            return sb.ToString();
        }
    }
}