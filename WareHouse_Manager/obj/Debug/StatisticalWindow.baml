   M S B A M L   `   `   `  ����L  HWareHouse_Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WareHouse_Manager.UCWareHouse_Manager.UC  5   	   5clr-namespace:WareHouse_ManagerWareHouse_Manager  5	   	   )    #WareHouse_Manager.StatisticalWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   +uc"clr-namespace:WareHouse_Manager.UC  5   	   +localclr-namespace:WareHouse_Manager  5	   	   -   5          �Name$  statisticalWindow��5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ Thống kê - báo cáo��5   	   $	��460��6$   $	��850��61   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *WindowLoadedCommand+	   CommandParameter	 5   $   �� 
 �� ElementName$
 statisticalWindow��6a   5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      '   !WareHouse_Manager.UC.ControlBarUC  
 � Tag 6   �� *Title+$
 statisticalWindow��6T   5      � 5!   
   $��1��6    � ColumnDefinitions 5"      �� 5#      $
��auto �6#   62   �� 5$      $��5 �6#   6/   �� 5%      6%   .+�5(      � $��0��6   .+�5)      R� -   5         R�Name$ TreeView��5,      $��20(�5*      
��� � � 5-        5.      $ SelectedItemChanged��6)   . 5/         64   �� *SelectedItemChanged+	 50   4   �� $
 TreeView��6h   51      .@�53      Q� $��
Nhập kho��6#   .@�54      Q� $��Phiếu nhập��6'   6=   Q� 55      $��Hàng nhập��6'   6<   56      Q� 57      $��
Xuất kho��6#   .@�58      Q� $��Phiếu xuất��6'   6=   Q� 59      $��Xuất hàng��6'   6<   5:      Q� 5;      $��	Tồn kho��6#   66   Q� 5<      $��Nhà cung cấp��6#   6;   Q� 5=      $��Khách hàng��6#   69   5>      5?      � 5@      $��1��6   
���   �5B      #  MaterialDesignThemes.Wpf.Card  5C      $��2��6"   .��5D      � -   5         �Name$ Grid_Parrent��5E      $��Stretch=�5F      5G      5H      5I      5J      5K      