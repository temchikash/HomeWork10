
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




            Console.WriteLine("HomeWork10");
            List<Team> teams = new List<Team>();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите название страны участвующей в Большой Гонке : ");
                teams.Add(new Team(Console.ReadLine()));
            }

            Game game = new Game(teams);
            game.ChoiceGame(new Beach());
            game.PlayGame();
            game.ChoiceGame(new Computer());
            game.PlayGame();
            game.ChoiceGame(new Fishing());
            game.PlayGame();
            game.ChoiceGame(new Mail());
            game.PlayGame();
            game.ChoiceGame(new Mouse());
            game.PlayGame();
            game.ChoiceGame(new Ocean());
            game.PlayGame();
            game.ChoiceGame(new Slide());
            game.PlayGame();
            game.Print();
            Console.ReadKey();
        }
    }
}
            


            
            
