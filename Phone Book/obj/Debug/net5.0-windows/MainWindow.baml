   M S B A M L   `   `   `  ����D  @PhoneBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PhoneBook	PhoneBook  5   	       PhoneBook.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PhoneBook     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��700��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $��40��6A   $	��800��6M   $��Center=�6Y   $��Center=�6t   $��20(�5      $��Italic$�6   
���   �$��1,1,1,1q�6E   $��Center=�6_   $��Center=�6�   .��6�   
Phone Book6�   �� 5   
   -   5        $��contactListBox��5   @   $��1��6   $��0��6   $��5��6/    �� DisplayMemberPath$ 	ShortInfo��5      ���	#FF92CEE9$��Stretch=�6G   ��5   V   ��  �� Path$ Contacts� �� SelectedItem 6|   �� $ SelectedContact� �� Mode$ OneWayToSource=�5      �� 5   
   $��1��6   $��1��6"   .+�5      �� $��Center=�6   .��61   Name67   �� 5       $��	15,0,15,0q�6   
���   ���6<   �� $ SelectedContact.Name�6i   �� 5!      $��Center=�6   .��61   	Surname6:   �� 5"      $��	15,0,15,0q�6   
���   ���6<   �� $ SelectedContact.Surname�6l   �� 5#      $��Center=�6   .��61   Phone68   �� 5$      $��	15,0,15,0q�6   
���   ���6<   �� $ SelectedContact.Phone�6j   �� 5%      $��Center=�6   .��61   	Country6:   �� 5&      -   5        $��countryComboBox��5&   *   $��	15,0,15,0q�6    �� 
IsEditable$
 True��6A    �� Text 6S   �� $ SelectedContact.Country�.@�5'      �� .��6   	Ukraine6(   �� 5(      .��6   Italy6&   �� 5)      .��6   Poland6'   5*      5+      �� 5-   
   -   5        $��addBtn��5-      $��1��6   $��5��6/   $��55��6<   $��30��6G   $��-100,10,0,0q�6S   .��6�   Add6�   �� 5.   
   -   5        $��	removeBtn��5.      $��1��6"   $��5��62   $��55��6?   $��30��6J   $��0,10,-100,0q�6V   .��6�   Remove6�   5/      50      