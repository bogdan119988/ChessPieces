using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPieces.Domain.Dictionary
{
    public class Dictionary
    {
        public enum ActionForm
        {
            Add,
            Edit,
            Delete
        }

        public static List<string> PointX()
        {
            List<string> pointX = new List<string>();
            pointX.Add("");
            pointX.Add("A");
            pointX.Add("B");
            pointX.Add("C");
            pointX.Add("D");
            pointX.Add("E");
            pointX.Add("F");
            pointX.Add("G");
            pointX.Add("H");

            return pointX;
        }

        public static List<string> PointY()
        {
            List<string> pointY = new List<string>();

            pointY.Add("");
            pointY.Add("1");
            pointY.Add("2");
            pointY.Add("3");
            pointY.Add("4");
            pointY.Add("5");
            pointY.Add("6");
            pointY.Add("7");
            pointY.Add("8");

            return pointY;
        }
    }
}
