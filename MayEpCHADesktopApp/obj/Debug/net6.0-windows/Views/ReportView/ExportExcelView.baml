   M S B A M L   `   `   `  ����M  IMayEpCHADesktopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:MayEpCHADesktopApp.Resources.Components'MayEpCHADesktopApp.Resources.Components  5      R NMayEpCHADesktopApp.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Uclr-namespace:MayEpCHADesktopApp.Core.ValueConverter;assembly=MayEpCHADesktopApp.Core&MayEpCHADesktopApp.Core.ValueConverter 5      9    3MayEpCHADesktopApp.Views.ReportView.ExportExcelView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      L
components5clr-namespace:MayEpCHADesktopApp.Resources.Components     5      Hi:http://schemas.microsoft.com/expression/2010/interactivity     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      e	ConverterUclr-namespace:MayEpCHADesktopApp.Core.ValueConverter;assembly=MayEpCHADesktopApp.Core  5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $	��824��5       $��1267.2��5!      .��5#      �  � RowDefinitions 5$   
   �� 5%      $
��0.8* �6   �� 5&      $��0.67* �6   �� 5'      $��0.75* �6   �� 5(      $
��4.5* �6   .+�5*   
   � $��0��6   .+�5+      #  MaterialDesignThemes.Wpf.Card  $	��1 2q�6"   .��5,      �� $��38(�6   $
��Bold"�5-      $��Center=�5.      $��Center=�5/      $��Bottom=�50      $��0 0 0 10q�51      .��6+   BÁO CÁO SẢN XUẤT53      54      55      � 56   
   $��1��6   .+�57        $
��0 5 q�6"   .��58      ��  �� Orientation$ 
Horizontal=�6   .+�59      (  "System.Windows.Controls.DatePicker  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ngày bắt đầu��6!   $��LeftToRight=�5:   1   $��25(�5=   1   $��20,0,3,0q�5>   1   $	��200��5?   !   ��5<   1   ��  �� ElementName$	 Gr1�� �� Path$ ActualHeight� �� 	Converter :  4MayEpCHADesktopApp.Core.ValueConverter.SizeConverter   �� ConverterParameter$	 0.9��5?   !     5@      $ Ngày kết thúc��6!   $��LeftToRight=�5A   1   $��25(�5C   1   $��50,0,3,0q�5D   1   $	��200��5E   !   ��5B   1   �� $	 Gr1��$ ActualHeight�   $	 0.9��5E   !   5F      5G      5H      � 5I   
   $��2��6   .+�5J        $	��0 5q�6"   .��5K      �� $ 
Horizontal=�6   .+�5M      ��   MaterialDesignRaisedButton#���  6   ���	#FF00294D$	��200��5P   1   $��60��5Q   1   $��25(�5R   1   $��20 0 0 0q�5S      .��5T   2   Truy Xuất5V      �� 5W      #���  6   ���	#FF00294D$	��200��5Z   1   $��60��5[   1   $��25(�5\   1   $��20 0 0 0q�5]      .��5^   2   Xuất EXCEL5`      5a      5b      5c      � 5d   
   $��3��6   .+�5e      �� ._�5f      &   System.Windows.Controls.DataGrid  $��5 5 5 10q�6     DataGrid#��[ 5g      $
��1233��5h      $��Center=�5i      ��5j      �� $ Griddata��$ ActualHeight�   $
 0.95��	 � 	Resources	 5m      =  7System.Windows.Controls.Primitives.DataGridColumnHeader
 �� 
TargetType �� Property �� Value��%,  '        �� 5o      "
  6    .�5q      ��  � ��$ 25��67   6D   �� 5r       � ��$ 40��67   6D   �� 5s       � ��$ Center=�6K   6\   �� 5t       � �� �	#FF00294D6O   �� 5u       � ��
 �����6K   �� 5v       � ��$ Center=�6I   6Z   5w      5y         	CellStyle 5{      �� 5}      *  $System.Windows.Controls.DataGridCell"
  6     �� Triggers 5      P� 5�   "    P� Property �@ 
IsSelected P� Value$
 True��6@   . �5�   &   ��  � ��
 �����6C   5�   #   5�         Columns 5�      0	  *System.Windows.Controls.DataGridTextColumn	  5�      ,
  &System.Windows.Controls.DataGridColumn 
  Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6.   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
