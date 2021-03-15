using System;
using System.Collections.Generic;
using System.Text;

namespace Console_EStudy
{
    public class Employee : User
    {
        private List<string> _certificates;
        private List<Guid> _attendingCourses;

        public List<string> Certificates
        {
            get { return _certificates; }
            set { _certificates = value; }
        }
        public List<Guid> AttendingCourses
        {
            get { return _attendingCourses; }
            set { _attendingCourses = value; }
        }

        public Employee() : base()
        {
            this._certificates = new List<string>() { "Certificate 1", "Certificate 2" };
            this._attendingCourses = new List<Guid>();
            Console.WriteLine("- Employee constructor usage message -");

        }
        public Employee(string name, string surname, Guid userID, bool isAdmin, List<string> certificates, List<Guid> courses) 
            : base(name, surname, userID, isAdmin)
        {
            this._certificates = certificates;
            this._attendingCourses = courses;
            Console.WriteLine("- Employee overloaded constructor usage message -");

        }
    }
}
