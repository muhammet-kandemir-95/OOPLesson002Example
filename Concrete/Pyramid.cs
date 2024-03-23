using System;

namespace OOPLesson002Example.Concrete
{
    public class Pyramid
    {
        private List<Row> _rows = new List<Row>();

        public Pyramid(int rowCount)
        {
            if (rowCount <= 0)
            {
                throw new ApplicationException("Row count must be greater than zero!");
            }

            for (int i = 1; i <= rowCount; i++)
            {
                this._rows.Add(new Row(i, rowCount));
            }
        }

        public void ConsoleWrite()
        {
            foreach (Row row in this._rows)
            {
                row.ConsoleWriteLine();
            }
        }
    }
}