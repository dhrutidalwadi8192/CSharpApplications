   M S B A M L   `   `   `  ����M  IFinalExamDhrutiben, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FinalExamDhrutibenFinalExamDhrutiben  5   	   !    FinalExamDhrutiben.BookHome   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:FinalExamDhrutiben     5   	     � Title$  Books��5   	   $
��Auto��6   $	��900��6%   .��5	      � $��Center=�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��2��6"   .+�5      �� $��Center=�6   $��25(�61   $��Medium"�6?   $��10q�6S   .��6_   Manage Books6m   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��1��6;   .+�5      �� -   5         ��Name$ homeNavigate��5      $��25��6+   $��80��67   $��20 0 5 0q�6]   
����d�$��0q�6�   $��SemiBold"�6�   .��6�   Home6�   �� 5      -   5         ��Name$ searchValue��5      $	��150��6+   $��25��67   $��45 0 0 0q�6C   6X   �� 5       -   5        $ 
searchBook��5       $��25��6)   $	��100��65   
����d�$��0q�6v   $��SemiBold"�6�   .��6�   Search Book6�   �� 5!      -   5        $ clearFilter��5!      $��25��6*   $	��100��66   $��5q�6B   
���i��$��0q�6~   $��SemiBold"�6�   .��6�   Clear Filter6�   �� 5"      -   5        $ addBook��5"      $��25��6&   $��180 50 50 50q�62   $	��120��6H   
����d�$��0q�6�   $��SemiBold"�6�   .��6�   Add New Book6�   5%      �� 5&   
   -   5         ��Name$ bookListPanel��5&      $ 
Horizontal=�6,   $��2��6E   $��1��6R   $��20q�6b   .+�5'      �� $
��Auto=�6   $
��Auto=�6>   .��5(      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridBooks��5(         AutoGenerateColumns$ False��63   	   
IsReadOnly$
	 True��6O   
   Columns
 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6-      Header$ Book ID��68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *bookID+  5+      $	 200 6-   $ Title��69    6H   �� *title+  5,      $	 200 6-   $ Author��69    6I   �� *author+  5-      $ 80 6-   $ Is Available��68    6N   �� *isAvailable+  5.      -   5        issuedTo��$	 150 5.   ?   $ 	Issued To��6K    6^   �� *
issuedTo+4  .System.Windows.Controls.DataGridTemplateColumn  5/      $  ��61   $ 80 6;      CellTemplate 50      �� 51   "   .R�52   &   �� $ 
returnBook��6-   -	   5        
�������$��0q�52   �   $��SemiBold"�6�   {�6A   �� *isEnableReturn+.��6�   Return Book6�   53   #   55      58      59      5;      �� 5<   
   -
   5        $ noDataPanel��5<      $ 
Horizontal=�6*   $��2��6C   $��1��6P   $
��20 0q�6`   $y�	Collapsed=�6n   .+�5=      �� -   5         ��Name$ noBooks��5=      $
��Bold"�6%   $��20(�67   .��6E   Book(s) Not Found6X   5>      5?      5@      