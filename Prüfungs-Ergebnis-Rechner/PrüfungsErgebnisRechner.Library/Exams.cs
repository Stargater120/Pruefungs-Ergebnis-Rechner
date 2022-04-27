using System;
using System.Collections.Generic;
using System.Text;

namespace PrüfungsProjekt
{
    public class Exams
    {
        public string Name { get; private set; }
        public int Gewichtung { get; private set; }
        public int ReachedPoints { get => ReachedPoints; set { if (value < 0) ReachedPoints = 0; else if (value > 100) ReachedPoints = 100; else ReachedPoints = value; } }
        public int ExamPart { get; private set; }
        public int Grade { get => GetGrade(); }

        private int GetGrade ()
        {
            int result = 6;

            if (ReachedPoints < 30) result = 6;
            else if (ReachedPoints < 50) result = 5;
            else if (ReachedPoints < 70) result = 4;
            else if (ReachedPoints < 80) result = 3;
            else if (ReachedPoints < 90) result = 2;
            else result = 1;

            return result;
        }
        public Exams(string name, int gewichtung, int exampart)
        {

            Name = name;
            Gewichtung = gewichtung;
            ExamPart = exampart;
        }

        public static int Result(List<Exams> exams)
        {
            int result = 0;
            
            foreach (Exams exam in exams)
            {
                result += exam.ReachedPoints * exam.Gewichtung;
            }

            return result;
        }
    }
}
