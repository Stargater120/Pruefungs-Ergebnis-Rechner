using Prüfungs_Ergebnis_Rechner.DisplayModels;
using PrüfungsProjekt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PrüfungsErgebnisRechner.Library
{
    public class Prüfungsbereich : INotifyPropertyChanged
    {
        public int Prüfungsteil { get; private set; }
        public int Bereichsteil { get; private set; }
        public int Punkte { get; private set; } = 0;
        private int _Note;
        public int Gewichtung { get; private set; }
        public Exams[] Exame { get; set; }

        public int Note
        {
            get => _Note;
        }

        public Prüfungsbereich(int prüfungsteil, int bereichsteil, int gewichtung)
        {
            Prüfungsteil = prüfungsteil;
            Bereichsteil = bereichsteil;
            Gewichtung = gewichtung;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void CalculateBereichGesamt()
        {
            var allExams = new List<Exams>(DisplayedObjects.DisplayedExams);
            var exams = allExams.FindAll(x => x.AbschlussPrüfungsTeil == Prüfungsteil && x.ExamPart == Bereichsteil);
            int gesamt = 0;
            foreach (var item in exams)
            {
                if (item.IsExtraPrüfung)
                {
                    gesamt += item.ReachedPoints / 2;
                    continue;
                }
                gesamt += item.ReachedPoints;
            }
            gesamt /= exams.Count;
            Punkte = gesamt;
            OnPropertyChanged("Punkte");
            DisplayedObjects.Pupil.SetGesamtPunktzahl();
        }

        public void CalculateNote()
        {
            int result = 6;

            if (Punkte < 30) result = 6;
            else if (Punkte < 50) result = 5;
            else if (Punkte < 67) result = 4;
            else if (Punkte < 81) result = 3;
            else if (Punkte < 92) result = 2;
            else result = 1;
            _Note = result;
            OnPropertyChanged("Note");
            DisplayedObjects.Pupil.SetFinalGrade();
        }

        public void AddExtraPrüfung()
        {
            var newExam = new Exams("Mündliche ErgenzungsPrüfung", 50, Bereichsteil, Prüfungsteil, true);
            DisplayedObjects.DisplayedExams.Add(newExam);
            OnPropertyChanged("Exame");
        }

        protected void OnPropertyChanged(string name = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
