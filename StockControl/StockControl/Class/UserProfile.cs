using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Class
{
    public class UserProfile
    {
        private int id = 0;
        private bool active;
        private char name;

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

        public char Name
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

        public UserProfile(int id, bool active, char name)
        {
            this.Id = id;
            this.Active = active;
            this.Name = name;
        }
    }
}
