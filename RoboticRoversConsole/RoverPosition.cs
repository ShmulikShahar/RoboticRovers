using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticRoversConsole
{
	public enum Direction
	{
		N,
		E,
		S,
		W
	}

	public class RoverPosition
	{
		private Plateau plateau = null;
		private int x = 0;
		private int y = 0;
		Direction d = Direction.N;//direction


		public RoverPosition(Plateau plateau, int x, int y, Direction d)
		{
			if (plateau != null)
			{
				this.plateau = plateau;
			}
			else
			{
				throw new Exception("Plateau cannot be null");
			}

			X = x;
			Y = y;
			D = d;
		}

		public String GetPosition()
		{
			return X.ToString() + " " + Y.ToString() + " " + D.ToString();
		}

		public int X
		{
			get => x;
			set
			{
				//In the case that we can not be out of range remove comments.
				//if (value < this.plateau.Rows && value >= 0)
				{
					x = value;
				}
				/*else
				{
					throw new Exception("value X: " + value + " out of bounds of Plateau");
				}*/
			}
		}

		public int Y
		{
			get => y;
			set
			{
				//In the case that we can not be out of range remove comments.
				//if (value < this.plateau.Columns && value >= 0)
				{
					y = value;
				}
				/*else
				{
					throw new Exception("value Y: " + value + " out of bounds of Plateau");
				}*/
			}
		}

		public Direction D
		{
			get => d;
			set => d = value;
		}
	}
}