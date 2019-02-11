using System;

namespace Lesson25
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Constructor)]
    class GeoAttribute : Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GeoAttribute() { }

        public GeoAttribute(int x, int y)
        {
            // Проверка входных данных.

            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{X}; {Y}]";
        }
    }
}
