using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Class
{
    public class User
    {
        int id = 0;
        char name;
        char password;
        char email;
        bool active;
        //UserProfile userProfile;

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

        public char Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public char Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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
       


    }
}
