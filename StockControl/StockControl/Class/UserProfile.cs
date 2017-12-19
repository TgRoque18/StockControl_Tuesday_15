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
        private string name;

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

        public UserProfile(int id, bool active, string name)
        {
            this.Id = id;
            this.Active = active;
            this.Name = name;
        }
        public UserProfile(bool active, string name)
        {
            this.Active = active;
            this.Name = name;
        }
    }
}
