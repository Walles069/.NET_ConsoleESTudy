using System;
using System.Collections.Generic;
using System.Text;

namespace Console_EStudy
{
    public class CourseDatabase
    {
        private List<Course> _courseList;
        public CourseDatabase()
        {
            Console.WriteLine("CourseDatabse instance was created automatically");
            this._courseList = new List<Course>() { new Course() };
            
        }
    }
}
