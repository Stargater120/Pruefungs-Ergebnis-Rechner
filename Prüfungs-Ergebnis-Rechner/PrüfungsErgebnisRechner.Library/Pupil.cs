using Prüfungs_Ergebnis_Rechner.DisplayModels;
using PrüfungsErgebnisRechner.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PrüfungsProjekt
{
    public class Pupil : INotifyPropertyChanged
    {
        public uint ID { get; private set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        //public Exams[] Noten { get; private set; }
        public Prüfungsbereich[] Prüfungsbereiche { get; set; }
        public bool IsSuccesfull { get => GetIsSuccesFull(); }
        public bool NeedsExtraTest { get; set; }
        public string Ergebnis { get => GetErgebnis(); }
        private int _EndNote = 6;
        private int _GesamtPunktzahl = 0;

        public Pupil(Ausbildungen ausbildungen, string name, string vorname, uint id)
        {
            Prüfungsbereiche = ExamPreparer.PreparePrüfungsbereiche(ausbildungen);
            Name = name;
            Vorname = vorname;
            SetId(id);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string EndNote
        {
            get => $"Note: {_EndNote}";
            set
            {
                _EndNote = int.Parse(value);
                OnPropertyChanged("EndNote");
                OnPropertyChanged("Ergebnis");
            }
        }

        public string GesamtPunktzahl
        {
            get
            {
                var ergebnis = (int)Math.Round((double)_GesamtPunktzahl / 100);
                return $"Gesamt Punktzahl: {ergebnis}";
            }    
        }
        //(int)Math.Round((double)ergebnis / 100);
        public void Add(Pupil pupil)
        {
            DisplayedObjects.DisplayedPupils.Add(pupil);
        }

        public void SetFinalGrade()
        {
            var result = _GesamtPunktzahl;
            var points = (int) Math.Round((double) result / 100);

            int resultNote = 6;

            if (points < 30) resultNote = 6;
            else if (points < 50) resultNote = 5;
            else if (points < 67) resultNote = 4;
            else if (points < 81) resultNote = 3;
            else if (points < 92) resultNote = 2;
            else resultNote = 1;

            EndNote = $"{resultNote}";
            //OnPropertyChanged("EndNote");
        }

        private void SetId(uint id)
        {
            if(id == 0 || id < 0) throw new ArgumentOutOfRangeException("id ist nicht in einem korrekten format");


            ID = id;
        }

        public void SetGesamtPunktzahl()
        {
            var ergebnis = 0;
            foreach (var bereich in Prüfungsbereiche)
            {
                ergebnis += bereich.Punkte * bereich.Gewichtung;
            }

            _GesamtPunktzahl = ergebnis;
            OnPropertyChanged("GesamtPunktzahl");
        }

        private string GetErgebnis()
        {
            if (IsSuccesfull)
                return "Bestanden";

            return "nicht Bestanden";
        }

        private bool GetIsSuccesFull()
        {
            var allExams = new List<Exams>(DisplayedObjects.DisplayedExams);
            var alleNoten = new List<int>();
            foreach (var exam in allExams)
            {
                alleNoten.Add(exam.Grade);
            }
            var containsSix = alleNoten.Contains(6);
            if (containsSix)
            {
                return false;
            }

            if (_GesamtPunktzahl < 4960)
                return false;

            return true;
        }

        public List<Exams> GetExams()
        {
            var list = new List<Exams>();
            foreach (var bereich in Prüfungsbereiche)
            {
                list.AddRange(bereich.Exame);
            }

            return list;
        }

        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
