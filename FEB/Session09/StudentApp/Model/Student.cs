using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Model
{
    internal class Student
    {
        private string name;
        private int rollNo;
        private float cgpa;
        private float percentage;
        private int remainingFee;
        private int totalFees;
        private const float PERCENT_CONVERT = 9.5f;
        public Student(string name, int rollNo, float cgpa, int remainingFee) 
        {
            this.name = ValidateName(name);
            this.rollNo = ValidateRollNo(rollNo);
            this.cgpa = ValidateCgpa(cgpa);
            this.remainingFee = remainingFee;
            percentage = CalculatePercentage(this.cgpa);
        }
        public Student(string name, int rollNo, float cgpa, int remainingFee, float percentage) 
        {
            this.name = ValidateName(name);
            this.rollNo = ValidateRollNo(rollNo);
            this.cgpa = ValidateCgpa(cgpa);
            this.percentage = CalculatePercentage(this.cgpa);
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }
        public float Cgpa
        {
            get { return ValidateCgpa(cgpa); }
            set { cgpa = value; }
        }
        public float Percentage
        {
            get { return percentage; }
        }
        public int TotalFees
        {
            get { return totalFees; }
            set { totalFees = value; }
        }
        public int RemainingFee
        {
            get { return remainingFee; }
            set { remainingFee = value; }
        }
        public void PayFees(int amount, Student student)
        {
            if (amount > RemainingFee)
            {
                Console.WriteLine($"Invalid amount. Please pay remaining fee of {RemainingFee}.");
            }
            else
            {
                RemainingFee -= amount;
                Console.WriteLine($"{student.Name} paid {amount}. Remaining fee: {RemainingFee}.");
            }
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
                percentage = CalculatePercentage(cgpa);
            return cgpa;
        }

    }
}
