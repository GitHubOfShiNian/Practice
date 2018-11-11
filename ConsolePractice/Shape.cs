using System;

namespace ConsolePractice
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
        public interface PaintCost
        {
            int getCost(int area);
        }
        class Rectangle : Shape, PaintCost
        {
            public int getArea()
            {
                return (width * height);
            }
            public int getCost(int area)
            {
                return area * 70;
            }
        }
        class RectangleTester
        {
            static void Main(string[] args)
            {
                Rectangle Rect = new ConsolePractice.Shape.Rectangle();
                int area;
                Rect.setWidth(5);
                Rect.setHeight(7);
                area = Rect.getArea();
                Console.WriteLine("总面积:{0}", Rect.getCost(area));
                Console.WriteLine("油漆总成本：${0}", Rect.getCost(area));
                Console.ReadKey();
            }
        }
    }
}
