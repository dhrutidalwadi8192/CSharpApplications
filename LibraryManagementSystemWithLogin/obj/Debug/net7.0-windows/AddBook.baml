   M S B A M L   `   `   `  ����M  IFinalExamDhrutiben, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FinalExamDhrutibenFinalExamDhrutiben  5   	        FinalExamDhrutiben.AddBook   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:FinalExamDhrutiben     5   	     � Title$  AddBook��5   	   $	��450��6   $	��800��6&   
����d�$��2q�6O   
�������.��5	      � $��Center=�6   $��50q�6(    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $��0��6   $��24(�6-   $��	100 0 0 0q�6;   .��6N   
Add Book6X   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��0��6;   .+�5      �� $��30��6   $��80��6    $��10 0 0 0q�6+   .��6=   Title6D   �� 5      -   5         ��Name$ 	bookTitle��5      $��20��6)   $	��200��65   6C   5      �� 5   
   $ 
Horizontal=�6   $��2��6.   $��0��6;   .+�5      �� $��30��6   $��80��6    $��10 0 0 0q�6+   .��6=   Author6E   �� 5      -   5        $ 
bookAuthor��5      $��20��6*   $	��200��66   6D   5      �� 5   
   $ 
Horizontal=�6   $��3��6.   $��0��6;   .+�5      �� -   5         ��Name$ addBook��5   >   $��25��6   $��80��6!   $��80 0 0 0q�6,   
����d�$��0q�6�   $��SemiBold"�6�   .��6�   
Add Book6�   �� 5       -   5        $ cancel��5    >   $��25��6   $��80��6!   $��10 0 0 0q�6,   
���i��$��0q�6z   $��SemiBold"�6�   .��6�   Cancel6�   5!      5"      5#      