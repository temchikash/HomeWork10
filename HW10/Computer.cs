using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Computer : IStrategy
    {
        static Random random = new Random();
        public void Play(List<Team> teams)
        {
            Console.WriteLine("Начинается лучший в мире данк-контест");
            for (int i = 0; i < teams.Count; i++)
            {
                int rand = random.Next(1, 8);
                Console.WriteLine($"Команда {teams[i].Name} получила {rand} очков");
                teams[i].Ball += rand;
            }
            Console.WriteLine();
        }
    }
}
