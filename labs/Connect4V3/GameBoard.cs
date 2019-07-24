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
            if (column > MaxColumn || column < 1) throw new ArgumentException(String.Format("Column must be between 1 and {0}", MaxColumn));
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

        public int LastPositionPlayedAsOrderedIndex()
        {
            return board.Keys.OrderBy(k => k.Row).ThenBy(k => k.Column).ToList().IndexOf(LastPositionPlayed);
        }

        bool HorizontalWins(Position position, Chips chips)
        {
            var contiguousChips = 0;
            var column = position.Column + 1;

            //check right.
            while (column <= MaxColumn)
            {
                var loc = new Position(position.Row, column);
                if (board[loc] == chips)
                {
                    contiguousChips++;
                    column++;
                }
                else
                {
                    break;
                }
            }

            //check left.
            column = position.Column - 1;
            while (column >= 1)
            {
                var loc = new Position(position.Row, column);
                if (board[loc] == chips)
                {
                    contiguousChips++;
                    column--;
                }
                else
                {
                    break;
                }
            }
            return contiguousChips >= 3;
        }
        bool VerticalWins(Position position, Chips chips)
        {
            var contiguousChips = 0;
            var row = position.Row + 1;

            //check down.
            while (row <= MaxRow)
            {
                var loc = new Position(row, position.Column);
                if (board[loc] == chips)
                {
                    contiguousChips++;
                    row++;
                }
                else
                {
                    break;
                }
            }
            return contiguousChips >= 3;
        }
        bool LeftRightDiagonalWins(Position lastPositionPlayed, Chips chips)
        {
            var contiguousChips = 0;
            var row = lastPositionPlayed.Row - 1;
            var column = lastPositionPlayed.Column - 1;

            //check north west.
            while (row >= 1 && column >= 1)
            {
                var loc = new Position(row, column);
                if (board[loc] == chips)
                {
                    contiguousChips++;
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
            //check south east
            while (row <= MaxRow && column <= MaxColumn)
            {
                var loc = new Position(row, column);
                if (board[loc] == chips)
                {
                    contiguousChips++;
                    column++;
                    row++;
                }
                else
                {
                    break;
                }
            }
            return contiguousChips >= 3;
        }
        bool RightLeftDiagonalWins(Position lastPositionPlayed, Chips chips)
        {
            var contiguousChips = 0;

            var row = lastPositionPlayed.Row - 1; ;
            var column = lastPositionPlayed.Column + 1;

            //check north east.
            while (row >= 1 && column <= MaxColumn)
            {
                var loc = new Position(row, column);
                if (board[loc] != chips) break;
                if (board[loc] == chips)
                {
                    contiguousChips++;
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
            //check south west
            while (row <= MaxRow && column >= 1)
            {
                var loc = new Position(row, column);
                if (board[loc] == chips)
                {
                    contiguousChips++;
                    column--;
                    row++;
                }
                else
                {
                    break;
                }
            }
            return contiguousChips >= 3;
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
