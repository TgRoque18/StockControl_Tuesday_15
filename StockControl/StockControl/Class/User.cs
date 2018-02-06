using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Class
{
    public class User
    {
        private int id = 0;
        private string name;
        private string password;
        private string email;
        private bool active;
        private UserProfile userProfile;

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

        public string Password
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

        public string Email
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

        public UserProfile UserProfile
        {
            get
            {
                return userProfile;
            }

            set
            {
                userProfile = value;
            }
        }


        public User(int id, string name, string password, string email, bool active, UserProfile userProfile)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
            this.Email = email;
            this.Active = active;
            this.UserProfile = userProfile;
        }
        public User( string name, string password, string email, bool active, UserProfile userProfile)
        {
            
            this.Name = name;
            this.Password = password;
            this.Email = email;
            this.Active = active;
            this.UserProfile = userProfile;
        }

        public User()
        {
        }
    }
}
