using ChessPieces.Domain.Abstract;
using ChessPieces.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ChessPieces.Domain.Services;
using System.Data;

namespace ChessPieces.Domain.Concrete
{
    public class ShapesRepository : IShapesRepository
    {
        private ADONETProvider provider;

        public ShapesRepository()
        {
            provider = new ADONETProvider("Shapes");
        }

        public IEnumerable<Shapes> Get()
        {
            List<Shapes> shapes = new List<Shapes>();
            DataSet ds = provider.Get();
            shapes = ToModel(ds);

            return shapes;
        }

        public int Add(Shapes shapes)
        {
            string columnName = "Abbreviation, Img_path, Coordinates, Name";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"N'{shapes.Abbreviation}',");
            stringBuilder.Append($"N'{shapes.Img_path}',");
            stringBuilder.Append($"N'{shapes.FromPointToString()}',");
            stringBuilder.Append($"N'{shapes.Name}'");

            string columnValues = stringBuilder.ToString();

            return provider.Add(columnName, columnValues);
        }

        public int Delete(long shapesId)
        {
            string columnName = "Id";
            string columnValue = shapesId.ToString();

            return provider.Delete(columnName, columnValue);
        }

        public int Update(Shapes shapes)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Abbreviation = N'{shapes.Abbreviation}',");
            stringBuilder.Append($"Img_path = N'{shapes.Img_path}',");
            stringBuilder.Append($"Coordinates = N'{shapes.FromPointToString()}',");
            stringBuilder.Append($"Name = N'{shapes.Name}'");

            return provider.Update(stringBuilder.ToString(), $"Id = {shapes.Id.ToString()}");
        }

        /// <summary>
        /// Преобразование в модель
        /// </summary>
        /// <param name="sqlDataReader"></param>
        /// <returns></returns>
        private List<Shapes> ToModel(DataSet ds)
        {
            List<Shapes> shapes = new List<Shapes>();
            DataTable table = ds.Tables[0];

            for (int r = 0; r < table.Rows.Count; r++)
            {
                DataRow row = table.Rows[r];
                Shapes shape = new Shapes
                {
                    Id = (long)row["Id"],
                    Abbreviation = (string)row["Abbreviation"],
                    Img_path = (string)row["Img_path"],
                    Name = (string)row["Name"],
                    Coordinates = (string)row["Coordinates"],
                    Points = new List<Point>()
                };
                shape.ToPoint((string)row["Coordinates"]);
                shapes.Add(shape);
            }
            return shapes;
        }
    }
}
