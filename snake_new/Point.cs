using System;

namespace snake_new
{
	public class Point
	{
		public int x;
		public int y;
		public char sym;

		public void Draw() { 		
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
			Console.ReadLine();			
		}
	}
}
