   M S B A M L   `   `   `  ����U  QPrüfungs-Ergebnis-Rechner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Prüfungs_Ergebnis_RechnerPrüfungs_Ergebnis_Rechner  5   	   3    -Prüfungs_Ergebnis_Rechner.AddPrüflingWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Prüfungs_Ergebnis_Rechner     5   	     � Title$  AddPrüflingWindow��5   	   $	��400��6#   $	��400��60   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Prüflings Nr.��6!   $��Center=�66   �� 5   
   -   5         ��Name$
 PNrI��5      $��0��6    $��50 20q�6-   �� 5   
   $��1��6   $��Nachname��6!   $��Center=�61   �� 5   
   -   5        $	 NnI��5      $��1��6   $��50 20q�6,   �� 5   
   $��2��6   $��Vorname��6!   $��Center=�60   �� 5   
   -   5        $	 VnI��5      $��2��6   $��50 20q�6,   �� 5   
   $��3��6   $��Ausbildungsberuf��6!   $��Center=�69   �� 5   
   -   5         ��Name$ BerufSlectorW2��5   X    �� SelectedIndex$ 0��6   $��3��6�   $��Center=�6�   $��	10,5,10,0q�6�   $	��180��6�   $��30��6�   ��6p   �� *
nameList+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6$   �� 5      5      5       �� 5!   
   -   5        $��4��5!      $	��100��6   $��30��6*   $��Hinzufügen��66   6K   5"      5#      