   M S B A M L   `   `   `  ����T  PBrainRingGame.UserControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:BrainRingGame.UserControlBrainRingGame.UserControl  5      ,    &BrainRingGame.UserControl.ThemsQuation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:BrainRingGame.UserControl     5      .��5	      �    	GridStyle#���   6
   .+�5   
   ]� ��. .+�5      �� -   5          ��Name$  label��5   k   $��28(�6   $
��Left=�6#   $y�Hidden=�6:   $��Питання��6{   
���  ��$��	ExtraBold"�6�   $	��150��6�    � Cursor$
 Hand��6�   $��Bottom=�6�   �� 5      -   5         ��Name$ 	dockPanel��5   2   $��Bottom=�6   $ Arrow��6F   $��
-150,0,0,0q�6U   $��0��6i   .+�5      �� -   5         ��Name$ 	textBlock��5   F     TextBlockStyle#���  6   $
��Left=�6Y   $��26��6u   $��28(�6�   $
 Hand��6�   �� 5      $��28(�6   
���  ��$�=��6=   �� 6H   �� 6T   5      �� 5      $
 Hand��6   $��Center=�6K   $��Center=�6f   $'��!Додаткове питання��6�   $	��285��6�   $��69��6�   $��36(�6�   
������� J� RenderTransformOrigin$ 0.5,0.5&�6�   ��6'   ��  �� Path$ 	NextTimer�z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -2.583Q�6,   �� 5      T� 5       T� X$ 1.647Q�61   5      ��5      �� 5       �� EndPoint$ 0.5,1&�6.   	 �� 
StartPoint$	 0.5,0&�6?   .��5      � 
 � Color$
 Black��6+    � Offset$ 0Q�69   � 5      $
 	#FF0B054D��6+   $ 1Q�6=   5      5!      5#      � 5$      -   5        $��
MainWindow��5$      $��
-140,0,0,0q�6)    � RowDefinitions 5%      �� 5&      $��30 �6$   �� 5'      $
��175* �6$   �� 5(      $
��175* �6$   �� 5)      $
��175* �6$   �� 5*      $
��169* �6$   �� 5+      $��6* �6$   .+�5/      � $��1��6   $��Center=�6)   $��	58,0,57,0q�6F   .+�50      �� $	��150��6   $	��150��6+   $��
Тема 1��68   $��44(�6I   $��Center=�6W   $��Center=�6u   
���  ��$��Center=�6�   $��Center=�6�   6�   �� 51      -   5        $ Stack1��51   I   
���  ��$��
10,0,10,10q�6[   $
 Hand��6o   $	��150��6~   $	��150��6�    J� InputBindings 52      d� 53       d� MouseAction$ 	LeftClicke�6I    �� Command 6+   �� *	StartGame+6I   .+�56      �� -   5         ��Name$ ThameImage1��56       $	��150��6L   $	��150��6X   6g   �� 57      -   5        $ 
ThameText1��57   $    �� Padding$ 0,10,0,0q�68   $��	0,-50,0,0q�6M   $��Center=�6`    �� TextAlignment$ Center=�6�   $��50��6�   $
��Bold"�6�   6�   58      �� 5:      -   5        $ Stack2��5:   8   $��
10,0,10,10q�6"   $
 Hand��6a   $	��150��6p   $	��150��6    5;      d� 5<      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5>      �� -	   5        $ ThameImage2��5>       $	��150��6L   $	��150��6X   6g   �� 5?      -
   5        $ 
