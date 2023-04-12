using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructVsClass.Model;
namespace StructVsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy1()
        {
            PointClass pointClass = new PointClass(10, 20);
            Console.WriteLine("Before Modification : ");
            pointClass.ShowPoint();
            ModifyClassValues(pointClass);
            Console.WriteLine("After Modification : ");
            pointClass.ShowPoint();
        }
        private static void CaseStudy2()
        {
            PointStruct pointStruct = new PointStruct(50, 50);
            Console.WriteLine("Before Modification : ");
            pointStruct.ShowStruct();
            ModifyStructValues(pointStruct);
            Console.WriteLine("After Modification : ");
            pointStruct.ShowStruct();
        }
        private static void ModifyStructValues(PointStruct pointStruct)
        {
            pointStruct.GetX += 100;
            pointStruct.GetY += 100;
        }
        private static void ModifyClassValues(PointClass pointClass)
        {
            pointClass.GetX += 100;
            pointClass.GetY += 100;
        }
    }
}