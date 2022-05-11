﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PrüfungsProjekt
{
    public class Exams
    {
        public string Name { get; private set; }
        public int Gewichtung { get; private set; }
        private int reached { get; set; }
        public int ReachedPoints { get => reached; set { if (value < 0) reached = 0; else if (value > 100) reached = 100; else reached = value; } }
        public int ExamPart { get; private set; }
        public int Grade { get => GetGrade(); }

        private int GetGrade ()
        {
            int result = 6;

            if (ReachedPoints < 30) result = 6;
            else if (ReachedPoints < 50) result = 5;
            else if (ReachedPoints < 67) result = 4;
            else if (ReachedPoints < 81) result = 3;
            else if (ReachedPoints < 92) result = 2;
            else result = 1;

            return result;
        }
        public Exams(string name, int gewichtung, int exampart)
        {

            Name = name;
            Gewichtung = gewichtung;
            ExamPart = exampart;
        }

        public static int Result(Exams[] exams)
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
