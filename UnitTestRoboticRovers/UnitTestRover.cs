using Microsoft.VisualStudio.TestTools.UnitTesting;

using RoboticRoversConsole;

namespace UnitTestRoboticRovers
{
	[TestClass]
	public class UnitTestRover
	{
		[TestMethod]
		public void TestMoveLeft()
		{
			Plateau plateau = new Plateau(5, 5);
			RoverPosition pos = new RoverPosition(plateau, 1, 1, Direction.N);
			Rover rover = new Rover("Rover 1", plateau, pos);
			rover.Move(RoboticRoversConsole.Action.L);			
			Assert.AreEqual(Direction.W, rover.Pos.D);
		}
		[TestMethod]
		public void TestMoveRight()
		{
			Plateau plateau = new Plateau(5, 5);
			RoverPosition pos = new RoverPosition(plateau, 1, 1, Direction.N);
			Rover rover = new Rover("Rover 1", plateau, pos);
			rover.Move(RoboticRoversConsole.Action.R);
			Assert.AreEqual(Direction.E, rover.Pos.D);
		}

		[TestMethod]
		public void TestMoveStep()
		{
			Plateau plateau = new Plateau(5, 5);
			RoverPosition pos = new RoverPosition(plateau, 1, 1, Direction.N);
			Rover rover = new Rover("Rover 1", plateau, pos);
			rover.Move(RoboticRoversConsole.Action.M);
			Assert.AreEqual(Direction.N, rover.Pos.D);
			Assert.AreEqual(1, rover.Pos.X);
			Assert.AreEqual(2, rover.Pos.Y);
		}

		//Add more and more tests here ..
	}
}
