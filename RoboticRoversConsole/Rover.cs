using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticRoversConsole
{	
	public enum Action
	{
		L,
		R,
		M
	}
	public class Rover
	{
		private String name = "";
		private Plateau plateau = null;
		private RoverPosition pos = null;

		public Rover(string name, Plateau plateau, RoverPosition pos)
		{
			Name = name;
			P = plateau;
			Pos = pos;
		}

		public void Move(Action action)
		{
			switch (action)
			{
				case Action.L:
					turn_left();
					break;
				case Action.R:
					turn_right();
					break;
				case Action.M:
					step();
					break;
			}
		}

		private void turn_left()
		{
			switch (Pos.D)
			{
				case Direction.E:
					Pos.D = Direction.N;
					break;
				case Direction.N:
					Pos.D = Direction.W;
					break;
				case Direction.S:
					Pos.D = Direction.E;
					break;
				case Direction.W:
					Pos.D = Direction.S;
					break;
			}
		}

		private void turn_right()
		{
			switch (Pos.D)
			{
				case Direction.E:
					Pos.D = Direction.S;
					break;
				case Direction.N:
					Pos.D = Direction.E;
					break;
				case Direction.S:
					Pos.D = Direction.W;
					break;
				case Direction.W:
					Pos.D = Direction.N;
					break;
			}			
		}

		private void step()
		{
			switch (Pos.D)
			{
				case Direction.E:
					Pos.X++;
					break;
				case Direction.N:
					Pos.Y++;
					break;
				case Direction.S:
					Pos.Y--;
					break;
				case Direction.W:
					Pos.X--;
					break;
			}
		}

		public String Name
		{
			get => name;
			set => name = value;
		}

		private Plateau P
		{
			get => plateau;
			set
			{
				if (value != null)
				{
					plateau = value;
				}
				else
				{
					throw new Exception("Plateau can not be null");
				}
			}
		}

		public RoverPosition Pos
		{
			get => pos;
			set
			{
				if (value != null)
				{
					pos = value;
				}
				else
				{
					throw new Exception("RoverPosition can not be null");
				}
			}
		}
	}
}