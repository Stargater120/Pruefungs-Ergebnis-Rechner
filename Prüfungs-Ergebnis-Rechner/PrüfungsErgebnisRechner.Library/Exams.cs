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
        public int BereichGesamt { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public int ReachedPoints
        {
            get => _ReachedPoints;
            set
            {
                if (value < 0) _ReachedPoints = 0; else if (value > 100) _ReachedPoints = 100; else _ReachedPoints = value;
                GetGrade();
                OnPropertyChanged("ReachedPoints");
                OnPropertyChanged("Grade");
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
        public Exams(string name, int gewichtung, int exampart, int apt)
        {

            Name = name;
            Gewichtung = gewichtung;
            ExamPart = exampart;
            AbschlussPrüfungsTeil = apt;
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

        public void SetBereichGesamt(int value)
        {
            if(value < 0) { value = 0; }
            if(value > 100) { value = 100; }
            BereichGesamt = value;
        }

        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
