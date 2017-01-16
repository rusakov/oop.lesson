
using System;
using System.Collections.Generic;
using System.Threading;

namespace snake_new
{
	class MainClass
	{
		public static void Main(string[] args)
		{			

			//Отрисовка линей
			HorizontalLine lineRight = new HorizontalLine(0, 20, 0, '+');
			HorizontalLine lineLeft = new HorizontalLine(0, 20, 20, '+');

			VerticalLine lineUp = new VerticalLine(0, 20, 0, '&');
			VerticalLine lineDown = new VerticalLine(0, 20, 20, '&');

			lineRight.Drow();
			lineLeft.Drow();
			lineUp.Drow();
			lineDown.Drow();

			//Отрисовка змей
			Point p = new Point(2, 2, '*');
			Snake snake = new Snake(p, 2, Direction.RIGHT);
			snake.Drow();

			while (true) 
			{
				if (Console.KeyAvailable) 
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}

				Thread.Sleep(100);
				snake.Move();
			
			}
		}
	}
}
