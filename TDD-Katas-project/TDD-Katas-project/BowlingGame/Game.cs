using System;

namespace TDD_Katas_project.BowlingGame
{
    public class Game
    {
        private int _score = 0;
        private int[] rolls = new int[21];
        private int currentRoll = 0;
        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }


        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsSpare(frameIndex))
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
            return _score;
        }

        private bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }
    }
}
