using System;
using System.Collections.Generic;


namespace snake_new
{
	public class VerticalLine
	{
		List<Point> pList;

		public VerticalLine(int yTop, int yBottom, int x, char sym)
		{
			pList = new List<Point>();

			for (int y = yTop; y <= yBottom; y++)
			{
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}

		public void Drow()
		{

			foreach (Point p in pList)
			{
				p.Draw();
			}

		}
	}
}
