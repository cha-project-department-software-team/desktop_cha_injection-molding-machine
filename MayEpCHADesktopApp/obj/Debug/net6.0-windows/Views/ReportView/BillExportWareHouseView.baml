   M S B A M L   `   `   `  ����M  IMayEpCHADesktopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:MayEpCHADesktopApp.Resources.Components'MayEpCHADesktopApp.Resources.Components  5      R NMayEpCHADesktopApp.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Uclr-namespace:MayEpCHADesktopApp.Core.ValueConverter;assembly=MayEpCHADesktopApp.Core&MayEpCHADesktopApp.Core.ValueConverter 5      A    ;MayEpCHADesktopApp.Views.ReportView.BillExportWareHouseView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      L
components5clr-namespace:MayEpCHADesktopApp.Resources.Components     5      Hi:http://schemas.microsoft.com/expression/2010/interactivity     5	      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      e	ConverterUclr-namespace:MayEpCHADesktopApp.Core.ValueConverter;assembly=MayEpCHADesktopApp.Core  5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $	��824��5      $��1267.2��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.8* �6   �� 5      $��0.67* �6   �� 5      $��0.75* �6   �� 5      $
��4.5* �6   .+�5   
   � $��0��6   .+�5       #  MaterialDesignThemes.Wpf.Card  $	��1 2q�6"   .��5!      �� $��38(�6   $
��Bold"�5"      $��Center=�5#      $��Center=�5$      $��Bottom=�5%      $��0 0 0 10q�5&      .��5'      PHIẾU BÁO CÁO XUẤT KHO5)      5*      5+      � 5,   
   $��1��6   .+�5-        $��0 5 0 5 q�6"   .��5.      ��  �� Orientation$ 
Horizontal=�6   .+�5/      (  "System.Windows.Controls.DatePicker  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ngày bắt đầu��6!   $��LeftToRight=�50   1   $��25(�52   1   $��20,0,3,0q�53   1   $	��200��54   !   ��51   1   ��  �� ElementName$	 Gr1�� �� Path$ ActualHeight� �� 	Converter :  4MayEpCHADesktopApp.Core.ValueConverter.SizeConverter   �� ConverterParameter$	 0.9��54   !   �� 55      $��28(�6   $��Center=�6*   $��Center=�56      $��50 0 0 0q�57      .��6.   Ca:63   �� 58      $ 	Chọn ca��6   $��LeftToRight=�59   1   $��25(�5;   1   $��1q�5<   1   $��10,0,3,0q�5=   1   $��20 5 5 5q�5>   1   $	��200��5?   !   ��5:   1   �� $	 Gr1��$ ActualHeight�   $	 0.9��5?   !   5@      5A      5B      � 5C   
   $��2��6   .+�5D        $��0 5 0 5q�6"   .��5E      �� $ 
Horizontal=�6   .+�5G      ��   MaterialDesignRaisedButton#���  6   ���	#FF00294D$	��200��5J   1   $��60��5K   1   $��25(�5L   1   $��20 0 0 0q�5M      .��5N   2   Truy Xuất5P      �� 5Q      #���  6   ���	#FF00294D$	��200��5T   1   $��60��5U   1   $��25(�5V   1   $��20 0 0 0q�5W      .��5X   2   Xuất EXCEL5Z      5[      5\      5]      � 5^   
   $��3��6   .+�5_      �� ._�5`      &   System.Windows.Controls.DataGrid  $��5 5 5 10q�6     DataGrid#��[ 5a      $
��1233��5b      $��Center=�5c      ��5d      �� $ Griddata��$ ActualHeight�   $
 0.95��	 � 	Resources	 5g      =  7System.Windows.Controls.Primitives.DataGridColumnHeader
 �� 
TargetType �� Property �� Value��%,  '        �� 5h      "
  6    .�5j      ��  � ��$ 25��67   6D   �� 5k       � ��$ 40��67   6D   �� 5l       � ��$ Center=�6K   6\   �� 5m       � �� �	#FF00294D6O   �� 5n       � ��
 �����6K   �� 5o       � ��$ Center=�6I   6Z   5p      5r         	CellStyle 5t      �� 5v      *  $System.Windows.Controls.DataGridCell"
  6     �� Triggers 5x      P� 5z   "    P� Property �@ 
