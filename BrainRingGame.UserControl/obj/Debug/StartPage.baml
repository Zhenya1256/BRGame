   M S B A M L   `   `   `  ����T  PBrainRingGame.UserControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:BrainRingGame.Ui.Wpf.Common.UserControl'BrainRingGame.Ui.Wpf.Common.UserControl  5      7    1BrainRingGame.Ui.Wpf.Common.UserControl.StartPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:BrainRingGame.Ui.Wpf.Common.UserControl     5        � 	Resources  5	       �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value   Button.MouseOver.Background �� Color  ButtonTemplate �� 
TargetType  ButtonsStyle	 �� Triggers��%�  'm�       &	  �     'o� �     7   '�� *    &	 �    �� 5
   
   " m�6    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 �  ��63   5      5      �� 5   
   $
 #000��6>   �� 5   
   " o�6    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��8   63   5      5      �� 5   
   " ��6    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��$ 14(�61   �� 5        � ��
 �  ��63   5!      5#      �� 5$   
   " ��61   .R�5%      �� $��border��6   
�������$��54(�5&   2   #���  6J   ._�5(      �� ��. #��z��6>   $��Center=�6a   $��Center=�6~   6�   5*      	 5+      P� 5,       �@J�IsMouseOver . . �5-      ��  � ��
 �  ��6B   5.      P� 5/       � �� . . �50      ��  � ��
 � ���6F   51      53      54      .��56      � -   5        $��
MainWindow��56   /     	GridStyle#���  6   
 � ColumnDefinitions
 58   
   �� 59      .+�5;   
   �� $��0��6   .+�5<      ]� -   5        $��StartPageWindow��5<   -   ��. .+�5=      o� $	��Top=�6   $��25(�6,   
����  �$��10q�6P   .@�5@      m� $��Налаштування��6    � Cursor$
 Hand��66   
�������$��SemiBold"�6W   .@�5D      m� -   5         m�Name$ 
SettigGame��5D   #   
����  �$%��Налаштування гри��6k    m� Command 6O   �� *	Setting+5F      m� 5H      -   5        $ SettigButton��5H   $   $+��%Налаштування кнопок��6:   
����  � 6n   �� *SettingButton+5K      m� 5M      -   5        $ ShooseStyle��5M   $   $��Вибір стилю��69   
����  � 6e   �� *SettingStyle+5N      m� 5O      -   5        $ ShooseComand��5O   $   $%��Створення команд��6:   
����  � 6k   �� *SettingCommand+5P      5`      m� 5a      -   5        $��Справка��5a      $
 Hand��60   
�������$��SemiBold"�6Q   6�   5c      �� 5d      -   5         ��Name$ 	dockPanel��5d   A   $��Right=�6   $	��290��65     StackPanelStyleMenu#���  6T   $ Arrow��6�   $��0q�6�   $��Right=�6�   $
��1108��6�   .+�5e      �� -	   5         ��Name$ 	textBlock��5e   J     TextBlockStyle#���  6    $
��Wrap=�6]   $��52��6q   $��28(�6�   $��0q�6�   $
 Hand��6�   $��Right=�6�   $	��290��6�   ��5f      �� 5g       �� EndPoint$ 0.5,1&�62    �� 
StartPoint$ 0.5,0&�6C   .��5h   "   �  � Color$ 	#FF151414��6/    � Offset$ 0Q�6A   � 5i   "   $ 	#FF0B054D��6/   $ 1Q�6A   5j      �� 5l      $��28(�6   
���  ��$�=��6=   �� 6H   �� 6T   6[   �� 5m      -
   5        $ 
textBlock1��5m   I   #���  6    $��30(�6]   $
��Wrap=�6�   $��0,10,0,0q�6�    �� Padding$ 10q�6�   $��
ЕТАП 1��6�    �� TextAlignment$ Center=�6�   $
 Hand��6�   5v      �� 5x      -   5        $ textBlock1_Copy��5x   I   #���  6    $��30(�6b   $
��Wrap=�6�   $��0,0,0,0q�6�   $ 10q�6�   $
 Hand��6�   $ Center=�6�   �� 6  $�	ЕТАП ��6  �� 6  $�2��6  6$  �� 5z      -   5        $ textBlock1_Copy1��5z   J   #���  6    $��30(�6d   $
��Wrap=�6�   $��0,0,0,0q�6�   $ 10q�6�   $
 Hand��6�   $ Center=�6�   �� 6  $�	ЕТАП ��6	  �� 6  $�3��6  6(  �� 5|      -   5        $ textBlock1_Copy2��5|       #���  6:   $��30(�6c   $
��Wrap=�6�   $��0,0,0,0q�6�   $ 10q�6�   $
 Hand��6�   $ Center=�6�   �� 6  $�
ЕТАП  ��6  �� 5}      $�4��6	   6   �� 5      -   5        $ textBlock1_Copy3��5       #���  6:   $��30(�6c   $
��Wrap=�6�   $��0,0,0,20q�6�   $ 10q�6�   $
 Hand��6�   $ Center=�6�   $��UltraExpanded&�6  &   System.Windows.Media.TextOptions   TextHintingMode$ Fixed=�6  �� 6C  $�	ЕТАП ��6G  �� 6V  $�5��6Z  6f  5�      �� 5�      -   5        $ mainDock��5�   .   $
��auto��6   $
��1100��6B   $
��1096��6S   .+�5�      ]� .+�5�      �� -   5         ��Name$ label��5�   x   $��28(�6!   $��Right=�6/   $y�Hidden=�6G   $��=��6�   
���  ��$��	ExtraBold"�6�   $��25��6�   $
 Hand��6�   $��Right=�6�   $��	0,-15,0,0q�6�   5�      �� 5�      -   5        $ 
textBlock2��5�       $��28(�64   $
��Wrap=�6B   $y�Hidden=�6V   $��	TextBlock��6j   ���	#FF5D5959{�.  6�   �� 5�      -   5         ��Name$ button��5�   e   $
 Hand��6?   ���	#FF0B054D$��Center=�6u   $��Почати Гру��6�   $	��420��6�   $	��143��6�   $��36(�6�   
�������$��Center=�6�   $��	0,200,0,0q�6�   ��6   �� *	StartPlay+5�      5�      5�      5�      5�      5�      