using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPieces.Domain.Model
{
    public class Point
    {
        public string X { get; set; }

        public int Y { get; set; }

        public override string ToString()
        {
            return X + ";" + Y.ToString();
        }

        public void ToPoint(string item)
        {
            string[] itemArr = item.Split(';');

            X = itemArr[0];
            Y = int.Parse(itemArr[1]);
        }

        public override bool Equals(object obj)
        {
            if(obj is Point item)
            {
                return X == item.X
                    && Y == item.Y;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;

            hash = hash * 31 + X.GetHashCode();
            hash = hash * 31 + Y.GetHashCode();
            return hash;
        }
    }
}
