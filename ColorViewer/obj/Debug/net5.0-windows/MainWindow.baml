   M S B A M L   `   `   `  ����F  BColorViewer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ColorViewerColorViewer  5   	       ColorViewer.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ColorViewer     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��10,10,10,10q�6    � RowDefinitions 5
   
   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��50* �6    � ColumnDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��15* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��A:��6   $��14(�6!   $��Center=�6/   6L   �� 5      -   5        $��aSlider��5   Z    �� IsSnapToTickEnabled$
 True��6-    �� TickFrequency$ 1Q�6H   $	��500��6i    �� TickPlacement$
 None=�6u    �� Orientation$ 
Horizontal=�6�    � Maximum$	 255Q�6�   $
��Left=�6�   $��Center=�6�   	 � Value	 6   �� *Path+6�   �� 5      -   5        $��aValue��5      $��5q�6#   $��60��6b   $��30��6m   $��1,1,1,1q�6y   
���   ���6.   �� 
 �� ElementName$
 aSlider�� �� Path$ Value�6�   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   .+�5      �� $��R:��6   $��14(�6!   $��Center=�6/   6L   �� 5      -   5        $��rSlider��5   B   $
 True��6   $ 1Q�60   $	��500��6Q   $
 None=�6]   $ 
Horizontal=�6r   $	 255Q�6�   $
��Left=�6�   $��Center=�6�   6�   �� 5      -   5        $��rValue��5      $��5q�6#   $��60��6b   $��30��6m   $��1,1,1,1q�6y   
���   ���6.   �� $
 rSlider��$ Value�6�   5       �� 5!   
   $��2��6   $ 
Horizontal=�6"   .+�5"      �� $��G:��6   $��14(�6!   $��Center=�6/   6L   �� 5#      -   5        $��gSlider��5#   B   $
 True��6   $ 1Q�60   $	��500��6Q   $
 None=�6]   $ 
Horizontal=�6r   $	 255Q�6�   $
��Left=�6�   $��Center=�6�   6�   �� 5$      -   5        $��gValue��5$      $��5q�6#   $��60��6b   $��30��6m   $��1,1,1,1q�6y   
���   ���6.   �� $
 gSlider��$ Value�6�   5%      �� 5&   
   $��3��6   $ 
Horizontal=�6"   .+�5'      �� $��B:��6   $��14(�6!   $��Center=�6/   6L   �� 5(      -   5        $��bSlider��5(   B   $
 True��6   $ 1Q�60   $	��500��6Q   $
 None=�6]   $ 
Horizontal=�6r   $	 255Q�6�   $
��Left=�6�   $��Center=�6�   6�   �� 5)      -   5        $��bValue��5)      $��5q�6#   $��60��6b   $��30��6m   $��1,1,1,1q�6y   
���   ���6.   �� $
 bSlider��$ Value�6�   5*      �� 5,   
   $��2��6   $��4��6!   $��1,1,1,1q�62   
���   �$��10,10,10,10q�6`   ��5-      �� 5.      5/      51      ]� 53   
   $��4��6   $��2��6!   .+�54      �� -	   5        $��addBtn��54      $	��100��6#   $��30��6/   $��Center=�6;   $��Center=�6V   $��	250,0,0,0q�6s   
�������.��6�   Add6�   �� 55      -
   5        $��	removeBtn��55      $	��100��6&   $��30��62   $��Center=�6>   $��Center=�6Y   $��
-130,0,0,0q�6v   
�������.��6�   Remove6�   56      �� 58   
   -   5        $��colors��58      $��5��6D   $��2��6Q   
���   ���6    �� $ Colors�6{   5:      5;      