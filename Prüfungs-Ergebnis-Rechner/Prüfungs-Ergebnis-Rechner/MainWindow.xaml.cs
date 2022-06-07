using Prüfungs_Ergebnis_Rechner.Display_Lists;
using Prüfungs_Ergebnis_Rechner.DisplayModels;
using PrüfungsErgebnisRechner.Library;
using PrüfungsProjekt;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.IO;

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
        {   
            beruf.FillPupilsList(BerufSlector.SelectedItem as string);
            Tester_Liste.ItemsSource = DisplayedObjects.DisplayedPupils;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            jsonFile.Save(DisplayedObjects.FilePath);
        }

        private void Tester_Liste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Tester_Liste.SelectedItem != null)
            {
                DisplayedObjects.Pupil = (Pupil)Tester_Liste.SelectedItem;
                DisplayedObjects.DisplayedExams = new ObservableCollection<Exams>(DisplayedObjects.Pupil.Noten);
                ErgebnisListe.ItemsSource = DisplayedObjects.DisplayedExams;
                BerechnungsFeld.ItemsSource = DisplayedObjects.DisplayedExams;
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
                BerufSlector.ItemsSource = ExamPreparer.GetListOfAusbildungen();
            }
                
            
        }
    }
}
