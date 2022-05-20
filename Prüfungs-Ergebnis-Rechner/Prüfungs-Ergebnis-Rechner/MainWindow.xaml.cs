using Prüfungs_Ergebnis_Rechner.Display_Lists;
using Prüfungs_Ergebnis_Rechner.DisplayModels;
using PrüfungsProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prüfungs_Ergebnis_Rechner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string AusgewählterBeruf { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            var test = new PrüflingsListModel();
            var ergebnisse = new ResultList();
            ergebnisse.PopulateDisplaiedList();
            Tester_Liste.ItemsSource = test.Pupils;
            ReachedPointsList.ItemsSource = ergebnisse.DisplaiedList;
            PrüfungsNamenListe.ItemsSource = ergebnisse.DisplaiedList;
            GradeList.ItemsSource = ergebnisse.DisplaiedList;
            BerufSlector.ItemsSource = ExamPreparer.GetListOfAusbildungen();
        }

        private void OpenAddPrüfling(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_Selected(object sender, RoutedEventArgs e)
        {
            //AusgewählterBeruf = SelectItem.
        }
    }
}
