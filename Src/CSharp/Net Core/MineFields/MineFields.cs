// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace TDD_Katas_NETCore.MineFields
{
    internal static class Constants
    {
        public const int Mine = -1;
    }

    internal class MineFields
    {
        private int[,] _fields;

        public void Create(int width, int height) => _fields = new int[width, height];

        public int GetHint(int xPos, int yPos) => _fields[xPos, yPos];

        internal void Mine(int xPos, int yPos)
        {
            LayMine(xPos, yPos);
            UpdateHint(xPos, yPos);
        }

        private void LayMine(int xPosOfMine, int yPosOfMine) => _fields[xPosOfMine, yPosOfMine] = Constants.Mine;

        private void UpdateHint(int xPosOfMine, int yPosOfMine)
        {
            UpdateHintAtRight(xPosOfMine, yPosOfMine);
            UpdateHintAtLeft(xPosOfMine, yPosOfMine);
            UpdateHintAtBottom(xPosOfMine, yPosOfMine);
            UpdateHintAtTop(xPosOfMine, yPosOfMine);
            UpdateHintAtBottomRightCorner(xPosOfMine, yPosOfMine);
            UpdateHintAtTopLeftCorner(xPosOfMine, yPosOfMine);
            UpdateHintAtTopRightCorner(xPosOfMine, yPosOfMine);
            UpdateHintAtBottomLeftCorner(xPosOfMine, yPosOfMine);
        }

        private void UpdateHintAtBottomLeftCorner(int xPosOfMine, int yPosOfMine)
        {
            if (CheckMinWidth(xPosOfMine - 1) && CheckMaxHeight(yPosOfMine + 1) &&
                IsNotMine(xPosOfMine - 1, yPosOfMine + 1))
            {
                _fields[xPosOfMine - 1, yPosOfMine + 1] += 1;
            }
        }

        private void UpdateHintAtTopRightCorner(int xPosOfMine, int yPosOfMine)
        {
            if (CheckMaxWidth(xPosOfMine + 1) && CheckMinHeight(yPosOfMine - 1) &&
                IsNotMine(xPosOfMine + 1, yPosOfMine - 1))
            {
                _fields[xPosOfMine + 1, yPosOfMine - 1] += 1;
            }
        }

        private void UpdateHintAtTopLeftCorner(int xPosOfMine, int yPosOfMine)
        {
            if (CheckMinWidth(xPosOfMine - 1) && CheckMinHeight(yPosOfMine - 1) &&
                IsNotMine(xPosOfMine - 1, yPosOfMine - 1))
            {
                _fields[xPosOfMine - 1, yPosOfMine - 1] += 1;
            }
        }

        private void UpdateHintAtBottomRightCorner(int xPosOfMine, int yPosOfMine)
        {
            if (CheckMaxWidth(xPosOfMine + 1) && CheckMaxHeight(yPosOfMine + 1) &&
                IsNotMine(xPosOfMine + 1, yPosOfMine + 1))
                _fields[xPosOfMine + 1, yPosOfMine + 1] += 1;
        }

        private void UpdateHintAtTop(int xPosOfMine, int yPosOfMine)
        {
            if (CheckMinHeight(yPosOfMine - 1) && IsNotMine(xPosOfMine, yPosOfMine - 1))
            {
                _fields[xPosOfMine, yPosOfMine - 1] += 1;
            }
        }

        private void UpdateHintAtBottom(int xPosOfMine, int yPosOfMine)
        {
            if (CheckMaxHeight(yPosOfMine + 1) && IsNotMine(xPosOfMine, yPosOfMine + 1))
            {
                _fields[xPosOfMine, yPosOfMine + 1] += 1;
            }
        }

        private void UpdateHintAtLeft(int xPosOfMine, int yPosOfMine)
        {
            if (CheckMinWidth(xPosOfMine - 1) && IsNotMine(xPosOfMine - 1, yPosOfMine))
            {
                _fields[xPosOfMine - 1, yPosOfMine] += 1;
            }
        }

        private void UpdateHintAtRight(int xPosOfMine, int yPosOfMine)
        {
            if (CheckMaxWidth(xPosOfMine + 1) && IsNotMine(xPosOfMine + 1, yPosOfMine))
            {
                _fields[xPosOfMine + 1, yPosOfMine] += 1;
            }
        }

        private bool IsNotMine(int xPos, int yPos) => _fields[xPos, yPos] != Constants.Mine;

        private bool CheckMaxWidth(int xPos) => _fields.GetLength(0) > xPos;

        private bool CheckMinWidth(int xPos) => xPos >= 0;

        private bool CheckMaxHeight(int yPos) => _fields.GetLength(1) > yPos;

        private bool CheckMinHeight(int yPos) => yPos >= 0;
    }
}