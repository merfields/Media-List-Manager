   M S B A M L   `   `   `  ����W  SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� Color   DataGridCellDefaultStyle �� 
TargetType*   $System.Windows.Controls.DataGridCell �� Property �� Value �� 
TargetType J� SnapsToDevicePixels �� Triggers P� Property P� Value  ButtonHighlightColor  MainBrightColor  DataGridDefaultRowStyle)  #System.Windows.Controls.DataGridRow  ApplicationRedColor	 ��Name?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid
 � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter&   System.Windows.Controls.DataGrid#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7  1System.Windows.Controls.DataGridHeadersVisibility
   Row!   HeadersVisibilityConverter  DataGridColumnHeaderDefault=	  7System.Windows.Controls.Primitives.DataGridColumnHeader  MainTextColor�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�  (��       5      *DataGrid.FocusBorderBrushKey+)&	  #     7  7  &	 c    7  7  &	 0    7  �� 6   $  	#FF000000��5      �� 5	      "   5
      .�5   
   ��  � ��
 ���� 5      �� 5   
    � ��
 ���� 5      �� 5   
    � ��$ 0q�5      �� 5   
    � �� 5      �� 5      "   6"   .R�5      �� #��z��6   #��z��5      $��0q�5      $
 True��5      ._�5      �� # z 6+   5      5      5       5   
   P� 5        �@J�IsMouseOver$
 True��5!      . �5"      ��  � ��8   5#      5$      P� 5%       �@  
IsSelected$
 True��5&      . �5'      ��  � ��8  5(      5)      5+      �� 51      "  52      .�53   
   ��  �@J�SnapsToDevicePixels$
 true��54      �� 55   
    �@=�ErrorTemplate 56      Z� �� 58   
    �@ ValidationErrorTemplate 59      �� 5:      .R�5;      �� 8��  $��2,0,0,0q�5<       $��!��5=       $��Center=�5>       5?      5A      �� 5C   
    � �� 5D      �� 5E      "  6"   .R�5F      �� $	 
DGR_Border��6   $��0q�5G      $
 True��5H      ._�5I        
 5J      �� 5K   "   $
��Auto �63   �� 5L   "   $��* �63    5N      �� 5O   "   $��* �60   �� 5P   "   $
��Auto �60   .+�5R        $��1��65   #��z 5S   5   # z 5T   5     5U      $��1��67   $��1��5V   7   #y�z 5X   7    5W   7   �� *AreRowDetailsFrozen+# Z # Z  �� "  5X   7     5Y      $��2��60   $ Vertical=�5Z   0   y�5[   0   �� *HeadersVisibility+# Z # Z  �� "  5\      5]      5^      5`       5a   
   P� 5b       �@ 
IsSelected$
 True��5c      . �5d      ��  � ��8  5e      5f      P� 5h       �@ 	IsNewItem$
 True��5i      . �5j      ��  � �� 5k      �� *NewItemMargin+ �� "  5l      5n      �� 5q      " 	 5r      .�5s   
   ��  � ��
 ���� 5t      �� 5u   
    � ��8   5v      �� 5w   
    � ��$ Center=�5x       5y   
   P� 5z       �@J�IsMouseOver$
 True��5{      . �5|      ��  �@�ToolTip$ Click to sort.��5}      5~      5�      5�      