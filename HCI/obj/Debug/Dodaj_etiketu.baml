   M S B A M L   `   `   `  ����>  :HCI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:HCIHCI  5   	       HCI.Dodaj_etiketu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:HCI     5   	   X TXceed.Wpf.Toolkit, Version=3.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Etiketa��5	   	   $	��430��6   $	��750��6&   ���#81cfff � 
ResizeMode$ NoResize=�6G    � Icon$ icon-power-plant-home.ico��6]   .��5
      � $��50, 50, 50, 20q�6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $	��18* �6   .+�5   
   �� $��0��6   $��0��6!   $��Center=�61   $��Center=�6N   $��16(�6i   $��Medium"�6w   $	��110��6�   	Oznaka:6�   �� 5   
   $��1��6   $��0��6!   $��Center=�61   $��Center=�6N   $��16(�6i   $��Medium"�6w   $	��110��6�   Boja:6�   �� 5   
   $��2��6   $��0��6!   $��Center=�61   $��Center=�6N   $��16(�6i   $��Medium"�6w   $	��110��6�   Opis:6�   �� 5   
   -   5        $��Eoznaka��5      $��0��6!   $��1��6.   $��16(�6>   $��14, 11, 300, 12q�6L   6g   #  Xceed.Wpf.Toolkit.ColorPicker  5   
   -   5        $��bojaEtikete��5      $��1��6.   $��1��6;   $��14, 11, 350, 12q�6K   6g   �� 5   
   -   5        $��Eopis��5      $��2��6   $��1��6,   $��16(�6<   $��14, 11, 50, 12q�6J   6e   �� 5   
   -   5        $��EsaveBtn��5      $��3��68   $��1��6E   $��16(�6U   $��66,124,335,14q�6c    J� RenderTransformOrigin$ 0.351,0.523&�6z   .��6�   	Sacuvaj6�   �� 5    
   -   5        $��	EcloseBtn��5       $��3��6:   $��1��6G   $��16(�6W   $��209,124,192,14q�6e   $ 
0.243,0.48&�6}   .��6�   
Odustani6�   5"      5#      