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
                    
                    new Pupil{ID = 0, Name = "User1", Vorname = "Tester1"},
                    new Pupil{ID = 1, Name = "User2", Vorname = "Tester2"},
                    new Pupil{ID = 2, Name = "User3", Vorname = "Tester3"},
                    new Pupil{ID = 3, Name = "User4", Vorname = "Tester4"},
                    new Pupil{ID = 4, Name = "User5", Vorname = "Tester5"},
                    new Pupil{ID = 5, Name = "User6", Vorname = "Tester6"},
                    new Pupil{ID = 6, Name = "User7", Vorname = "Tester7"},
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
