using System;
using System.Collections.Generic;
using System.Text;

namespace Console_EStudy
{
    public class Course
    {
        private Guid _courseID;
        private string _courseName;
        private string _courseDescription;
        private DateTime _startDate;
        private DateTime _endDate;
        private List<string> _chapters;
        public Course()
        {
            this._courseID = Guid.NewGuid();
            this._courseDescription = "Course Description";
            this._startDate = DateTime.Today;
            this._startDate = DateTime.Today;
            this._chapters = new List<string>() { "Chaper 1", "Chapter 2" };
            Console.WriteLine("Course instance was created automatically");
        }
    }
}
