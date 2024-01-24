using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    public class CompositeElement : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();
        public CompositeElement(string name) : base(name)
        {

        }
        public override void Add(DrawingElement component)
        {
            elements.Add(component);
        }
        public override void Remove(DrawingElement component)
        {
            elements.Remove(component);
        }
        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + "+ " + name);

            foreach (DrawingElement element in elements)
            {
                element.Display(indent + 2);
            }
        }

    }
}
