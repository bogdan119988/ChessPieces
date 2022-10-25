using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPieces.Domain.Model
{
    public class Shapes
    {
        public Shapes()
        {
            Points = new List<Point>();
        }

        public long Id { get; set; }

        /// <summary>
        /// Наименование фигуры
        /// </summary>
        [DisplayName("Наименование фигуры")]
        public string Name { get; set; }

        /// <summary>
        /// Аббревиатура
        /// </summary>
        [DisplayName("Аббревиатура")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Путь до изображения
        /// </summary>
        public string Img_path { get; set; }

        /// <summary>
        /// Координаты
        /// </summary>
        public List<Point> Points { get; set; }

        [DisplayName("Координаты передвижения")]
        public string Coordinates { get; set; }

        /// <summary>
        /// Преобразование в коллекцию точек
        /// </summary>
        /// <param name="coordinates"></param>
        public void ToPoint(string coordinates)
        {
            string[] mass = coordinates?.Split(';');

            if(mass.Count() > 0)
            {
                foreach(string item in mass)
                {
                    if (!string.IsNullOrWhiteSpace(item))
                    {
                        string p = item.Replace("[", "").Replace("]", "");
                        string[] p_arr = p.Split(',');
                        this.Points.Add(new Point { X = p_arr[0], Y = int.Parse(p_arr[1]) });
                    }
                    
                }
            }
        }

        /// <summary>
        /// Преобразование из коллекции точек в строку
        /// </summary>
        /// <returns></returns>
        public string FromPointToString()
        {
            StringBuilder points = new StringBuilder();
            this.Points?.ForEach(s => points.Append($"[{s.X},{s.Y.ToString()}];"));
            return points?.ToString()?.TrimEnd(';');
        }
    }
}
