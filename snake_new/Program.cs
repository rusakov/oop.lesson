
using System;
using System.Collections.Generic;
using System.Threading;

namespace snake_new
{
	class MainClass
	{
		static void Main(string[] args)
		{

			Walls walls = new Walls(20, 20);
			walls.Draw();

			//Отрисовка змей
			Point p = new Point(2, 2, '*');
			Snake snake = new Snake(p, 2, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(20, 20, '‡');
			Point food = foodCreator.CreatorFood();

			food.Draw();

			while (true) 
			{
				if (walls.IsHit(snake) || snake.isHitTail()) {
					break;
				}

				if (snake.eatFood(food))
				{
					food = foodCreator.CreatorFood();
					food.Draw();
				}
				else
				{
					snake.Move();	
				}

				Thread.Sleep(300);
				if (Console.KeyAvailable) 
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
		}
	}
}
