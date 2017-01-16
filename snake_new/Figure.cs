using System;
using System.Collections.Generic;

namespace snake_new
{
	class Figure
	{
		protected List<Point> pList;

		public void Drow()
		{
			foreach (Point p in pList)
			{
				p.Draw();
			}

		}
	}
}
