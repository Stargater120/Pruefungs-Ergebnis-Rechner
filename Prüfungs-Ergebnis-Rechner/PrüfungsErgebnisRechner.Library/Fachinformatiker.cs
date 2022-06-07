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
                case Ausbildungen.System_Management:
                    exams.AddRange(new Exams[] { new Exams("Einrichten eines IT-gestützen Arbeitsplatzes", 20, 1), new Exams("Abwicklung eines Kundenauftrages", 50, 1), new Exams("Einführen einer IT-Systemlösung", 10, 1), new Exams("Kaufmännische Unterstützungsprozesse", 10, 1), new Exams("Wirtschafts- und Sozialkunde", 10, 1)});
                    break;
                case Ausbildungen.Kaufmann_Digitalisierung:
                    exams.AddRange(new Exams[] { new Exams("Einrichten eines IT-gestützen Arbeitsplatzes", 20, 1), new Exams("Digitale Entwicklung von Prozessen", 50, 1), new Exams("Entwicklung eines digitalen Geschäftsmodells", 10, 1), new Exams("Kaufmännische Unterstüzungsprozesse", 10, 1), new Exams("Wirtschafts- und Sozialkunde", 10, 1)});
                    break;
                case Ausbildungen.System_Elektroniker:
                    exams.AddRange(new Exams[] { new Exams("Einrichten eines IT-gestützen Arbeitsplatzes", 20, 1), new Exams("Erstellen, Ändern oder Erweitern von IT-Systemen und von deren Infrastruktur", 50, 1), new Exams("Installation von und Service an IT-Geräten, IT-Systemen und IT-Infrastrukturen", 10, 1), new Exams("Anbindung von Geräten, Systemen und Betriebsmitteln an die Stromversorgung", 10, 1), new Exams("Wirtschafts- und Sozialkunde", 10, 1)});
                    break;
            }

            return new List<Exams>();
        }
    }
}
