using System;
using System.Collections.Generic;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new StudentReport("John", 40, 40, 30);
            var student2 = new StudentReport("Emanuel", 20, 15, 10);
            var student3 = new StudentReport("Stephanie", 45, 50, 50);
            List<StudentReport> list = new List<StudentReport>();
            list.Add(student1);
            list.Add(student2);
            list.Add(student3);
            CalcMark calc = new CalcMark();
            calc.ExamPass += OnExamPass;
            calc.CalcMarkOut(list);
        }
        static void OnExamPass(object sender, EventArgs e)
        {
            StudentReport student = (StudentReport)e;
            Console.WriteLine($"Congratulation {student.StudenName}! You pass the examen! Your total sum of marks is {student.TotalSumMark}\n");
        }
    }
}


