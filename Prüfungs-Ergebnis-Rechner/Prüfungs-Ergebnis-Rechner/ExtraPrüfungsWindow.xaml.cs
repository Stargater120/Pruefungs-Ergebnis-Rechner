using Prüfungs_Ergebnis_Rechner.DisplayModels;
using PrüfungsErgebnisRechner.Library;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for ExtraPrüfungsWindow.xaml
    /// </summary>
    public partial class ExtraPrüfungsWindow : Window
    {
        public ExtraPrüfungsWindow()
        {
            InitializeComponent();
            
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            var expName = PrüfungsSelector.SelectedItem as string;
            var expBereichNummer = GetPrüfungsbereich(expName);
            var bereiche = new List<Prüfungsbereich>(DisplayedObjects.DisplayPrüfungsbereiche);
            bereiche.Find(x => x.Bereichsteil == expBereichNummer).AddExtraPrüfung();
            this.Close();
        }

        private int GetPrüfungsbereich(string expName)
        {
            int bereich = 0;
            switch (expName)
            {
                case "Planen eines Softwareproduktes":
                    bereich = 2;
                    break;
                case "Entwicklung und Umsetzung von Algorithmen":
                    bereich = 3;
                    break;
                case "Wirtschafts und Sozialkunde":
                    bereich = 4;
                    break;
            }

            return bereich;
        }
    }
}
