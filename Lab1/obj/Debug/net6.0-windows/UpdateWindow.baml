   M S B A M L   `   `   `  ����?  ;Lab1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab1Lab1  5   	       Lab1.UpdateWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab1     5   	     � Title$  UpdateWindow��5   	   $	��650��6   $	��800��6+   $��16(�5	   	    � 	Resources 5
         MyImageSource �� 	UriSource  MyImageBrush �� ImageSource��%m   &	        &	 =     7   �� 5   
   $) #/ImageResources/BackgroundWhite.jpg?�6,   �� 5   
   8   6+   5      .��5      � $��10,10,10,10q�6   #��[ 6     � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��7* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ��   
LabelStyle#���  6   $��0��65   $��0��6B   $��4��6R   $#��KATALOG INSTRUMENTÓW DĘTYCH��6f   $��18(�6�   $
��Bold"�6�   $��Center=�6�   �� 5   
   #���  6   $��1��65   $��0��6B   $��Nazwa:��6R   $
��Bold"�6c   �� 5    
   #���  6   $��2��65   $��0��6B   $��	Podgrupa:��6R   $
��Bold"�6f   �� 5!   
   #���  6   $��1��65   $��2��6B   $��Strój:��6R   $
��Bold"�6c   �� 5"   
   #���  6   $��2��65   $��2��6B   $��Skala:��6R   $
��Bold"�6c   �� 5#   
   #���  6   $��3��65   $��0��6B   $��Opis:��6R   $
��Bold"�6b   �� 5$   
   #���  6   $��3��65   $��2��6B   $��	Zdjęcie:��6R   $
��Bold"�6e   �� 5&   
   -   5        $��	InstrName��5&   V     TextBoxStyle#���  6   $��1��69   $��1��6F   ${�False��6g   �� 5'   
   -   5        $��
InstrGroup��5'   V   #���  6   $��2��69   $��1��6F   6V   �� 5(   
   -   5        $��
InstrTuned��5(   V   #���  6   $��1��69   $��3��6F   6V   �� 5)   
   -   5        $��
InstrRange��5)   V   #���  6   $��2��69   $��3��6F   6V   �� 5*   
   -   5        $��InstrDescription��5*   k     TextBoxStyle1#���  6   $��4��6:   $��0��6G   $��2��6W   6k   �� 5+   
   -   5        $��	InstPhoto��5+   A   $��4��6   $��2��6   $��2��6-   6A   �� 5-   
   -   5        $��BtnPhotoUpload��5-   d     ButtonStyle#���  6   $��3��67   $��3��6D   $��Dodaj��6T   $��2q�6�   �� 5.   
   -   5        $��	BtnAccept��5.   �   #���  6   $��5��67   $��0��6D   $��2��6T   $��Akceptuj zmiany��6h   $��2q�6�   �� 5/   
   -	   5        $��BtnClose��5/   z   #���  6   $��5��67   $��2��6D   $��2��6T   $��Zamknij��6h   $��2q�6�   50      51      