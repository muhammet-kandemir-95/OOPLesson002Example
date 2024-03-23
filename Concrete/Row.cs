using System;

namespace OOPLesson002Example.Concrete
{
    public class Row
    {
        private int _order;
        private int _totalRowCount;

        public int Order
        {
            get
            {
                return this._order;
            }
        }

        public Row(int order, int totalRowCount)
        {
            if (order <= 0)
            {
                throw new ApplicationException("Order must be greater than zero!");
            }

            if (totalRowCount <= 0)
            {
                throw new ApplicationException("Total row count must be greater than zero!");
            }

            this._order = order;
            this._totalRowCount = totalRowCount;
        }

        public void ConsoleWriteLine()
        {
            Console.WriteLine("".PadLeft(this._totalRowCount - this.Order, ' ') + "".PadLeft(this.Order * 2 - 1, '*'));
        }
    }
}