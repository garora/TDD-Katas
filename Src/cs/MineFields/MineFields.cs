// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace TDD_Katas_project.MineFields
{
    static class Constants
    {
        public const int Mine = -1;
    }

    class MineFields
    {
        int[,] fields;

        public void create(int width, int height)
        {
            fields = new int[width, height];
        }

        public int getHint(int xPos, int yPos)
        {
            return fields[xPos, yPos];
        }

        internal void mine(int xPos, int yPos)
        {
            layMine(xPos, yPos);
            updateHint(xPos, yPos);
        }

        private void layMine(int xPosOfMine, int yPosOfMine)
        {
            fields[xPosOfMine, yPosOfMine] = Constants.Mine;
        }

        private void updateHint(int xPosOfMine, int yPosOfMine)
        {
            updateHintAtRight(xPosOfMine, yPosOfMine);
            updateHintAtLeft(xPosOfMine, yPosOfMine);
            updateHintAtBottom(xPosOfMine, yPosOfMine);
            updateHintAtTop(xPosOfMine, yPosOfMine);
            updateHintAtBottomRightCorner(xPosOfMine, yPosOfMine);
            updateHintAtTopLeftCorner(xPosOfMine, yPosOfMine);
            updateHintAtTopRightCorner(xPosOfMine, yPosOfMine);
            updateHintAtBottomLeftCorner(xPosOfMine, yPosOfMine);
        }

        private void updateHintAtBottomLeftCorner(int xPosOfMine, int yPosOfMine)
        {
            if (checkMinWidth(xPosOfMine - 1) && checkMaxHeight(yPosOfMine + 1) && isNotMine(xPosOfMine - 1, yPosOfMine + 1))
                fields[xPosOfMine - 1, yPosOfMine + 1] += 1;
        }

        private void updateHintAtTopRightCorner(int xPosOfMine, int yPosOfMine)
        {
            if (checkMaxWidth(xPosOfMine + 1) && checkMinHeight(yPosOfMine - 1) && isNotMine(xPosOfMine + 1, yPosOfMine - 1))
                fields[xPosOfMine + 1, yPosOfMine - 1] += 1;
        }

        private void updateHintAtTopLeftCorner(int xPosOfMine, int yPosOfMine)
        {
            if (checkMinWidth(xPosOfMine - 1) && checkMinHeight(yPosOfMine - 1) && isNotMine(xPosOfMine - 1, yPosOfMine - 1))
                fields[xPosOfMine - 1, yPosOfMine - 1] += 1;
        }

        private void updateHintAtBottomRightCorner(int xPosOfMine, int yPosOfMine)
        {
            if (checkMaxWidth(xPosOfMine + 1) && checkMaxHeight(yPosOfMine + 1) && isNotMine(xPosOfMine + 1, yPosOfMine + 1))
                fields[xPosOfMine + 1, yPosOfMine + 1] += 1;
        }

        private void updateHintAtTop(int xPosOfMine, int yPosOfMine)
        {
            if (checkMinHeight(yPosOfMine - 1) && isNotMine(xPosOfMine, yPosOfMine - 1))
                fields[xPosOfMine, yPosOfMine - 1] += 1;
        }

        private void updateHintAtBottom(int xPosOfMine, int yPosOfMine)
        {
            if (checkMaxHeight(yPosOfMine + 1) && isNotMine(xPosOfMine, yPosOfMine + 1))
                fields[xPosOfMine, yPosOfMine + 1] += 1;
        }

        private void updateHintAtLeft(int xPosOfMine, int yPosOfMine)
        {
            if (checkMinWidth(xPosOfMine - 1) && isNotMine(xPosOfMine - 1, yPosOfMine))
                fields[xPosOfMine - 1, yPosOfMine] += 1;
        }

        private void updateHintAtRight(int xPosOfMine, int yPosOfMine)
        {
            if (checkMaxWidth(xPosOfMine + 1) && isNotMine(xPosOfMine + 1, yPosOfMine))
                fields[xPosOfMine + 1, yPosOfMine] += 1;
        }

        private bool isNotMine(int xPos, int yPos)
        {
            return fields[xPos, yPos] != Constants.Mine;
        }

        private bool checkMaxWidth(int xPos)
        {
            return fields.GetLength(0) > xPos;
        }

        private bool checkMinWidth(int xPos)
        {
            return xPos >= 0;
        }

        private bool checkMaxHeight(int yPos)
        {
            return fields.GetLength(1) > yPos;
        }

        private bool checkMinHeight(int yPos)
        {
            return yPos >= 0;
        }
    }
}
