using System;
using System.Collections.Generic;
using System.Text;

namespace Console_EStudy
{
    public class Administrator : User
    {
        public Administrator() : base()
        {
            Console.WriteLine("- Administrator constructor usage message -");
        }
        public Administrator(string name, string surname, Guid userID, bool isAdmin)
            : base(name, surname, userID, isAdmin)
        {
            Console.WriteLine("- Employee overloaded constructor usage message -");

        }

    }
}
