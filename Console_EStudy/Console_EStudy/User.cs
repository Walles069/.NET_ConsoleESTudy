using System;
using System.Collections.Generic;
using System.Text;

namespace Console_EStudy
{
    public class User
    {
        private string _name;
        private string _surname;
        private Guid _userID;
        private bool _isAdmin = false;
        

        public User()
        {
            this._name = "Name";
            this._surname = "Surname";
            this._userID = Guid.NewGuid();
            
            Console.WriteLine("- User constructor usage message -");
        }

    }
}
