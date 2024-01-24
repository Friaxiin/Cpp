using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    public abstract class DrawingElement
    {
        protected string name;

        public DrawingElement(string name)
        {
            this.name = name;
        }

        public abstract void Display(int indent);
        public abstract void Add(DrawingElement component);
        public abstract void Remove(DrawingElement component);
    }
}
