   M S B A M L   `   `   `  ����M  IFinalExamDhrutiben, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:FinalExamDhrutibenFinalExamDhrutiben  5   	   "    FinalExamDhrutiben.IssueBook   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:FinalExamDhrutiben     5   	     � Title$  	IssueBook��5   	   $	��450��6   $	��800��6(   
����d�$��2q�6Q   
�������.��5	      � $��Center=�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $��60 �6   .+�5   
   �� $��0��6   $��4��6"   .+�5      �� $��Center=�6   $��25(�61   $��Medium"�6?   $��5q�6S   .��6_   
Issue Book6k   5      �� 5   
   -   5         ��Name$ memberSelection��5   K    �� Orientation$ 
Horizontal=�6   $��1��6.   $��0��6;   .+�5      �� $��30��6   $	��100��6    $��10 0 0 0q�6,   .��6>   Select Member6M   �� 5      -   5         ��Name$ memberCombo��5      $��30��6,   $	��200��68   ��5      �� 5      .R�5       �� ��6$   �� *
fullName+5"      5$      5%      �� 5'   
   -   5        $ bookListPanel��5'      $ 
Horizontal=�6,   $��3��6E   .+�5(      �� $��30��6   $	��100��6    $��10 0 0 0q�6,   .��6>   Select Book(s)6N   �� 5)      -   5         ��Name$ bookList��5)      $
��auto��6(   $
��auto��65    �� SelectionMode$ Multiple=�6C   $	��500��6\   ��5+      �� 5,      .R�5-      ��  d� 	IsChecked 6#   �� 	 �� RelativeSource	 �� 
 �� AncestorType"
 �� �� Path$ 
IsSelected���6�   �� *titleAndAuthour+6�   5.      50      �� 51      -   5         ��Name$ noBookAvailable��51   U   $��30��6   $	��100��6    $��10 0 0 0q�6,   $y�	Collapsed=�6>   .��6n   No Books Available To Issue6�   52      �� 53   
   $ 
Horizontal=�6   $��4��6.   $��0��6;   $��0 25 0 0q�6K   .+�54      �� -   5         ��Name$ 	issueBook��54   ?   $��25��6   $	��100��6!   $��80 0 0 0q�6-   
����d�$��0q�6�   $��SemiBold"�6�   .��6�   
Issue Book6�   �� 55      -   5        $ cancel��55   ?   $��25��6   $	��100��6!   $��20 0 0 0q�6-   
���i��$��0q�6{   $��SemiBold"�6�   .��6�   Cancel6�   56      58      59      