ThameText2��5?   $   $��	0,-50,0,0q�69   $ 0,10,0,0q�6M   $ Center=�6x   $��50��6�   $
��Bold"�6�   6�   5A      �� 5B      -   5        $ Stack3��5B   "   $��
10,0,10,10q�6I   $
 Hand��6^   $	��150��6l   $	��150��6{    5C      d� 5D      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5F      �� -   5        $ ThameImage3��5F       $	��150��6L   $	��150��6X   6g   �� 5G      -   5        $ 
ThameText3��5G   $   $ 0,10,0,0q�68   $��	0,-50,0,0q�6M   $��13(�6`   $ Center=�6�   $��50��6�   $
��Bold"�6�   6�   5I      �� 5J      -   5        $ Stack4��5J   "   $��
10,0,10,10q�6J   $
 Hand��6^   $	��150��6m   $	��150��6|    5K      d� 5L      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5N      �� -   5        $ ThameImage4��5N       $	��150��6L   $	��150��6X   6g   �� 5O      -   5        $ 
ThameText4��5O   $   $ 0,10,0,0q�68   $
��Bold"�6K   $��	0,-50,0,0q�6_   $ Center=�6�   $��50��6�   6�   5Q      5T      � 5U      $��2��6   $��Center=�6)   $��	58,0,57,0q�6F   .+�5V      �� $	��150��6   $	��150��6+   $��
Тема 2��68   $��44(�6I   $��Center=�6W   $��Center=�6u   
���  ��$��Center=�6�   $��Center=�6�   6�   �� 5W      -   5        $ Stack5��5W   !   $��10,10,10,10q�6J   $
 Hand��6`   $	��150��6o   $	��150��6~    5X      d� 5Y      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5[      �� -   5        $ ThameImage5��5[       $	��150��6L   $	��150��6X   6g   �� 5\      -   5        $ 
ThameText5��5\   6   $
��Bold"�6$   $ 0,10,0,0q�6J   $��	0,-50,0,0q�6^   $ Center=�6�   $��50��6�   6�   5^      �� 5_      -   5        $ Stack6��5_   :   $��10,10,10,10q�6J   $
 Hand��6`   $	��150��6o   $	��150��6~    5`      d� 5a      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5c      �� -   5        $ ThameImage6��5c       $	��150��6L   $	��150��6X   6g   �� 5d      -   5        $ 
ThameText6��5d   6   $
��Bold"�6$   $ 0,10,0,0q�6J   $��	0,-50,0,0q�6`   $ Center=�6�   $��50��6�   6�   5f      �� 5g      -   5        $ Stack7��5g   9   $��10,10,10,10q�6I   $
 Hand��6_   $	��150��6n   $	��150��6}    5h      d� 5i      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5k      �� -   5        $ ThameImage7��5k       $	��150��6L   $	��150��6X   6g   �� 5l      -   5        $ 
ThameText7��5l   6   $
��Bold"�6$   $ 0,10,0,0q�6J   $��	0,-50,0,0q�6^   $ Center=�6�   $��50��6�   6�   5n      �� 5o      -   5        $ Stack8��5o   9   $��10,10,10,10q�6J   $
 Hand��6`   $	��150��6o   $	��150��6~    5p      d� 5q      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5s      �� -   5        $ ThameImage8��5s       $	��150��6L   $	��150��6X   6g   �� 5t      -   5        $ 
ThameText8��5t   6   $
��Bold"�6$   $ 0,10,0,0q�6J   $��	0,-50,0,0q�6_   $ Center=�6�   $��50��6�   6�   5v      5w      � 5x      $��3��6   $��Center=�6)   $��	58,0,57,0q�6F   .+�5y      �� $	��150��6   $	��150��6+   $��
Тема 3��68   $��44(�6I   $��Center=�6W   $��Center=�6u   
���  ��$��Center=�6�   $��Center=�6�   6�   �� 5z      -   5        $ Stack9��5z   :   $��10,10,10,10q�6K   $
 Hand��6a   $	��150��6p   $	��150��6    5{      d� 5|      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5~      �� -   5        $ ThameImage9��5~       $	��150��6L   $	��150��6X   6g   �� 5      -   5        $ 
ThameText9��5   6   $
��Bold"�6$   $ 0,10,0,0q�6J   $��	0,-50,0,0q�6_   $ Center=�6�   $��50��6�   6�   5�      �� 5�      -    5        $ Stack10��5�   9   $��10,10,10,10q�6K   $
 Hand��6`   $	��150��6o   $	��150��6~    5�      d� 5�      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5�      �� -!   5        $ ThameImage10��5�       $	��150��6M   $	��150��6Y   6h   �� 5�      -"   5        $ ThameText10��5�   6   $
��Bold"�6$   $ 0,10,0,0q�6K   $��	0,-50,0,0q�6`   $ Center=�6�   $��50��6�   6�   5�      �� 5�      -#   5        $ Stack11��5�   9   $��10,10,10,10q�6J   $
 Hand��6_   $	��150��6n   $	��150��6}    5�      d� 5�      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5�      �� -$   5        $ ThameImage11��5�       $	��150��6M   $	��150��6Y   6h   �� 5�      -%   5        $ ThameText11��5�   7   $
��Bold"�6%   $ 0,10,0,0q�6L   $��	0,-50,0,0q�6a   $ Center=�6�   $��50��6�   6�   5�      �� 5�      -&   5        $ Stack12��5�   9   $��10,10,10,10q�6K   $
 Hand��6`   $	��150��6o   $	��150��6~    5�      d� 5�      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5�      �� -'   5        $ ThameImage12��5�       $	��150��6M   $	��150��6Y   6h   �� 5�      -(   5        $ ThameText12��5�   6   $
��Bold"�6$   $ 0,10,0,0q�6K   $��	0,-50,0,0q�6`   $ Center=�6�   $��50��6�   6�   5�      5�      � 5�      $��4��6   $��Center=�6)   $��	58,0,57,0q�6F   $��2��6Y   .+�5�      �� $	��150��6   $	��150��6+   $��
Тема 4��68   $��44(�6I   $��Center=�6W   $��Center=�6u   
���  ��$��Center=�6�   $��Center=�6�   6�   �� 5�      -)   5        $ Stack13��5�   9   $��10,10,10,10q�6J   $
 Hand��6_   $	��150��6n   $	��150��6}    5�      d� 5�      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5�      �� -*   5        $ ThameImage13��5�       $	��150��6M   $	��150��6Y   6h   �� 5�      -+   5        $ ThameText13��5�   6   $
