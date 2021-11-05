using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RoboticRoversConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Enter Graph Upper Right Coordinate: ");
				string value = Console.ReadLine();
				string[] array = value.Split(' ');

				int rows = Int32.Parse(array[0]);
				int columns = Int32.Parse(array[1]);
				Plateau plateau = new Plateau(rows, columns);

				GoToRover("Rover 1", plateau);

				GoToRover("Rover 2", plateau);

				//GoToRover("Rover 3", plateau);

				//....
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.ReadKey(true);
		}

		static private void GoToRover(string name, Plateau plateau)
		{
			Console.Write(name + " Starting Position: ");
			string value = Console.ReadLine();
			string[] array = value.Split(' ');

			int x = Int32.Parse(array[0]);
			int y = Int32.Parse(array[1]);
			Direction d = (Direction)Enum.Parse(typeof(Direction), array[2]);

			RoverPosition pos = new RoverPosition(plateau, x, y, d);
			Rover rover = new Rover("Rover 1", plateau, pos);

			Console.Write("Rover 1 Movement Plan: ");
			value = Console.ReadLine();
			Move(rover, value);

			Console.WriteLine(rover.Name + " Output: " + rover.Pos.GetPosition());
		}

		static private void Move(Rover rover, string plan)
		{
			for (int i = 0; i < plan.Length; i++)
			{
				Action act = (Action)Enum.Parse(typeof(Action), plan[i].ToString());
				rover.Move(act);
			//For Debug:	Console.WriteLine(rover.Name + " Output: " + rover.Pos.GetPosition());
			}
		}
	}	
}
