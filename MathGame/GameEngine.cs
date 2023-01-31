using MathGame;
namespace MyFirstProgram
{
	internal class GameEngine
	{
		internal void AdditionGame(string message)
		{
			AdditionLevels level = new AdditionLevels();

			level.selectDifficultyLevel();
		}

		internal void SubtractionGame(string message)
		{
			SubtractionLevels level = new SubtractionLevels();
			level.selectDifficultyLevel();
		}

		internal void MultiplicationGame(string message)
		{
			AdditionLevels level = new AdditionLevels();
			level.selectDifficultyLevel();
		}

		internal void DivisionGame(string message)
		{
			AdditionLevels level = new AdditionLevels();
			level.selectDifficultyLevel();
		}
		

	}
}