IsSelected P� Value$
 True��6@   . �5|   &   ��  � ��
 �����6C   5~   #   5�         Columns 5�      0	  *System.Windows.Controls.DataGridTextColumn	  5�      ,
  &System.Windows.Controls.DataGridColumn 
  Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6.   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
employeeID+ 
  HeaderTemplate 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   ��  �� Padding$ 0 0 5 5q�64   $	��STT��6F   $��25(�6Q   6b   !  FontAwesome.WPF.FontAwesome  5�   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48   Icon$ 	ArrowDown=�6o   6�   5�   '   5�   #    	  
Foreground 5�      �� 5�   "    �� Color$ Black��62      ElementStyle 5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��
 ���� 6Y   �� 5�   &    � {�$ False��6B   6R   5�   #   5�      	  5�       
  Header$ Employee Name��6-   $	 200 6D    6P   �� *employeeName+ 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   �� $ 0 0 5 5q�64   $��Mã số��6F   $��25(�6S   6d     5�   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5�   '   5�   #    5�      �� 5�   "   $ Black��62    5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��
 ���� 6Y   5�   #   5�      	  5�      $ Employee Adress��6-   $	 200 6F    6R   �� *employeeAdress+ 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   �� $ 0 0 5 5q�64   $��Tên sản phẩm��6F   $��25(�6Z   6k     5�   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5�   '   5�   #    5�      �� 5�   "   $ Black��62    5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��
 ���� 6Y   5�   #   5�      	  5�      $ Employee City��6-   $	 200 6D    6P   �� *employeeCity+ 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   �� $ 0 0 5 5q�64   $��Đơn vị ��6F   $��25(�6U   6f     5�   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5�   '   5�   #    5�      �� 5�   "   $ Black��62    5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��
 ���� 6Y   5�   #   5�      	  5�      $ Employee State��6-   $	 200 6E    6Q   �� *employeeState+ 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   �� $ 0 0 5 5q�64   $��Định mức��6F   $��25(�6V   6g     5�   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5�   '   5�   #    5�      �� 5�   "   $ Black��62    5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��
 ���� 6Y   5�   #   5�      	  5�      $ Employee State��6-   $	 200 6E    6Q   �� *employeeState+ 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   �� $ 0 0 5 5q�64   $��Kết quả sản xuất��6F   $��25(�6^   6o     5�   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5�   '   5�   #    5�      �� 5�   "   $ Black��62    5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��
 ���� 6Y   5�   #   5�      	  5�      $ Employee State��6-   $	 200 6E    6Q   �� *employeeState+ 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   �� $ 0 0 5 5q�64   $��Mã sản phẩm��6F   $��25(�6Y   6j     5   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5  '   5  #    5     �� 5  "   $ Black��62    5     �� 5  "   "
 ��6(   .�5	  &   ��  � ��$ Center=�6L   �� 5
  &    � ��
 ���� 6Y   5  #   5     	  5     $ Employee State��6-   $	 200 6E    6Q   �� *employeeState+ 5     �� 5  "   .R�5  &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5  *   �� $ 0 0 5 5q�64   $��Định mức��6F   $��25(�6V   6g     5  *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5  '   5  #    5     �� 5  "   $ Black��62    5     �� 5  "   "
 ��6(   .�5  &   ��  � ��$ Center=�6L   �� 5  &    � ��
 ���� 6Y   5  #   5      	  5!     $ Employee State��6-   $	 200 6E    6Q   �� *employeeState+ 5"     �� 5#  "   .R�5$  &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5%  *   �� $ 0 0 5 5q�64   $��Số lượng��6F   $��25(�6V   6g     5&  *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5'  '   5(  #    5*     �� 5+  "   $ Black��62    5-     �� 5.  "   "
 ��6(   .�5/  &   ��  � ��$ Center=�6L   �� 50  &    � ��
 ���� 6Y   51  #   53     	  54     $ Employee State��6-   $	 200 6E    6Q   �� *employeeState+ 55     �� 56  "   .R�57  &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�58  *   �� $ 0 0 5 5q�64   $��Định mức��6F   $��25(�6V   6g     59  *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5:  '   5;  #    5=     �� 5>  "   $ Black��62    5@     �� 5A  "   "
 ��6(   .�5B  &   ��  � ��$ Center=�6L   �� 5C  &    � ��
 ���� 6Y   5D  #   5F     5H     5J     5L     5M     5S     