   M S B A M L   `   `   `  ����>  :HCI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:HCIHCI  5   	       HCI.TabelaTipova   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:HCI     5   	     � Title$  Tabela tipova��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��430��6D   $	��750��6Q   
����İ� � 
ResizeMode$ NoResize=�6y    � Icon$ icon-power-plant-home.ico��6�    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$ ApplicationCommands.Help��5
      6<   .��5      �  � RowDefinitions 5   
   �� 5      $
��228* �6   �� 5      $
��127* �6   �� 5      $��46 �6   .+�5   
   �� $��2��6   $��0��6"   
�������$��1q�6B   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGridTipovi��5      $��0��6)      AutoGenerateColumns .     
IsReadOnly . 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Oznaka��6%      FontSize$ 16Q�65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *
OznakaTipa+6d     5      $	
 Ime��6%   $ 16Q�62    6@   �� *	ImeTipa+6^     5      $

 Opis��6%   $ 16Q�63    6A   �� *
OpisTipa+6`     5      $
 Ikonica��6%   $ 16Q�66    6D   �� *IkonicaTipa+6f   5      �� 5L   
   -   5        $��TTbtnIzmena��5L      $��2��6>   $��Center=�6K   $��264,5,377,11q�6f   $��16(�6}   $��30��6�   .��6�   Izmeni6�   �� 5M   
   -   5        $��TTbtnObrisi��5M      $��2��6>   $��Center=�6K   $��389,5,252,11q�6f   $��16(�6}   $��30��6�   .��6�   Obrisi6�   �� 5N   
   -   5        $��
TTpomocBtn��5N      $��2��6<   $��631,5,10,11q�6I   $��16(�6^   .��6l   Pomoc6s   5O      5P      