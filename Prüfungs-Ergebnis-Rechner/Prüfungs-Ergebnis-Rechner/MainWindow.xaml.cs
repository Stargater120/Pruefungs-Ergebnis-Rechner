using Prüfungs_Ergebnis_Rechner.Display_Lists;
using Prüfungs_Ergebnis_Rechner.DisplayModels;
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
        public MainWindow()
        {
            InitializeComponent();
            var test = new PrüflingsListModel();
            var ergebnisse = new ResultList();
            Tester_Liste.ItemsSource = test.Pupils;
            ReachedPointsList.ItemsSource = ergebnisse.GetTextBoxList();
        }
    }
}
