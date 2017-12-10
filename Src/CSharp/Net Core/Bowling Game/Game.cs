namespace TDD_Katas_NETCore.Bowling_Game
{
    public class Game
    {
        private readonly int[] _rolls = new int[21];
        private int _currentRoll;
        
        public void Roll(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }

        public int Score()
        {
            var score = 0;
            var frameIndex = 0;
            for (var frame = 0; frame < 10; frame++)
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
            return score;
        }

        private bool IsStrike(int frameIndex) => _rolls[frameIndex] == 10;



        private int SumOfBallsInFrames(int frameIndex) => _rolls[frameIndex] + _rolls[frameIndex + 1];

        private int SpareBonus(int frameIndex) => _rolls[frameIndex + 2];

        private bool IsSpare(int frameIndex) => _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;

        private int StrikeBonus(int frameIndex) => 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];


    }
}