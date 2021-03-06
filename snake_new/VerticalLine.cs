﻿using System;
using System.Collections.Generic;


namespace snake_new 
{
	class VerticalLine : Figure 
	{
		public VerticalLine(int yTop, int yBottom, int x, char sym) 
		{
			pList = new List<Point>();

			for (int y = yTop; y <= yBottom; y++) {
				Point p = new Point(x, y, sym);
				pList.Add(p);
			}
		}

		public override void Draw()
		{
			Console.ForegroundColor = ConsoleColor.Red;

			base.Draw();

			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
