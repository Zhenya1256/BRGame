   M S B A M L   `   `   `  ����T  PBrainRingGame.UserControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:BrainRingGame.UserControlBrainRingGame.UserControl  5      -    'BrainRingGame.UserControl.TopicQuestion   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:BrainRingGame.UserControl     5      $
��auto��5      $
��auto��6     � 	Resources  5         Button.MouseOver.Background �� Color �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value  ButtonTemplate �� 
TargetType	 �� CornerRadius  ButtonsStyleOne
 �� Triggers��%q  &	        '��      &	 �     �� 5   
   $
 #000��6>   �� 5   
   " ��6    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��$ 14(�61   �� 5       � ��
 �  ��63   5      5      �� 5   
   " ��61   .R�5      �� $��border��6   $	 15��6$   
�������$��54(�5   2   #���  6J   ._�5      �� ��. #��z��6>   $��Center=�6a   $��Center=�6~   6�   5      
 5       P� 5!       �@J�IsMouseOver . . �5"      ��  � ��
 �  ��6B   5#      P� 5$       � �� . . �5%      ��  � ��
 � ���6F   5&      5(      5)      .��5+      � -   5        $��
PlayWindow��5+   /     	GridStyle#���  6   .+�5-   
   ]� ��.  .+�5.      � $	��Top=�6   $	��460��6)   .+�5/      �� -   5         ��Name$ textQuation��5/   (   $��80��6   $��28(�6=    �� Padding$ 0,14,0,0q�6K    �� TextAlignment$ Center=�6^   
�������$	��Top=�6�   $
��Bold"�6�    �� LineStackingStrategy$ BlockLineHeight=�6�   $
��Wrap=�6�   $��Oblique$�6�   $��UltraExpanded&�6  6  �� 50      -   5         ��Name$ QuestionImage��50      $��
0,70,0,-60q�62   �� 51      -   5         ��Name$ listViewCommand��51   *   $��20(�6   $	��400��6C   $	��400��6P   $��10q�6]   $y�Hidden=�6i   ��6}   ��  �� Path$ 
ListGroups� �� View 52      �� 53      .P�54      ��  �� Width$ 50��6�    �� DisplayMemberBinding 6-   �� $ Position� �� UpdateSourceTrigger$ PropertyChanged=�.��6�   №6�   �� 55      $	 150��6}    6-   �� $
 Name�$ PropertyChanged=�.��6�   Назва команди6�   �� 56      $	 200��6~    6-   �� $ Point�$ PropertyChanged=�.��6�   
Бали6�   57        59      ��%    5;      5<      5=      � 5@      $	��Top=�6   $	��242��6(    � ColumnDefinitions 5A      �� 5B      $
��583* �6'   .+�5G      � $��2��6   .+�5I      �� $��Center=�6   $	 30��6=   
���   �$��2q�6c   $��500,0,500,0q�6w   $	��350��6�   $	��175��6�   $��Bottom=�6�   ._�5J      �� -   5         ��Name$ 
labelTimer��5J   "   
���  ��$��	8,0,-2,10q�6�   $��Center=�6�   $��Center=�6�   ��6G   �� *
TimerValue+ �� Mode$ OneWay=���6r   �� *
SizeText+$ OneWay=�6�   5K      5M      5P      5R      r� 5S   
   -   5         r�Name$ mediaElement��5S      $
��Left=�6-   $	��100��6H   $��-112,271,0,0q�6U   $	��Top=�6k   $	��100��6�   5T      5U      