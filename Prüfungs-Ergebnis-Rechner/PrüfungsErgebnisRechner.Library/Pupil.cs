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
        public List<Exams> Noten { get; private set; }

        public void Fachrichtung(Ausbildungen ausbildungen)
        {
            Noten = ExamPreparer.PrepareExams(ausbildungen);
        }
    }
}
