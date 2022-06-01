using Prüfungs_Ergebnis_Rechner.DisplayModels;
using PrüfungsErgebnisRechner.Library;
using PrüfungsProjekt;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prüfungs_Ergebnis_Rechner
{
    /// <summary>
    /// Interaction logic for AddPrüflingWindow.xaml
    /// </summary>
    public partial class AddPrüflingWindow : Window
    {
        private Ausbildungen AusbildungsBeruf = Ausbildungen.Fachinformatiker;
        public AddPrüflingWindow()
        {
            InitializeComponent();
            BerufSlectorW2.ItemsSource = ExamPreparer.GetListOfAusbildungen();
        }

        private void Hinzufügen(object sender, RoutedEventArgs e)
        {
            var id = uint.Parse(PNrI.Text);
            var nachName = NnI.Text;
            var vorName = VnI.Text;
            Pupil pupil = new Pupil(AusbildungsBeruf, nachName, vorName, id);
            var berufe = new List<Beruf>(DisplayedObjects.Berufe);
            var beruf = berufe.Find(x => x.Name == AusbildungsBeruf.ToString());
            beruf.AddPupil(pupil);
            if(beruf.Name == AusbildungsBeruf.ToString())
            {
                DisplayedObjects.DisplayedPupils.Add(pupil);
            }
            this.Close();
        }

        private void BerufSlectorW2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var beruf = BerufSlectorW2.SelectedItem as string;

            switch (beruf)
            {
                case "Fachinformatiker":
                    AusbildungsBeruf = Ausbildungen.Fachinformatiker;
                    break;
                case "Kaufmann_Digitalisierung":
                    AusbildungsBeruf = Ausbildungen.Kaufmann_Digitalisierung;
                    break;
                case "System_Management":
                    AusbildungsBeruf= Ausbildungen.System_Management;
                    break;
                case "System_Elektroniker":
                    AusbildungsBeruf = Ausbildungen.System_Elektroniker;
                    break;
            }
        }
    }
}
