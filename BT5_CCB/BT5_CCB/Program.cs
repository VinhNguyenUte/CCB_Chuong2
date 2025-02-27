using System.Drawing;

internal class Program
{
    enum PointColor
    {
        LightBlue,
        BloodRed,
        Gold
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointColor Color { get; set; }
        public Point (int x, int y, PointColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public void PrintPointInfo(bool showColor = true)
        {
            Console.WriteLine("Toạ độ X: " + X);
            Console.WriteLine("Toạ độ Y: " + Y);
            if (showColor)
            {
                Console.WriteLine("Màu: " + Color);
            }
        }
    }

    class Rectangle
    {
        public Point ul { get; set; }
        public Point br { get; set; }

        public PointColor rcolor { get; set; }

        public Rectangle (Point ul, Point br, PointColor rcolor)
        {
            this.ul = ul;
            this.br = br;
            this.rcolor = rcolor;
        }

        public void PrintRectangleInfo(bool showColor = true)
        {
            Console.WriteLine("Toạ độ upper-left : " + ul.X+" , "+ul.Y);
            Console.WriteLine("Toạ độ bottom-right: " + br.X + " , "+br.Y);
            if (showColor)
            {
                Console.WriteLine("Màu: " + rcolor);
            }
        }
    } 
    private static void Main(string[] args)
    {
        Point O = new Point(2, 1, PointColor.LightBlue);

        O.PrintPointInfo();
        O.PrintPointInfo(false);

        Point A = new Point(6, 3, PointColor.LightBlue);

        Rectangle bien_223 = new Rectangle(O, A, PointColor.Gold);
        bien_223.PrintRectangleInfo();
        bien_223.PrintRectangleInfo(false);
    }
}