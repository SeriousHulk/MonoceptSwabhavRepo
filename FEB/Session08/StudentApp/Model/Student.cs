using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Model
{
    internal class Student
    {
        private string _name;
        private int _rollNo;
        private float _cgpa;
        private float _percentage;
        private const float PERCENT_CONVERT = 9.5f;
        public Student(string name, int rollNo, float cgpa)
        {
            _name = ValidateName(name);
            _rollNo = ValidateRollNo(rollNo);
            _cgpa = ValidateCgpa(cgpa);
            _percentage = CalculatePercentage(_cgpa);
        }
        public Student(string name, int rollNo, float cgpa, float percentage)
        {
            _name = ValidateName(name);
            _rollNo = ValidateRollNo(rollNo);
            _cgpa = ValidateCgpa(cgpa);
            _percentage = CalculatePercentage(_cgpa);
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int RollNo
        {
            get { return _rollNo; }
            set { _rollNo = value; }
        }
        public float Cgpa
        {
            get { return ValidateCgpa(_cgpa); }
            set { _cgpa = value; }
        }
        public float Percentage
        {
            get { return _percentage; }
        }
        public float CalculatePercentage(float cgpa)
        {
            float percentage = cgpa * PERCENT_CONVERT;
            return percentage;
        }
        public string ValidateName(string name)
        {
            if (name.Length > 5)
            {
                return name;
            }
            else { return string.Empty; }
        }
        public int ValidateRollNo(int rollNo)
        {
            if (rollNo < 0)
            {
                throw new Exception("Roll no. not in Range");
            }
            else if (rollNo > 100)
            {
                throw new Exception("Roll no. not in Range");
            }
            else return rollNo;
        }
        public float ValidateCgpa(float cgpa)
        {
            if (cgpa > 10.0f)
            {
                throw new Exception("CGPA greater than allowed range");
            }
            else if (cgpa < 0.0f)
            {
                throw new Exception("CGPA lesser than allowed range");
            }
            else
                _percentage = CalculatePercentage(cgpa);
            return cgpa;
        }
    }
}
