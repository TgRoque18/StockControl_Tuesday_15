using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Class
{
    public class Log_Type
    {
        private int id;
        private char name;
        private byte active;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public char Name
        {
            get => name;
            set => name = value;
        }

        public byte Active
        {
            get => active;
            set => active = value;
        }

        public Log_Type(int id, char name, byte active)
        {
            this.Active = active;
            this.Id = id;
            this.Name = name;
        }
    }
}
