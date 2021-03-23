using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class Product
    {
       private System.Collections.Generic.LinkedList<string> parts;
        public Product() { parts = new System.Collections.Generic.LinkedList<string>(); }
        public void Add(string part)
        {
            //Add parts
            parts.AddLast(part);
        }
        public string Show()
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            result.AppendLine("Product components are :");
            foreach (string part in parts)
                result.AppendLine(part);

            return result.ToString();
        }
    }
}