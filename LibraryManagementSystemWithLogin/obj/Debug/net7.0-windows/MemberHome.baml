   M S B A M L   `   `   `  ����M  IFinalExamDhrutiben, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FinalExamDhrutibenFinalExamDhrutiben  5   	   #    FinalExamDhrutiben.MemberHome   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:FinalExamDhrutiben     5   	     � Title$  
MemberHome��5   	   $
��Auto��6   $	��800��6*   
����d�$��2q�6S   
�������.��5	      � $��Center=�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��2��6"   .+�5      �� $��Center=�6   $��25(�61   $��Medium"�6?   $��5q�6S   .��6_   Manage Members6o   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��1��6;   .+�5      �� -   5         ��Name$ navigateHome��5      $��25��6+   $	��100��67   $��45 0 5 0q�6^   
����d�$��0q�6�   $��SemiBold"�6�   .��6�   Home6�   �� 5      -   5         ��Name$ searchValue��5      $	��150��6+   $��25��67   $��45 0 0 0q�6C   6W   �� 5      -   5        $ searchMember��5      $��25��6+   $	��100��67   
����d�$��0q�6z   $��SemiBold"�6�   .��6�   Search Member6�   �� 5      -   5        $ clearFilter��5      $��25��6*   $	��100��66   $��5q�6B   
���i��$��0q�6~   $��SemiBold"�6�   .��6�   Clear Filter6�   �� 5       -   5        $ 	addMember��5       $��25��6(   $��45q�64   $	��120��6@   
����d�$��0q�6�   $��SemiBold"�6�   .��6�   Add New Member6�   5"      �� 5#   
   -   5         ��Name$ memberListPanel��5#   Y   $ 
Horizontal=�6   $��2��6.   $��1��6;   $
��45 0q�6K   .+�5$      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridMembers��5$         AutoGenerateColumns$ False��61   	   
IsReadOnly$
	 True��6M   
   Columns
 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6)      Header$ 	Member ID��64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *
memberID+  5'      $	 200 6)   $
 Name��65    6C   �� *
fullName+  5(      $	 400 6)   $ Issued Books��66    6L   �� *books+   ElementStyle 5)      �� 5*      .�5+   "   ��  �� Property � �� �� Value$
 Wrap=�6K   5-      5/      52      53      �� 54   
   -   5        $ noDataPanel��54      $ 
Horizontal=�6*   $��2��6C   $��1��6P   $
��20 0q�6`   $y�	Collapsed=�6n   .+�55      �� -	   5         ��Name$ 	noMembers��55      $
��Bold"�6'   $��20(�69   .��6G   Member(s) Not Found6\   56      57      58      