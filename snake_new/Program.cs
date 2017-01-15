using System;
using System.Collections.Generic;

namespace snake_new
{
	class MainClass
	{
		public static void Main(string[] args)
		{
				
			Point p1 = new Point(1, 3, '#');
			Point p2 = new Point(4, 5, '*');
			Point p3 = new Point(12, 10, '⁄');
			Point p4 = new Point(p3.x * 3, p3.y * 2, '€');

			List<Point> pList = new List<Point>();

			pList.Add(p1);
			pList.Add(p2);
			pList.Add(p3);
			pList.Add(p4);


			foreach (var i in pList) {
				i.Draw();
			}

		}
	}
}
