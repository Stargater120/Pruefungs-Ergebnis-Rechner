using System;
using System.Collections.Generic;
using System.Text;

namespace PrüfungsProjekt
{
    class Pupil
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public List<Exams> Noten = new List<Exams>();
    }
}
