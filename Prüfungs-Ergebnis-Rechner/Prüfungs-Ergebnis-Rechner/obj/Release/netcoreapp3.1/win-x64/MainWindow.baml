   M S B A M L   `   `   `  ���� U  QPrüfungs-Ergebnis-Rechner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Prüfungs_Ergebnis_RechnerPrüfungs_Ergebnis_Rechner  +    %Prüfungs_Ergebnis_Rechner.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     :local(clr-namespace:Prüfungs_Ergebnis_Rechner       � Title$  Tobias und Leon��$	��500��$
��1100��
���   �.���  � ColumnDefinitions �� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 ��� $	��100 �.+��� -    ��Name$ 
Ergebnisse��$��3��$��5��$��60��$	��Top=�$��	 0 55 0 0q�
���   �$��0q����� *Pupil+���� .R���  �� Orientation$ 
Horizontal=�.+���  ��Name$ Ergebnis��$��4��$��2��
�������$��20(�����  �� Path$ Ergebnis��� $ PunkteGesamt��$��6��$��2��$��30 0 0 0q�
�������$��20(����� $ GesamtPunktzahl��� $ 
GesamtNote��$��8��$��2��$��30 0 0 0q�
�������$��20(����� $ EndNote��� -    ��Name$ BerechnungsFeld��$��3��$��5��$	��360��$��Bottom=����� *DisplayedExams+ �� View �� .P��� $��AP�� �� Width$ 40��	 �� DisplayMemberBinding	 �� $ AbschlussPrüfungsTeil��� $��PB��$ 40��	 �� $ ExamPart��� $��Prüfungs Name��$	 260��	 �� $
 Name��� $��Punkte��$ 70��
 �� CellTemplate
 �� .R��� $��35������ $ ReachedPoints��� $
��Note��$ 70��	 �� $ Grade��� -   $ ErgebnisListe��$��8��$��3��$	��360��$��Bottom=����� *DisplayedExams+ �� .P��� $��Bereich��$	 100��	 �� $ Bereichsteil��� $��Punkte��$ 60��	 �� $ Punkte��� $
��Note��$ 60��	 �� $
 Note��� -    ��Name$ 	AddTester��$��Prüfling Hinzufügen��$��0��$��2��$��	45,5,45,0q�$	��Top=�$	��110��$��30���� -    ��Name$ BerufSlector�� �� SelectedIndex$ 0��$��2��$��2��$	��Top=�$��	10,5,10,0q�$	��180��$��30������ *
nameList+���� .R��� $ 
Horizontal=�.+��� ���� �� -   $��9��$��	Speichern��$��
18,15,17,0q�$	��Top=�$��65��$��23���� -   $��8��$��23��$��50��$��Laden��$	��Top=�$��0 15 0 0q��� -   $��6��$��2��$��23��$	��Top=�$��0 15 0 0q�$ ��Extra Prüfung hinzufügen���� -	   $ Tester_Liste��$��0��$��3��$	��360��$��Bottom=����� *Pupils+ �� .P��� $��Nr��$ 50��	 �� $ ID��� $��Nachname��$	 120��	 �� $
 Name��� $��Vorname��$	 120��	 �� $ Vorname