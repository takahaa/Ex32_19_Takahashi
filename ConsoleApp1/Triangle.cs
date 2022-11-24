using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractSample
{
    /// <summary>
    /// 三角形
    /// </summary>

    class Triangle : Surface
    {
        readonly public float side1;
        readonly public float side2;
        readonly public float side3;
        public Triangle(float side1 = 0, float side2 = 0, float side3 = 0)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override float GetSurface()
        {
            //ヘロンの公式
            return (side1 + side2 + side3) / 2;
        }
        public override float GetCircumference()
        {
            return side1 + side2 + side3;
        }

    }
}
