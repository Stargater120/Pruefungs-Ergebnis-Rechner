﻿using Prüfungs_Ergebnis_Rechner.DisplayModels;
using PrüfungsProjekt;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PrüfungsErgebnisRechner.Library
{
    public class Beruf
    {
        public string Name { get; set; }
        public Pupil[] Pupils { get; set; }

        public void Change(Pupil pupil)
        {
            var pupilList = new List<Pupil>();
            pupilList.AddRange(Pupils);
            var pupilToChange = pupilList.Find(x => x.ID == pupil.ID);

            pupilToChange = pupil;
        }

        public void FillPupilsList(string name)
        {
            var jobFieldArray = new List<Beruf>(DisplayedObjects.Berufe);
            var selectedField = jobFieldArray.Find(x => x.Name == name);
            DisplayedObjects.DisplayedPupils = new ObservableCollection<Pupil>(selectedField.Pupils);
        }

        public void AddPupil(Pupil pupil)
        {
            if(Pupils == null)
            {
                Pupils = new Pupil[0];
            }
            var pupilList = new List<Pupil>(Pupils);
            pupilList.Add(pupil);
            Pupils = pupilList.ToArray();
        }
    }
}
