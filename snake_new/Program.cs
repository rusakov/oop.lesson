﻿using System;

namespace snake_new
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int x1 = 1;
			int y1 = 1;
			char sym1 = '#';

			Draw(x1, y1, sym1);

			int x2 = 4;
			int y2 = 5;

			char sym2 = '#';

			Draw(x2, y2, sym2);
		}

		static void Draw(int x, int y, char sym) {
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
			Console.ReadLine();
			
		}
	}
}