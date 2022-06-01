using PrüfungsErgebnisRechner.Library;
using PrüfungsProjekt;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Prüfungs_Ergebnis_Rechner.DisplayModels
{
    public static class DisplayedObjects
    {
        public static ObservableCollection<Beruf> Berufe = new ObservableCollection<Beruf>();
        public static ObservableCollection<Pupil> DisplayedPupils = new ObservableCollection<Pupil>();
        public static ObservableCollection<Exams> DisplayedExams = new ObservableCollection<Exams>();
        public static Pupil Pupil;
        public static string FilePath; 
    }
}
