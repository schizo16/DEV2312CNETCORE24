using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    abstract class Shape
    {
        protected float radius, length, width;
        public abstract float Area();
        public abstract float Circumference();
    }
}
