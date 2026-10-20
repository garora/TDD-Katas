// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;

namespace TDD_Katas_project.TheReversiKata
{
    /// <summary>Finds legal moves for a player on an 8 by 8 Reversi board.</summary>
    public class Reversi
    {
        private static readonly int[,] Directions =
        {
            { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, -1 },
            { 0, 1 }, { 1, -1 }, { 1, 0 }, { 1, 1 }
        };

        /// <summary>Returns legal move coordinates as zero-based row and column pairs.</summary>
        public static IList<Move> GetLegalMoves(string[] board, char player)
        {
            ValidateBoard(board, player);
            var opponent = player == 'B' ? 'W' : 'B';
            var moves = new List<Move>();

            for (var row = 0; row < 8; row++)
                for (var column = 0; column < 8; column++)
                {
                    if (board[row][column] != '.')
                        continue;

                    for (var direction = 0; direction < Directions.GetLength(0); direction++)
                    {
                        if (CapturesOpponent(board, row, column,
                            Directions[direction, 0], Directions[direction, 1], player, opponent))
                        {
                            moves.Add(new Move(row, column));
                            break;
                        }
                    }
                }

            return moves;
        }

        /// <summary>Returns a copy of the board with legal empty squares marked by '0'.</summary>
        public static string[] MarkLegalMoves(string[] board, char player)
        {
            ValidateBoard(board, player);
            var markedBoard = (string[])board.Clone();
            foreach (var move in GetLegalMoves(board, player))
            {
                var row = markedBoard[move.Row].ToCharArray();
                row[move.Column] = '0';
                markedBoard[move.Row] = new string(row);
            }

            return markedBoard;
        }

        private static bool CapturesOpponent(string[] board, int row, int column,
            int rowStep, int columnStep, char player, char opponent)
        {
            var currentRow = row + rowStep;
            var currentColumn = column + columnStep;
            if (!IsOnBoard(currentRow, currentColumn) || board[currentRow][currentColumn] != opponent)
                return false;

            while (IsOnBoard(currentRow, currentColumn) && board[currentRow][currentColumn] == opponent)
            {
                currentRow += rowStep;
                currentColumn += columnStep;
            }

            return IsOnBoard(currentRow, currentColumn) && board[currentRow][currentColumn] == player;
        }

        private static bool IsOnBoard(int row, int column)
        {
            return row >= 0 && row < 8 && column >= 0 && column < 8;
        }

        private static void ValidateBoard(string[] board, char player)
        {
            if (board == null)
                throw new ArgumentNullException("board");
            if (board.Length != 8)
                throw new ArgumentException("A Reversi board must have eight rows.", "board");
            if (player != 'B' && player != 'W')
                throw new ArgumentException("Player must be 'B' or 'W'.", "player");

            foreach (var row in board)
            {
                if (row == null || row.Length != 8)
                    throw new ArgumentException("Each Reversi row must contain eight squares.", "board");
                foreach (var square in row)
                    if (square != '.' && square != 'B' && square != 'W')
                        throw new ArgumentException("Board squares must be '.', 'B', or 'W'.", "board");
            }
        }
    }

    /// <summary>A zero-based board coordinate.</summary>
    public class Move
    {
        public Move(int row, int column) { Row = row; Column = column; }
        public int Row { get; private set; }
        public int Column { get; private set; }
    }
}
