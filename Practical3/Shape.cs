using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    public class Shape
    {
        private int _privateField;
        protected int _protectedField;
        public int Width { get; set; }
        public int Height { get; set; }

        //overload function
        public void GetArea(int width, int height)
        {
            Console.WriteLine(width*height);
        }

        public void GetArea(string width, int height)
        {

        }
        public void GetArea(int width, string height)
        {

        }

        public void GetArea(int width, int height, int length)
        {

        }
    }

    public class Triangle : Shape
    {

        //constructor - execute when an object is created
        public Triangle()
        {
            
        }

        public void Method1()
        {
            Width = 1;
            Height = 2;
            _protectedField = 2;
        }
    }

    public class Student
    {
        //field store data
        private string _studentName;
        private int _studentId=1;

        //property will expose the field to public
        public string StudentName
        {
            get
            {
                return "BCS"+_studentId;
            }
            set
            {
                _studentName=value;
            }
        }

        //public string StudentName { get; set; }
        //public string StudentId { get; set; }
        public string FirstName { get; }
        public string LastName { get;set; }

        public int StudentId
        {
            get
            {
                return _studentId;
            }
            set
            {
                _studentId = value;
            }
        }

        public string PrintName()
        {
            Console.WriteLine(StudentName);
            return StudentName;
        }
    }

    
}
