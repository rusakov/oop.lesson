﻿using System;
namespace snake_new
{
	class FoodCreator
	{
		int mapWidth;
		int mapHeight;
		char sym;

		Random random = new Random();

		public FoodCreator(int mapWidth, int mapHeight, char sym)
		{
			this.mapWidth = mapWidth;
			this.mapHeight = mapHeight;
			this.sym = sym;
		}

		public Point CreatorFood() 
		{
			int x = random.Next(2, mapWidth - 2);
			int y = random.Next(2, mapHeight - 2);

			return new Point(x, y, sym);
		}
	}
}
