   M S B A M L   `   `   `  ����R  NMayEpCHADesktopApp.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Uclr-namespace:MayEpCHADesktopApp.Core.ValueConverter;assembly=MayEpCHADesktopApp.Core&MayEpCHADesktopApp.Core.ValueConverter  5       MayEpCHADesktopApp8   2MayEpCHADesktopApp.Resources.Components.ButtonMenu   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      k	ConverterUclr-namespace:MayEpCHADesktopApp.Core.ValueConverter;assembly=MayEpCHADesktopApp.Core     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          >�Name$
  Root��5      ��5      ��  �� ElementName$
 Root�� �� Path$ BackgroundBTMenu�.��5"   
   � ��6   �� $
 Root��$ ActualHeight���5#      �� $
 Root��$ ActualWidth���5$      �� 5%       �� 
TargetType" �6    �� Triggers 5&      �� 5'       �� Binding 6&   �� $
 Root��$ IsMouseOver� �� Value True6\   .a�5(      ��  �� Property � �� �� Value
 ��� �6Q   5)      5+      .+�5-      �� -   5        	 ��Name$	 
MainButton��5-      
������    
MenuButton#��[  51      $��0 0 8 0 q�52      ��5.      �� $
 Root��$ ActualHeight���5/      �� $
 Root��$ ActualWidth���53      �� $ BoderBrushBTMenu�$
 Root����56      � 57      $y�Visible=�6   
������ ��58      �� $
 Root��$ ActualHeight���59      �� $
 Root��$ ActualWidth�.+�5:      � -   5        
 �Name$
 GridNoClick��5:      
������ y�64   �� $
 Root��$ 
Animation1�   BooleanToVisibilityConverter �� 	Converter# [ ��5;      �� $
 Root��$ ActualHeight���5<      �� $
 Root��$ ActualWidth�.+�5?      �� 
������  �� Orientation$ 
Horizontal=�5B   '   ��5@   '   �� $
 Root��$ ActualHeight���5A   '   �� $
 Root��$ ActualWidth�.+�5C   "   '  !MaterialDesignThemes.Wpf.PackIcon  $��0 5 0 -5q�5F   <   ��5C   ;   �� $
 Root��$ ActualHeight� :   4MayEpCHADesktopApp.Core.ValueConverter.SizeConverter   �� ConverterParameter$	 0.8����5D   <   �� $
 Root��$ ActualWidth�   $	 0.3����5E   <   �� $ ForegroundPackicon�$
 Root��   Kind 5G   ;   �� $ NamePackIcon�$
 Root��5K   #   �� 5L   "   
������ $
��Left=�5R   (   $��Center=�5S   (   ��5L   (   �� $
 Root��$ ContentText���5M   (   �� $
 Root��$ ActualHeight���5N   (   �� $
 Root��$ ActualWidth�   $	 0.7����5O   (   �� $
 Root��$ ActualHeight�   $
 0.35����5Q   (   �� $ ForegroundText�$
 Root��5T   +   5U      5V      � 5W      -   5        $
 	GridClick��5W      
������ y�5X       �� $
 Root��$ 
Animation2�# [ ��5Y       �� $
 Root��$ ActualHeight���5Z       �� $
 Root��$ ActualWidth�.+�5\      �� 
������ $ 
Horizontal=�5_   '   ��5]   (   �� $
 Root��$ ActualHeight���5^   (   �� $
 Root��$ ActualWidth�.+�5`   "   �� $��	0 -5 0 5 q�5b   (   $	��184��5c   )   
������ $��Center=�5g   (   $��Center=�5h   (   ��5`   (   �� $
 Root��$ ContentText���5a   )   �� $
 Root��$ ActualHeight���5d   (   �� $
 Root��$ ActualHeight�   $	 0.4����5f   (   �� $ ForegroundText�$
 Root��5i   +     5j      $��0 0 0 0q�5m   <   ��5j   8   �� $
 Root��$ ActualHeight�   $	 0.8����5k   <   �� $
 Root��$ ActualWidth�   $	 0.3����5l   <   �� $ ForegroundPackicon�$
 Root�� 5n   <   �� $ NamePackIcon�$
 Root��5q      5r      5s      5y      5~      �� 5   
   $��1��5�      $��Bottom=�5�      ���	#FF838156��5�      �� $
 Root��$ ActualWidth�5�      5�      5�      