employeeID+ 
  HeaderTemplate 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   ��  �� Padding$ 0 0 5 5q�64   $	��STT��6F   $��25(�6Q   6b   !  FontAwesome.WPF.FontAwesome  5�   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48   Icon$ 	ArrowDown=�6o   6�   5�   '   5�   #    	  
Foreground 5�      �� 5�   "    �� Color$ Black��62      ElementStyle 5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��
 ���� 6Y   �� 5�   &    � {�$ False��6B   6R   5�   #   5�      	  5�       
  Header$ Employee Name��6-   $	 200 6D    6P   �� *employeeName+ 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   �� $ 0 0 5 5q�64   $��	Ngày ép��6F   $��25(�6U   6f     5�   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5�   '   5�   #    5�      �� 5�   "   $ Black��62    5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��
 ���� 6Y   5�   #   5�      	  5�      $ Employee Adress��6-   $	 200 6F    6R   �� *employeeAdress+ 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   �� $ 0 0 5 5q�64   $��Ca ép��6F   $��25(�6S   6d     5�   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5�   '   5�   #    5�      �� 5�   "   $ Black��62    5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��
 ���� 6Y   5�   #   5�      	  5�      $ Employee City��6-   $	 200 6D    6P   �� *employeeCity+ 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   �� $ 0 0 5 5q�64   $��Trưởng ca ��6F   $��25(�6X   6i     5�   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5�   '   5�   #    5�      �� 5�   "   $ Black��62    5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��
 ���� 6Y   5�   #   5�      	  5�      $ Employee State��6-   $	 200 6E    6Q   �� *employeeState+ 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   �� $ 0 0 5 5q�64   $��Máy ép��6F   $��25(�6T   6e     5�   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5�   '   5�   #    5�      �� 5�   "   $ Black��62    5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��
 ���� 6Y   5�   #   5�      	  5�      $ Employee State��6-   $	 200 6E    6Q   �� *employeeState+ 5�      �� 5�   "   .R�5�   &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5�   *   �� $ 0 0 5 5q�64   $��
Mã khuôn��6F   $��25(�6V   6g     5�   *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5�   '   5�   #    5�      �� 5�   "   $ Black��62    5�      �� 5�   "   "
 ��6(   .�5�   &   ��  � ��$ Center=�6L   �� 5�   &    � ��
 ���� 6Y   5�   #   5     	  5     $ Employee State��6-   $	 200 6E    6Q   �� *employeeState+ 5     �� 5  "   .R�5  &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5  *   �� $ 0 0 5 5q�64   $��Mã sản phẩm��6F   $��25(�6Y   6j     5  *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5  '   5	  #    5     �� 5  "   $ Black��62    5     �� 5  "   "
 ��6(   .�5  &   ��  � ��$ Center=�6L   �� 5  &    � ��
 ���� 6Y   5  #   5     	  5     $ Employee State��6-   $	 200 6E    6Q   �� *employeeState+ 5     �� 5  "   .R�5  &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5  *   �� $ 0 0 5 5q�64   $��Định mức��6F   $��25(�6V   6g     5  *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5  '   5  #    5     �� 5  "   $ Black��62    5!     �� 5"  "   "
 ��6(   .�5#  &   ��  � ��$ Center=�6L   �� 5$  &    � ��
 ���� 6Y   5%  #   5'     	  5(     $ Employee State��6-   $	 200 6E    6Q   �� *employeeState+ 5)     �� 5*  "   .R�5+  &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5,  *   �� $ 0 0 5 5q�64   $��Số lượng��6F   $��25(�6V   6g     5-  *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5.  '   5/  #    51     �� 52  "   $ Black��62    54     �� 55  "   "
 ��6(   .�56  &   ��  � ��$ Center=�6L   �� 57  &    � ��
 ���� 6Y   58  #   5:     	  5;     $ Employee State��6-   $	 200 6E    6Q   �� *employeeState+ 5<     �� 5=  "   .R�5>  &   �� $��2 4 2 2q�61   $ 
Horizontal=�6B   .+�5?  *   �� $ 0 0 5 5q�64   $��Định mức��6F   $��25(�6V   6g     5@  *   $��	5 10 0 -2q�69   $��30��6L   ���	#FF68EB48$ 	ArrowDown=�6o   6�   5A  '   5B  #    5D     �� 5E  "   $ Black��62    5G     �� 5H  "   "
 ��6(   .�5I  &   ��  � ��$ Center=�6L   �� 5J  &    � ��
 ���� 6Y   5K  #   5M     5O     5Q     5S     5T     5Z     