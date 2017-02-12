namespace TDD_Katas_project.TheGameOfLifeKata
{
    public class GameOfLife
    {
        public GameOfLife()
        {
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    if (i == 0)
                        k = i;
                    else
                        k = i - 1;
                    if (j == 0)
                        l = j;
                    else
                        l = j - 1;
                    for (int m = k; m <= i + 1 && m < 4; m++)
                    {
                        for (int n = l; n <= j + 1 && n < 8; n++)
                        {
                            if (input2D[m, n] == "*" && (m != i || n != j))
                                NoOfLiveN[i, j]++;
                        }
                    }
                }
            }
        }
        int i = 0, j = 0, k, l;
        public string[,] input2D = new string[4, 8] { { ".", ".", ".", ".", ".", ".", ".", "." }, { ".", ".", ".", ".", "*", ".", ".", "." }, { ".", ".", ".", "*", "*", ".", ".", "." }, { ".", ".", ".", ".", ".", ".", ".", "." } };
        public string[,] output2D = new string[4, 8] { { "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "" } };

        int[,] NoOfLiveN = new int[4, 8] { { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 } };
        void inputPattern()
        {
            //Console.WriteLine("input");
            //Console.WriteLine("give a input in this format * indicates live cell, . indicates dead cell");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 8; j++)
                {

                    //Console.Write(input2D[i, j]);
                }
                // Console.WriteLine();
            }
        }
        public void printOutput()
        {
            
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 8; j++)
                {
                    if (input2D[i, j] == "*" && (NoOfLiveN[i, j] > 3 || NoOfLiveN[i, j] < 2))
                        output2D[i, j] = output2D[i, j] + ".";

                    else if (input2D[i, j] == "*" && NoOfLiveN[i, j] == (2 | 3))
                        output2D[i, j] = output2D[i, j] + "*";

                    else if (input2D[i, j] == "." && NoOfLiveN[i, j] == 3)
                        output2D[i, j] = output2D[i, j] + "*";
                    else
                        output2D[i, j] = output2D[i, j] + input2D[i, j];

                    Console.Write(output2D[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
