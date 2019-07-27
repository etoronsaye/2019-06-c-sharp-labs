using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4V3
{
    class Position
    {
        public Position(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }
        public int Column { get; set; }
        public int Row { get; set; }

        /*public override string ToString()
        {
            return "Column: " + Column + " Row: " + Row;
        }*/

        public override bool Equals(object obj)
        {
            var that = obj as Position;
            if (that == null) return false;
            return this.Column == that.Column && this.Row == that.Row;
        }
        
        public override int GetHashCode()
        {
            return Column.GetHashCode() + Row.GetHashCode();
        }
    }
}
