
using System;
using System.Collections.Generic;
using System.Threading;

namespace snake_new
{
	class MainClass
	{
		static void Main(string[] args)
		{

			VerticalLine vl = new VerticalLine(0, 10, 5, '%');
			Draw(vl);

			Point p1 = new Point(4, 5, '*');
			Figure fSnake = new Snake(p1, 4, Direction.RIGHT);
			Draw(fSnake);
			Snake snake1 = (Snake)fSnake;

			HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');
			List<Figure> figures = new List<Figure>();

			figures.Add(fSnake);
			figures.Add(vl);
			figures.Add(hl);

			foreach (var f in figures) {
				f.Draw();
			}

			//Отрисовка линей
			HorizontalLine lineRight = new HorizontalLine(0, 20, 0, '+');
			HorizontalLine lineLeft = new HorizontalLine(0, 20, 20, '+');

			VerticalLine lineUp = new VerticalLine(0, 20, 0, '&');
			VerticalLine lineDown = new VerticalLine(0, 20, 20, '&');

			lineRight.Draw();
			lineLeft.Draw();
			lineUp.Draw();
			lineDown.Draw();

			//Отрисовка змей
			Point p = new Point(2, 2, '*');
			Snake snake = new Snake(p, 2, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(20, 20, '‡');
			Point food = foodCreator.CreatorFood();

			food.Draw();

			while (true) 
			{

				if (snake.eatFood(food))
				{
					food = foodCreator.CreatorFood();
					food.Draw();
				}
				else
				{
					snake.Move();	
				}

				if (Console.KeyAvailable) 
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}

				Thread.Sleep(300);
				snake.Move();
			
			}
		}

		static void Draw(Figure figure) 
		{
			figure.Draw();
		}
	}
}
