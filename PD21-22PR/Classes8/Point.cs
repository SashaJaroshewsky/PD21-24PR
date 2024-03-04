using System;

namespace Classes
{
    class Point
    {
        private int x, y;
        private string name;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }
        
        public string Name
        {
            get { return name; }
        }

        public Point(int x, int y)
        {
            Console.WriteLine("Конструктор з двома параметрами.");
            this.x = x;
            this.y = y;
        }

        public Point(string name)
            : this(40, 25)
        {
            Console.WriteLine("Конструктор з одним параметром.");
            this.name = name;
        }
    }
}
