using System;
using System.Collections; 

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Aggregation agg = new Aggregation("A aggregation");
            for (int i=0; i<5; i++) {
                agg.add(new Point($"Point {i}"));
            }

            agg.add(new Line("I say yes"));
            agg.add(new Circle("You say no"));
            agg.rotate();
        }
    }

    class Figure
    {
        public string name {get;set;}
        public Figure(string name) {
            this.name = name;
        }

        public void move() {
            Console.WriteLine($"You have moved {this.name}");
        }

        public void rotate() {
            Console.WriteLine($"You have rotated {this.name}");
        }
    }

    class Point:Figure
    {
        public Point(string name):base(name) {
        }
    }

    class Line:Figure
    {
        public Line(string name):base(name) {
        }
    }

    class Circle:Figure
    {
        public Circle(string name):base(name) {
        }
    }

    class Aggregation:Figure
    {
        public ArrayList figures;
        public Aggregation(string name):base(name) {
            figures = new ArrayList();
        }

        public void add(Figure f) {
            this.figures.Add(f);
        }

        public new void rotate() {
            foreach(Figure e in this.figures) {
                e.rotate();
            }
        }

        public new void move() {
            foreach(Figure e in this.figures) {
                e.move();
            }
        }
    }
}
