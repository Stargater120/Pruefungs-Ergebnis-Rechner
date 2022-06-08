using PrüfungsErgebnisRechner.Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PrüfungsProjekt
{
    public enum Ausbildungen
    {
        Fachinformatiker,
        Kaufmann_Digitalisierung,
        System_Management,
        System_Elektroniker
    }

    public static class ExamPreparer
    {
        public static Exams[] PrepareExams(Ausbildungen ausbildung)
        {
            Exams[] exams;
            switch (ausbildung)
            {
                case Ausbildungen.Fachinformatiker:
                    exams = new Exams[] { new Exams("Einrichten eines IT-geschützten Arbeitsplatzes", 20, exampart: 0, apt: 1, false), new Exams("Betriebliche Projektarbeit", 50, 1, 2, false), new Exams("Präsentation und Fachgespräch", 50,1, 2, false), new Exams("Planen eines Softwareproduktes", 10, 2, 2, false), new Exams("Entwicklung und Umsetzung von Algorithmen", 10, 3, 2, false), new Exams("Wirtschafts- und Sozialkunde", 10, 4, 2, false) };
                    break;
                case Ausbildungen.Kaufmann_Digitalisierung:
                    exams = new Exams[] { };
                    break;
                case Ausbildungen.System_Management:
                    exams = new Exams[] { };
                    break;
                case Ausbildungen.System_Elektroniker:
                    exams = new Exams[] { };
                    break;
                default: throw new NotImplementedException("Dieser Fall exisitert nicht");
            }
            return exams;
        }

        public static Prüfungsbereich[] PreparePrüfungsbereiche(Ausbildungen ausbildungen)
        {
            var exams = new List<Exams>(PrepareExams(ausbildungen));
            var prüfungsbereiche = new List<Prüfungsbereich>();
            do
            {
                var exame = exams.FindAll(x => x.AbschlussPrüfungsTeil == exams[0].AbschlussPrüfungsTeil && x.ExamPart == exams[0].ExamPart);
                var bereich = new Prüfungsbereich(exams[0].AbschlussPrüfungsTeil, exams[0].ExamPart, exams[0].Gewichtung);
                bereich.Exame = exame.ToArray();
                exams.RemoveAll(x => x.AbschlussPrüfungsTeil == exame[0].AbschlussPrüfungsTeil && x.ExamPart == exame[0].ExamPart);
                prüfungsbereiche.Add(bereich);
            } while (exams.Count > 0);

            return prüfungsbereiche.ToArray();
        }

        public static ObservableCollection<string> GetListOfAusbildungen()
        {
            var nameList = new ObservableCollection<string>();
            foreach (var name in Enum.GetNames(typeof(Ausbildungen)))
            {
                nameList.Add(name);
            }

            return nameList;
        }
    }
}
