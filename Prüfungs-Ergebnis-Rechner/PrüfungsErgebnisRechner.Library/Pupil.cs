using Prüfungs_Ergebnis_Rechner.DisplayModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrüfungsProjekt
{
    public class Pupil
    {
        public uint ID { get; private set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public Exams[] Noten { get; private set; }
        public bool IsSuccesfull { get; set; }
        public bool NeedsExtraTest { get; set; }

        public Pupil(Ausbildungen ausbildungen, string name, string vorname, uint id)
        {
            Noten = ExamPreparer.PrepareExams(ausbildungen);
            Name = name;
            Vorname = vorname;
            ID = id;
        }

        public void Add(Pupil pupil)
        {
            DisplayedObjects.DisplayedPupils.Add(pupil);
        }

        private void SetId(uint id)
        {
            if(id == 0 || id < 0) throw new ArgumentOutOfRangeException("id ist nicht in einem korrekten format");


            ID = id;
        }

        public void CalculateBereichGesamt(Exams exam)
        {
            var exams = new List<Exams>(Noten).FindAll(x => x.AbschlussPrüfungsTeil == exam.AbschlussPrüfungsTeil && x.ExamPart == exam.ExamPart);
            int gesamt = 0;
            foreach (var item in exams)
            {
                gesamt += item.ReachedPoints;
            }
            gesamt += gesamt / exams.Count;
            foreach (var item in exams)
            {
                exam.SetBereichGesamt(gesamt);
            }
        }
    }
}
