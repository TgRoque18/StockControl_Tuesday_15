using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Class
{
    public class Log
    {
        int id = 0;
        int description = 0;
        int date = 0;
        //LogType logType;

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

        public int Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

    }
}
