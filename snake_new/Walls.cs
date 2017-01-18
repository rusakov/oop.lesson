using System;
using System.Collections.Generic;

namespace snake_new
{
	class Walls
	{
		List<Figure> wallList;

		public Walls(int mapWidth, int mapHeight)
		{
			//Отрисовка линей

			wallList = new List<Figure>();

			HorizontalLine lineTop = new HorizontalLine(0, mapWidth, 0, '+');
			HorizontalLine lineBottom = new HorizontalLine(0, mapWidth, mapHeight, '+');

			VerticalLine lineLeft = new VerticalLine(0, mapHeight, 0, '+');
			VerticalLine lineRight = new VerticalLine(0, mapHeight, mapWidth, '+');

			wallList.Add(lineLeft);
			wallList.Add(lineRight);
			wallList.Add(lineTop);
			wallList.Add(lineBottom);					
		}

		internal bool IsHit(Figure figure)
		{
			foreach (var wall in wallList) 
			{
				
				if (wall.IsHit(figure)) 
				{
					return true;
				}
			}

			return false;
		}

		public void Draw() 
		{
			foreach(var wall in wallList) 
			{
				wall.Draw();
			}
		}
	}
}