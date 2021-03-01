using System;
using System.Collections.Generic;
using System.Text;

namespace Console_EStudy
{
    public class Employee : User
    {
        private List<string> _certificates;
        private List<Guid> _attendingCourses;
        public Employee() : base()
        {
            this._certificates = new List<string>() { "Certificate 1", "Certificate 2" };
            this._attendingCourses = new List<Guid>();
            Console.WriteLine("- Employee constructor usage message -"); ;

        }
    }
}
