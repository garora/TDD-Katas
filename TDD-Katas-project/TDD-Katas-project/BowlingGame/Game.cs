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
            _score += pins;
            rolls[currentRoll++] = pins;
        }


        public int Score()
        {
            int score = 0;
            for (int i = 0; i < rolls.Length; i++)
                score += rolls[i];
            return _score;
        }
    }
}
