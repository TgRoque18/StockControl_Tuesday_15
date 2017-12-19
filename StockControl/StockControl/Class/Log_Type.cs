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
        private string name;
        private bool active;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }

        public Log_Type(int id, string name, bool active)
        {
            this.Active = active;
            this.Id = id;
            this.Name = name;
        }

        public Log_Type(string name, bool active)
        {
            this.Active = active;
            this.Name = name;
        }
    }
}
