namespace TDD_Katas_project.BowlingGame
{
    public class Game
    {
        #region Private members
        private int[] rolls = new int[21];
        private int _currentRoll = 0;

        #endregion

        #region Public Methods
        public void Roll(int pins)
        {
            rolls[_currentRoll++] = pins;
        }
        public int Score()
        {
            var score = 0;
            var frameIndex = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                if (rolls[frameIndex] == 10)
                {
                    score += 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                    frameIndex++;
                }
                else if (IsSpare(frameIndex))
                {
                    score += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                }

                else
                {
                    score += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return score;
        }
        #endregion
        #region Private Methods

        private bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }
        #endregion
    }
}
