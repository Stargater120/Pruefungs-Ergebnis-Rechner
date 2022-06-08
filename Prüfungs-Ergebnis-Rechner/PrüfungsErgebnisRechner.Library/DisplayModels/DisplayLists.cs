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
        public static ObservableCollection<Prüfungsbereich> DisplayPrüfungsbereiche = new ObservableCollection<Prüfungsbereich>();
        public static ObservableCollection<Pupil> ListForOne = new ObservableCollection<Pupil>();
        public static Pupil Pupil;
        public static string FilePath;
        public static string AusgewählterBeruf = "Fachinformatiker";

        public static List<string> GetExtraprüfungsNamen()
        {
            var nameList = new List<string>();

            switch (AusgewählterBeruf)
            {
                case "Fachinformatiker":
                    nameList.Add("Planen eines Softwareproduktes");
                    nameList.Add("Entwicklung und Umsetzung von Algorithmen");
                    nameList.Add("Wirtschafts und Sozialkunde");
                    break;
                case "Kaufmann_Digitalisierung":
                    break;
                case "System_Management":
                    break;
                case "System_Elektroniker":
                    break;
            }
            return nameList;
        }
    }
}
