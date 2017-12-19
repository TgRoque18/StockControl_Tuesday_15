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

        public Email(char to, char date, char from, char body, char subject)
        {
            this.To = to;
            this.Date = date;
            this.From = from;
            this.Body = body;
            this.Subject = subject;
        }

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
