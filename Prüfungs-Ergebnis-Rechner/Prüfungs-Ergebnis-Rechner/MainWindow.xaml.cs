using Prüfungs_Ergebnis_Rechner.Display_Lists;
using Prüfungs_Ergebnis_Rechner.DisplayModels;
using PrüfungsErgebnisRechner.Library;
using PrüfungsProjekt;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.IO;
using System.Windows.Input;

namespace Prüfungs_Ergebnis_Rechner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly JsonFile jsonFile = new JsonFile();
        private readonly Beruf beruf = new Beruf();
        public MainWindow()
        {
            InitializeComponent();
            BerufSlector.ItemsSource = ExamPreparer.GetListOfAusbildungen();
            Tester_Liste.ItemsSource = DisplayedObjects.DisplayedPupils;
        }

        private void OpenAddPrüfling(object sender, RoutedEventArgs e)
        {
            AddPrüflingWindow Window2 = new AddPrüflingWindow();
            Window2.VnI.Text = "";
            Window2.PNrI.Text = "";
            Window2.NnI.Text = "";
            Window2.Show();
        }

        private void BerufSlector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   if(DisplayedObjects.Berufe.Count > 0)
            {
                beruf.FillPupilsList(BerufSlector.SelectedItem as string);
                Tester_Liste.ItemsSource = DisplayedObjects.DisplayedPupils;
                DisplayedObjects.AusgewählterBeruf = BerufSlector.SelectedItem as string;
            }
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\..\..\"));
            saveFileDialog.ShowDialog();
            string path = saveFileDialog.FileName;
            jsonFile.Save(path);
        }

        private void Tester_Liste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Tester_Liste.SelectedItem != null)
            {
                DisplayedObjects.Pupil = (Pupil)Tester_Liste.SelectedItem;
                DisplayedObjects.DisplayedExams = new ObservableCollection<Exams>(DisplayedObjects.Pupil.GetExams());
                DisplayedObjects.DisplayPrüfungsbereiche = new ObservableCollection<Prüfungsbereich>(DisplayedObjects.Pupil.Prüfungsbereiche);
                ErgebnisListe.ItemsSource = DisplayedObjects.DisplayPrüfungsbereiche;
                BerechnungsFeld.ItemsSource = DisplayedObjects.DisplayedExams;
                DisplayedObjects.ListForOne.Clear();
                DisplayedObjects.ListForOne.Add(DisplayedObjects.Pupil);
                Ergebnisse.ItemsSource = DisplayedObjects.ListForOne;
            }
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\..\..\"));
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == true)
            {
                DisplayedObjects.FilePath = openFileDialog.FileName;
                jsonFile.Load(openFileDialog.FileName);
                beruf.FillPupilsList("Fachinformatiker");
                Tester_Liste.ItemsSource = DisplayedObjects.DisplayedPupils;
                
            }
        }

        private void ExtraHinzufügen(object sender, RoutedEventArgs e)
        {
            ExtraPrüfungsWindow epw = new ExtraPrüfungsWindow();
            epw.Show();
            epw.PrüfungsSelector.ItemsSource = DisplayedObjects.GetExtraprüfungsNamen();
        }
    }
}
