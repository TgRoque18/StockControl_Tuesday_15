using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Class
{
   public class Email
    {
        private char to;
        private char date;
        private char from;
        private char body;
        private char subject;

        public char To
        {
            get
            {
                return to;
            }

            set
            {
                to = value;
            }
        }

        public char Date
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

        public char From
        {
            get
            {
                return from;
            }

            set
            {
                from = value;
            }
        }

        public char Body
        {
            get
            {
                return body;
            }

            set
            {
                body = value;
            }
        }

        public char Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }

    }
}
