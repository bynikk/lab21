using System;
using System.Collections.Generic;
using System.Text;

namespace lab21.Model
{
    class UsersBase
    {
        public UsersBase()
        {
            Base = new List<User>();
        }

        public List<User> Base { get; private set; }

        public void AddUser(User user)
        {
            Base.Add(user);
        }

    }
}
