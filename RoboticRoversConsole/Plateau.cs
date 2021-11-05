using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticRoversConsole
{
	public class Plateau
	{
		private int rows = 0;
		private int columns = 0;

		public Plateau(int rows, int columns)
		{
			if (rows > 0 && columns > 0)
			{
				this.rows = rows;
				this.columns = columns;
			}
			else
			{
				throw new Exception("Values must be postive");
			}
		}

		public int Rows
		{
			get => rows;
			set => rows = value;
		}

		public int Columns
		{
			get => columns;
			set => columns = value;
		}
	}
}
