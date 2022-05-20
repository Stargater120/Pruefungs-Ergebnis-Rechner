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
                    exams = new Exams[] { new Exams("Einrichten eines IT-geschützten Arbeitsplatzes", 20, 1), new Exams("Planen eines Softwareproduktes", 10, 2), new Exams("Entwicklung und Umsetzung von Algorithmen", 10, 2), new Exams("Wirtschafts- und Sozialkunde", 10, 2), new Exams("Betriebliche Projektarbeit", 50, 2), new Exams("Präsentation und Fachgespräch", 50, 2), new Exams("Planen und Umsetzen eines Softwareprojekts", 50, 2) };
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
