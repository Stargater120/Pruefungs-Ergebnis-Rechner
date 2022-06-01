using Newtonsoft.Json;
using Prüfungs_Ergebnis_Rechner.DisplayModels;
using PrüfungsProjekt;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace PrüfungsErgebnisRechner.Library
{
    public class JsonFile
    {
        public Beruf[] Berufe { get; set; }

        public void Save(string path)
        {
            var name = path.Substring(path.LastIndexOf("/"));
            StoreManager.Store(Berufe, path, name);
        }

        public void Load(string path)
        {
            Berufe = StoreManager.ReadFile(path);
            DisplayedObjects.Berufe = new ObservableCollection<Beruf>(Berufe);
            //FillBerufeWithPlaceholder();
        }

        private void FillBerufeWithPlaceholder()
        {
            var berufeNummer = Enum.GetNames(typeof(Ausbildungen)).Length;
            Berufe = new Beruf[berufeNummer];
            var berufe = Enum.GetNames(typeof(Ausbildungen));
            for (int i = 0; i < berufeNummer; i++)
            {
                Berufe[i].Name = berufe[i];
            }
        }
    }
}
