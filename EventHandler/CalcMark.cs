using System;
using System.Collections.Generic;

namespace Event
{
    class CalcMark
    {
        public event EventHandler ExamPass;
        private readonly List<StudentReport> list = new List<StudentReport>();
        public void CalcMarkOut(List<StudentReport> list)
        {
            foreach (var item in list)
            {
                if (item.TotalSumMark >= 75)
                {
                    if (ExamPass != null)
                    {
                        ExamPass(this, item);
                    }
                }
                else
                {
                    Console.WriteLine($"Student {item.StudenName}, you didn't pass the exam! Your total sum of marks is {item.TotalSumMark}.\n  ");
                }
            }
        }
    }
}


