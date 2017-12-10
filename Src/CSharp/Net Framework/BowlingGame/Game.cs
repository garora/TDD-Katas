// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
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
                if (IsStrike(frameIndex))
                {
                    score += StrikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (IsSpare(frameIndex))
                {
                    score += 10 + SpareBonus(frameIndex);
                    frameIndex += 2;
                }

                else
                {
                    score += SumOfBallsInFrames(frameIndex);
                    frameIndex += 2;
                }
            }
            return score;
        }

        private bool IsStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        #endregion
        #region Private Methods
        private int SumOfBallsInFrames(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }
        private int SpareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }
        private bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }
        private int StrikeBonus(int frameIndex)
        {
            return 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }
        #endregion
    }
}