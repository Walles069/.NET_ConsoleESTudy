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

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public Guid UserID 
        {
            get { return _userID; }
            set { }
        }
        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { }
        }

        public User()
        {
            this._name = "Name";
            this._surname = "Surname";
            this._userID = Guid.NewGuid();
            
            Console.WriteLine("- User constructor usage message -");
        }
        public User(string name, string surname, Guid ID, bool isadmin)
        {
            this._name = "Name";
            this._surname = "Surname";
            this._userID = Guid.NewGuid();

            Console.WriteLine("- User overloaded constructor usage message -");
        }
    }
}
