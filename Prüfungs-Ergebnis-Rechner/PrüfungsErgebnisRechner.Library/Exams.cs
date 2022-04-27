using System;
using System.Collections.Generic;
using System.Text;

namespace PrüfungsProjekt
{
    public class Exams
    {
        public string Name { get; private set; }
        public int Gewichtung { get; set; }
        public int ReachedPoints { get; set; }
        public bool ExamPart { get; set; }

        public Exams(string name)
        {
            Name = name;
        }
    }
}
