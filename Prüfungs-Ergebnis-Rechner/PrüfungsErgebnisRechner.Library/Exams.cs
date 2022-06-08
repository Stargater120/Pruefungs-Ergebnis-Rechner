using Prüfungs_Ergebnis_Rechner.DisplayModels;
using PrüfungsErgebnisRechner.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PrüfungsProjekt
{
    public class Exams : INotifyPropertyChanged
    {
        public string Name { get; private set; }
        public int Gewichtung { get; private set; }
        private int _ReachedPoints;
        public int ExamPart { get; private set; }
        public int Grade { get => GetGrade(); }
        public int AbschlussPrüfungsTeil { get; set; }
        public bool IsExtraPrüfung { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public int ReachedPoints
        {
            get => _ReachedPoints;
            set
            {
                if (value < 0) _ReachedPoints = 0; else if (value > 100) _ReachedPoints = 100; else _ReachedPoints = value;
                //if(IsExtraPrüfung)
                //    _ReachedPoints /= 2;
                GetGrade();
                OnPropertyChanged("ReachedPoints");
                OnPropertyChanged("Grade");
                EmitChange();
            }
        }

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
        public Exams(string name, int gewichtung, int exampart, int apt, bool isExtraPrüfung = false)
        {

            Name = name;
            Gewichtung = gewichtung;
            ExamPart = exampart;
            AbschlussPrüfungsTeil = apt;
            IsExtraPrüfung = isExtraPrüfung;
        }

        private void EmitChange()
        {
            var bereiche = new List<Prüfungsbereich>(DisplayedObjects.DisplayPrüfungsbereiche);
            var bereich = bereiche.Find(x => x.Prüfungsteil == AbschlussPrüfungsTeil && x.Bereichsteil == ExamPart);
            bereich.CalculateBereichGesamt();
            bereich.CalculateNote();
        }

        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
