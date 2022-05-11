using PrüfungsProjekt;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace Prüfungs_Ergebnis_Rechner.Display_Lists
{
    public class ResultList
    {
        private List<Exams> _DisplaiedList = new List<Exams>();
        private List<TextBox> TextBoxes = new List<TextBox>();

        private void PopulateDisplaiedList()
        {
            for (int i = 0; i < 10; i++)
            {
                var payload = new Exams($"test{i}", i*10, i);
                _DisplaiedList.Add(payload);
            }
        }

        private void PopulateListBox()
        {
            foreach (var exam in _DisplaiedList)
            {
                TextBoxes.Add(CreateTextBox(exam));
            }
        }

        private TextBox CreateTextBox(Exams exam)
        {
            exam.ReachedPoints = 100;
            TextBox txtb = new TextBox();

            txtb.FontSize = 12;

            txtb.Width = 200;
            txtb.BorderBrush = new SolidColorBrush(Colors.Blue);

            txtb.AppendText(exam.Name);

            txtb.Background = new SolidColorBrush(Colors.Orange);

            txtb.Foreground = new SolidColorBrush(Colors.Black);

            return txtb;
        }

        public List<TextBox> GetTextBoxList()
        {
            PopulateDisplaiedList();
            PopulateListBox();
            return TextBoxes;
        }
    }
}
