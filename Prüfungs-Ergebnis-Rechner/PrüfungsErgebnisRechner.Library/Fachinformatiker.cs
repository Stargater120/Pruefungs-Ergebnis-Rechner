using System;
using System.Collections.Generic;
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
        public static List<Exams> PrepareExams(Ausbildungen ausbildung)
        {
            List<Exams> exams = new List<Exams>();
            switch (ausbildung)
            {
                case Ausbildungen.Fachinformatiker:
                    exams.AddRange(new Exams[] { new Exams("Einrichten eines IT-geschützten Arbeitsplatzes", 20, 1), new Exams("Planen eines Softwareproduktes", 10, 2), new Exams("Entwicklung und Umsetzung von Algorithmen", 10, 2), new Exams("Wirtschafts- und Sozialkunde", 10, 2), new Exams("Betriebliche Projektarbeit", 50, 2), new Exams("Präsentation und Fachgespräch", 50, 2), new Exams("Planen und Umsetzen eines Softwareprojekts", 50, 2) });
                    break;
                case Ausbildungen.Kaufmann_Digitalisierung:
                    exams.AddRange(new Exams[] { });
                    break;
                case Ausbildungen.System_Management:
                    exams.AddRange(new Exams[] { });
                    break;
                case Ausbildungen.System_Elektroniker:
                    exams.AddRange(new Exams[] { });
                    break;
            }

            return new List<Exams>();
        }
    }
}
