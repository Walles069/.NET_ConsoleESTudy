using System;
using System.Collections.Generic;
using System.Text;

namespace Console_EStudy
{
    public class Classroom
    {
        private CourseDatabase _courseDatabase;
        private UserDatabase _userDatabase;
        public Classroom()
        {
            Console.WriteLine("Classroom instance was created automatically");
            this._userDatabase = new UserDatabase();
            this._courseDatabase = new CourseDatabase();
        }
    }
}
