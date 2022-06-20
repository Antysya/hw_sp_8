using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_sp_8
{
    interface IMovement
    {
        void Draw();
        void Move();
    }

    class Sky : IMovement
    {
        protected int x;
        protected int y;
        protected ConsoleColor Color;
        public virtual void Draw() { }
        public virtual void Move() { }
    }

    class FirCross : Sky, IMovement
    {
        public FirCross(int _x, ConsoleColor color)
        {
            Color = color;
            x = _x;
            y = WindowHeight;
        }
        public override void Draw()
        {
            ForegroundColor = Color;
            if (y == WindowHeight / 2 - 5)
            {
                SetCursorPosition(x, y);
                WriteLine("*   *");
                SetCursorPosition(x, y + 1);
                WriteLine(" * * ");
                SetCursorPosition(x, y + 2);
                WriteLine("*****");
                SetCursorPosition(x, y + 3);
                WriteLine(" * * ");
                SetCursorPosition(x, y + 4);
                WriteLine("*   *");
            }
            else if (y >= WindowHeight / 2 - 5)
            {
                SetCursorPosition(x + 2, y + 2);
                WriteLine("*");
                SetCursorPosition(x + 2, y + 3);
                WriteLine("*");
            }
        }

        public override void Move()
        {
            if (y == 0)
                y = WindowHeight;
            else
                y--;
        }
    }

    class FirFlower : Sky, IMovement
    {
        public FirFlower(int _x, ConsoleColor color)
        {
            Color = color;
            x = _x;
            y = WindowHeight;
        }
        public override void Draw()
        {
            ForegroundColor = Color;

            if (y == WindowHeight / 2 - 9)
            {
                SetCursorPosition(x, y);
                WriteLine("  *****  ");
                SetCursorPosition(x, y + 1);
                WriteLine(" *     * ");
                SetCursorPosition(x, y + 2);
                WriteLine("*  ***  *");
                SetCursorPosition(x, y + 3);
                WriteLine("* *   * *");
                SetCursorPosition(x, y + 4);
                WriteLine(" *  *** *");
                SetCursorPosition(x, y + 5);
                WriteLine(" * *  * *");
                SetCursorPosition(x, y + 6);
                WriteLine(" * ***  *");
                SetCursorPosition(x, y + 7);
                WriteLine(" *     * ");
                SetCursorPosition(x, y + 8);
                WriteLine("  *****  ");
            }
            else if (y > WindowHeight / 2 - 9)
            {
                SetCursorPosition(x + 2, y + 2);
                WriteLine("*");
                SetCursorPosition(x + 2, y + 3);
                WriteLine("*");
                SetCursorPosition(x + 2, y + 4);
                WriteLine("*");
            }
        }
        public override void Move()
        {
            if (y == 0)
                y = WindowHeight;
            else
                y--;
        }
    }

    class AirBalloon : Sky, IMovement
    {
        public AirBalloon(int _x, ConsoleColor color)
        {
            Color = color;
            x = _x;
            y = WindowHeight;
        }

        public override void Move()
        {
            if (y == 0)
                y = WindowHeight;
            else
                y--;
        }

        public override void Draw()
        {
            ForegroundColor = Color;
            if (y > 0)
            {
                SetCursorPosition(x + 2, y);
                WriteLine("  oo ");
                SetCursorPosition(x + 2, y + 1);
                WriteLine(" oooo");
                SetCursorPosition(x + 2, y + 2);
                WriteLine("oooooo");
                SetCursorPosition(x + 2, y + 3);
                WriteLine(" oooo");
                SetCursorPosition(x + 2, y + 4);
                WriteLine("  \\/");
                SetCursorPosition(x + 2, y + 5);
                WriteLine("  |");

            }
        }
    }

    class Parachutists3 : Sky, IMovement
    {
        public Parachutists3(int _x, ConsoleColor color)
        {
            Color = color;
            x = _x;
            y = WindowHeight;
        }
        public override void Move()
        {
            if (y == 30)
                y = 0;
            else
                y++;
        }

        public override void Draw()
        {
            ForegroundColor = Color;

            SetCursorPosition(x + 1, y);
            WriteLine("@@@@@@@");
            SetCursorPosition(x + 1, y + 1);
            WriteLine("^^^^^^^");

            for (int i = 1; i < 5; i++)
            {
                SetCursorPosition(x + i, y + i + 1);
                WriteLine("@");
                SetCursorPosition(x + i, y + i + 2);
                WriteLine("^");
                SetCursorPosition(x - i + 8, y + i + 1);
                WriteLine("@");
                SetCursorPosition(x - i + 8, y + i + 2);
                WriteLine("^");
            }
        }
    }
}

