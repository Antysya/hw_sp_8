using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace hw_sp_8
{

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<IMovement> sky = new List<IMovement>();
            ConsoleColor[] colors = { ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Blue };

            foreach (ConsoleColor color in colors)
            {
                sky.Add(new FirCross(rand.Next(WindowWidth / 2 - 40, WindowWidth / 2 + 40), color));
                sky.Add(new FirFlower(rand.Next(WindowWidth / 2 - 40, WindowWidth / 2 + 40), color));
                sky.Add(new AirBalloon(rand.Next(WindowWidth / 2 - 40, WindowWidth / 2 + 40), color));
                sky.Add(new Parachutists3(rand.Next(WindowWidth / 2 - 40, WindowWidth / 2 + 40), color));
            };

            while (true)
            {
                IMovement start = sky[rand.Next(0, sky.Count - 1)];
                for (int i = 0; i < 33; i++)
                {
                    start.Draw();
                    start.Move();
                    SetCursorPosition(0, 0);
                    Thread.Sleep(100);
                    Clear();
                }
            }
        }
    }
}
