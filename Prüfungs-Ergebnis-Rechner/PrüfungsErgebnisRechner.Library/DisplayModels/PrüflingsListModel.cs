using PrüfungsProjekt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Prüfungs_Ergebnis_Rechner.DisplayModels
{
    public class PrüflingsListModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public List<Pupil> Pupils
        {
            get
            {
                return new List<Pupil>
                {

                    new Pupil(Ausbildungen.Fachinformatiker,"User1User1","Tester1", 0),
                    new Pupil(Ausbildungen.Fachinformatiker,"User1","Tester1", 0),
                    new Pupil(Ausbildungen.Fachinformatiker,"User1","Tester1", 0),
                    new Pupil(Ausbildungen.Fachinformatiker,"User1","Tester1", 0),
                    new Pupil(Ausbildungen.Fachinformatiker,"User1","Tester1", 0),
                    new Pupil(Ausbildungen.Fachinformatiker,"User1","Tester1", 0),
                    new Pupil(Ausbildungen.Fachinformatiker,"User1","Tester1", 0),
                    new Pupil(Ausbildungen.Fachinformatiker,"User1","Tester1", 0),
                };
            }
            set
            {
                
            }
        }

        public void LoadList()
        {

        }


    }
}
