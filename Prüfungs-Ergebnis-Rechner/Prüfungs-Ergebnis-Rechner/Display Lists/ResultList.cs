using PrüfungsProjekt;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace Prüfungs_Ergebnis_Rechner.Display_Lists
{
    public class ResultList
    {
        private ObservableCollection<Exams> _DisplaiedList = new ObservableCollection<Exams>();

        public void PopulateDisplaiedList()
        {
            var examArray = ExamPreparer.PrepareExams(Ausbildungen.Fachinformatiker);
            foreach (var item in examArray)
            {
                _DisplaiedList.Add(item);
            }
        }

        public ObservableCollection<Exams> DisplaiedList
        {
            get
            {
                return _DisplaiedList;
            }
        }
    }
}
