using System;
using System.Collections.Generic;
using System.Text;

namespace PrüfungsProjekt
{
    public class Pupil
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public Exams[] Noten { get; private set; }

        public Pupil(Ausbildungen ausbildungen, string name, string vorname, uint id)
        {
            Noten = ExamPreparer.PrepareExams(ausbildungen);
            Name = name;
            Vorname = vorname;
            ID = id;
        }
    }
}
