   M S B A M L   `   `   `  ����>  :HCI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:HCIHCI  5   	   clr-namespace:HCIHCI  5   	       HCI.Tip_Resursa   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:HCI     5   	   cclr-namespace:HCI     5   	     � Title$  Tip Resursa��5	   	    � WindowStartupLocation$ CenterScreen=�6   $	��430��6B   $	��750��6O   ���#81cfff � 
ResizeMode$ NoResize=�6p    � Icon$ icon-power-plant-home.ico��6�    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      � $��50, 50, 50, 20q�6    � RowDefinitions 5   
   �� 5      $��43 �6   �� 5      $��43 �6   �� 5      $��50 �6   �� 5      $��43 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $	��18* �6   .+�5   
   �� $��0��6   $��0��6!   $��Center=�61   $��Center=�6N   $��16(�6i   $��Medium"�6w   $	��110��6�   	Oznaka:6�   �� 5   
   $��1��6   $��0��6!   $��Center=�61   $��Center=�6N   $��16(�6i   $��Medium"�6w   $	��110��6�   Ime:6�   �� 5   
   $��2��6   $��0��6!   $��Center=�61   $��Center=�6N   $��16(�6i   $��Medium"�6w   $	��110��6�   
Ikonica:6�   �� 5   
   $��3��6   $��0��6!   $��Center=�61   $��Center=�6N   $��16(�6i   $��Medium"�6w   $	��110��6�   Opis:6�   �� 5    
   -   5        $��Toznaka��5       $��0��6!   $��1��6.   $��16(�6>   $��14, 8, 300, 8q�6L   6e   �� 5!   
   -   5        $
��Time��5!      $��1��6   $��1��6+   $��16(�6;   $��14, 8, 300, 8q�6I   6c   �� 5"   
   -   5        $��TbtnIkonica��5"      $��2��6>   $��1��6K   $��16(�6[   $��14,10,335,10q�6i   .��6   Odaberite ikonicu6�   �� 5#   
   -   5        $��TimgIkonica��5#      $��2��6G   $��1��6T   $
��Fill=�6d   $��48��6t   $��48��6   ��6#   ��  �� Path$ ikonicaTipa�6�   �� 5$   
   -   5        $��Topis��5$      $��3��6   $��1��6,   $��16(�6<   $��14, 8, 50, 8q�6J   6c   �� 5%   
   -   5        $��TsaveBtn��5%      $��4��68   $��1��6E   $��16(�6U   $��66,95,335,14q�6c   	 J� RenderTransformOrigin$	 0.351,0.523&�6y   .��6�   	Sacuvaj6�   �� 5&   
   -   5        $��	TcloseBtn��5&      $��4��6:   $��1��6G   $��16(�6W   $��209,95,192,14q�6e   $	 
0.243,0.48&�6|   .��6�   
Odustani6�   �� 5'   
   -	   5        $��	TpomocBtn��5'      $��1��6:   $��4��6J   $��391,95,10,14q�6W   $��16(�6m   .��6{   Pomoc6�   5(      5)      