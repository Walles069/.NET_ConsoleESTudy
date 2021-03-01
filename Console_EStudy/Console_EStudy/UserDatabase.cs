using System;
using System.Collections.Generic;
using System.Text;

namespace Console_EStudy
{
    public class UserDatabase
    {
        private List<User> userList;
        public UserDatabase()
        {
            Console.WriteLine("UserDatabase instance was created automatically");
            this.userList = new List<User>() { new User(), new Employee(), new Administrator() };
        }
    }
}
