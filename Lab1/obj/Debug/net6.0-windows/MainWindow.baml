   M S B A M L   `   `   `  ����?  ;Lab1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab1Lab1  5   	       Lab1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab1     5   	     � Title$  
MainWindow��5   	   $	��650��6   $	��800��6)   $��16(�5	   	    � 	Resources 5
         MyImageSource �� 	UriSource  MyImageBrush �� ImageSource��%m   &	        &	 =     7   �� 5   
   $) #/ImageResources/BackgroundWhite.jpg?�6,   �� 5   
   8   6+   5      .��5      � $��10,10,10,10q�6   #��[ 6     � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��6* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��4��6-   $��2��6A   $��KATALOG��6R   $��42(�6d   $
��Bold"�6r   $��Center=�6�   $��Center=�6�   �� 5    
   $��2��6   $��0��6   $��4��6-   $��2��6A   $��INSTRUMENTÓW��6R   $��42(�6i   $
��Bold"�6w   $��Center=�6�   $��Center=�6�   �� 5!   
   $��4��6   $��0��6   $��4��6-   $��DĘTYCH��6A   $��42(�6R   $
��Bold"�6`   $��Center=�6r   �� 5"   
   $��5��6   $��0��6   $��4��6-   $$��Wybierz co chciałbyś zrobić��6A   $��18(�6g   $
��Bold"�6u   $��Center=�6�   $��Center=�6�   �� 5$   
   -   5        $��BtnOpen��5$   i     ButtonStyle#���  6   $��6��67   $��0��6D   $��Przeglądaj��6T   $��2q�6�   �� 5%   
   -   5        $��BtnNew��5%   d   #���  6   $��6��67   $��1��6D   $��Dodaj��6T   $��2q�6�   �� 5&   
   -   5        $��BtnClose��5&   z   #���  6   $��6��67   $��2��6D   $��2��6T   $��Zamknij��6h   $��2q�6�   5'      5(      