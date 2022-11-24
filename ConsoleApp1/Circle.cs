using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractSample
{
    /// <summary>
    /// 円
    /// </summary>
    
    class Circle : Surface
    {
        readonly public float radius;
        public Circle(float radius = 0)
        {
            this.radius = radius;
        }
        public override float GetSurface()
        {
            return radius * radius;
        }
        public override float GetCircumference()
        {
            return radius * 2 * (float)Math.PI;
        }

    }
}
