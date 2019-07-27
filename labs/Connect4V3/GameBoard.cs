using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4V3
{
    class GameBoard
    {
        readonly Dictionary<Position, Chips> board;
        Position lastPositionPlayed;

        public GameBoard()
        {
            board = new Dictionary<Position, Chips>(MaxRow * MaxColumn);
        }

        public static int MaxRow { get { return 6; } }
        public static int MaxColumn { get { return 7; } }

        public static bool Exists(Position position)
        {
            return position.Row > 0 && position.Row <= MaxRow &&
              position.Column > 0 && position.Column <= MaxColumn;
        }

        public void Initialize()
        {
            int x, y;
            x = y = 1;
            for (int i = 1; i <= MaxRow * MaxColumn; i++)
            {
                board.Add(new Position(y, x), Chips.Empty);
                x++;
                if (x > MaxColumn)
                {
                    y++;
                    x = 1;
                }
            }
        }

        public bool PlayChips(Chips chips, int column)
        {
            int row = MaxRow;
            while (row > 0 && board[new Position(row, column)] != Chips.Empty)
            {
                row--;
            }

            if (row > 0)
            {
                board[new Position(row, column)] = chips;
                lastPositionPlayed = new Position(row, column);
                return true;
            }
            return false;
        }

        public Position LastPositionPlayed
        {
            get
            {
                return lastPositionPlayed;
            }
        }
        public bool IsEmpty
        {
            get { return board.Values.All(d => d == Chips.Empty); }
        }

        public int LastPositionPlayedOrdered()
        {
            return board.Keys.OrderBy(k => k.Row).ThenBy(k => k.Column).ToList().IndexOf(LastPositionPlayed);
        }

        bool HorizontalWins(Position position, Chips chips)
        {
            var nearByChips = 0;
            var column = position.Column + 1;

            // right.
            while (column <= MaxColumn)
            {
                var pos = new Position(position.Row, column);
                if (board[pos] == chips)
                {
                    nearByChips++;
                    column++;
                }
                else
                {
                    break;
                }
            }

            // left.
            column = position.Column - 1;
            while (column >= 1)
            {
                var pos = new Position(position.Row, column);
                if (board[pos] == chips)
                {
                    nearByChips++;
                    column--;
                }
                else
                {
                    break;
                }
            }
            return nearByChips >= 3;
        }
        bool VerticalWins(Position position, Chips chips)
        {
            var nearByChips = 0;
            var row = position.Row + 1;

            // down.
            while (row <= MaxRow)
            {
                var pos = new Position(row, position.Column);
                if (board[pos] == chips)
                {
                    nearByChips++;
                    row++;
                }
                else
                {
                    break;
                }
            }
            return nearByChips >= 3;
        }
        bool LeftRightDiagonalWins(Position lastPositionPlayed, Chips chips)
        {
            var nearByChips = 0;
            var row = lastPositionPlayed.Row - 1;
            var column = lastPositionPlayed.Column - 1;

            // left
            while (row >= 1 && column >= 1)
            {
                var pos = new Position(row, column);
                if (board[pos] == chips)
                {
                    nearByChips++;
                    column--;
                    row--;
                }
                else
                {
                    break;
                }
            }

            row = lastPositionPlayed.Row + 1;
            column = lastPositionPlayed.Column + 1;
            // right
            while (row <= MaxRow && column <= MaxColumn)
            {
                var pos = new Position(row, column);
                if (board[pos] == chips)
                {
                    nearByChips++;
                    column++;
                    row++;
                }
                else
                {
                    break;
                }
            }
            return nearByChips >= 3;
        }
        bool RightLeftDiagonalWins(Position lastPositionPlayed, Chips chips)
        {
            var nearByChips = 0;

            var row = lastPositionPlayed.Row - 1; ;
            var column = lastPositionPlayed.Column + 1;

            // right
            while (row >= 1 && column <= MaxColumn)
            {
                var pos = new Position(row, column);
                if (board[pos] != chips) break;
                if (board[pos] == chips)
                {
                    nearByChips++;
                    column++;
                    row--;
                }
                else
                {
                    break;
                }
            }

            row = lastPositionPlayed.Row + 1;
            column = lastPositionPlayed.Column - 1;
            // left
            while (row <= MaxRow && column >= 1)
            {
                var pos = new Position(row, column);
                if (board[pos] == chips)
                {
                    nearByChips++;
                    column--;
                    row++;
                }
                else
                {
                    break;
                }
            }
            return nearByChips >= 3;
        }

        public bool Winner()
        {
            if (HorizontalWins(lastPositionPlayed, board[lastPositionPlayed])) return true;           
            if (VerticalWins(lastPositionPlayed, board[lastPositionPlayed])) return true;
            if (LeftRightDiagonalWins(lastPositionPlayed, board[lastPositionPlayed])) return true;
            if (RightLeftDiagonalWins(lastPositionPlayed, board[lastPositionPlayed])) return true;
            return false;

        }

    }
}
