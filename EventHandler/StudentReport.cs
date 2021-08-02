using System;

namespace Event
{
    class StudentReport : EventArgs
    {
        private string studentName;
        private float englishMark;
        private float mathMark;
        private float computerMark;
        private float totalSumMark;
        public StudentReport(string name, int english, int math, int computer)
        {
            this.studentName = name;
            this.englishMark = english;
            this.mathMark = math;
            this.computerMark = computer;
            this.totalSumMark = englishMark + mathMark + computerMark;
        }
        public string StudenName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }
        public float EnglishMark
        {
            get
            {
                return englishMark;
            }
            set
            {
                englishMark = value;
            }
        }
        public float MathMark
        {
            get
            {
                return mathMark;
            }
            set
            {
                mathMark = value;
            }
        }
        public float ComputerMark
        {
            get
            {
                return computerMark;
            }
            set
            {
                computerMark = value;
            }
        }
        public float TotalSumMark
        {
            get
            {
                return totalSumMark;
            }
            set
            {
                totalSumMark = value;
            }
        }
    }
}


