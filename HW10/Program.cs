
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 10");
            ACipher aCipher = new ACipher();
            Console.WriteLine(aCipher.encode());
            Console.WriteLine(aCipher.decode());

            BCipher bCipher = new BCipher();
            Console.WriteLine(bCipher.encode());
            Console.WriteLine(bCipher.decode());
            Point point = new Point(3, 4, "синий", Figure.condition.invisible);
            Rectangle rectangle = new Rectangle(5, 8, 0, -3, "красный", Figure.condition.visibl);
            Circle circle = new Circle(15, 4, 6, "зеленый", Figure.condition.visibl);

            ((ISquare)circle).Square();
            ((ISquare)rectangle).Square();
            Console.ReadKey();
        }
    }
}
            


            
            