��Bold"�6$   $ 0,10,0,0q�6K   $��	0,-50,0,0q�6`   $ Center=�6�   $��50��6�   5�      �� 5�      -,   5        $ Stack14��5�   9   $��10,10,10,10q�6K   $
 Hand��6a   $	��150��6p   $	��150��6    5�      d� 5�      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5�      �� --   5        $ ThameImage14��5�       $	��150��6M   $	��150��6Y   6h   �� 5�      -.   5        $ ThameText14��5�   7   $
��Bold"�6%   $ 0,10,0,0q�6L   $��	0,-50,0,0q�6a   $ Center=�6�   $��50��6�   6�   5�      �� 5�      -/   5        $ Stack15��5�   N   $��10,10,10,10q�6"   $
 Hand��6a   $	��150��6o   $	��150��6~    5�      d� 5�      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5�      �� -0   5        $ ThameImage15��5�   "   $	��150��6O   $	��150��6[   6j   �� 5�      -1   5        $ ThameText15��5�   _   $
��Bold"�6$   $��	0,-50,0,0q�67   $ 0,10,0,0q�6J   $ Center=�6�   $��50��6�   5�      5�      �� 5�      -2   5        $ Stack16��5�   9   $��10,10,10,10q�6K   $
 Hand��6a   $	��150��6o   $	��150��6~    5�      d� 5�      $ 	LeftClicke�6I    6+   �� *	StartGame+6I   .+�5�      �� -3   5        $ ThameImage16��5�       $	��150��6M   $	��150��6Y   6h   �� 5�      -4   5        $ ThameText16��5�   6   $
��Bold"�6$   $ 0,10,0,0q�6L   $��	0,-50,0,0q�6`   $ Center=�6�   $��50��6�   6�   5�      5�      5�      5�      5�      5�      