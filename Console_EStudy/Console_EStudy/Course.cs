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

        public Guid CourseID
        {
            get { return _courseID; }
            set { }
        }
        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }
        public string CourseDescription
        {
            get { return _courseDescription; }
            set { _courseDescription = value; }
        }
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        public List<string> Chapters
        {
            get { return _chapters; }
            set { _chapters = value; }
        }

        public Course()
        {
            this._courseID = Guid.NewGuid();
            this._courseDescription = "Course Description";
            this._startDate = DateTime.Today;
            this._startDate = DateTime.Today;
            this._chapters = new List<string>() { "Chaper 1", "Chapter 2" };
            Console.WriteLine("Course instance was created automatically");
        }

        public Course(Guid id, string description, DateTime start, DateTime end, List<string> chapters)
        {
            this._courseID = id;
            this._courseDescription = description;
            this._startDate = start;
            this._startDate = end;
            this._chapters = chapters;
            Console.WriteLine("Course instance was created automatically by overloaded constructor");
        }

        public static string operator +(Course course, string val)
        {
            return course.CourseDescription + val;
        }
        public static string operator +(string val, Course course)
        {
            return val + course.CourseDescription;
        }
        public static string operator +(Course course1, Course course2)
        {
            return course1.CourseDescription + course2.CourseDescription;
        }
        public static Course operator ++(Course course)
        {
            course.EndDate.AddDays(1);
            return course;
        }
        public static bool operator <(Course course1, Course course2)
        {
            return course1.Chapters.Count < course2.Chapters.Count;
        }
        public static bool operator >(Course course1, Course course2)
        {
            return course1.Chapters.Count > course2.Chapters.Count;
        }
    }
}
