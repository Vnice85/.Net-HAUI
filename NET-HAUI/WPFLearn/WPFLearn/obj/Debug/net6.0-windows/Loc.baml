   M S B A M L   `   `   `  ����E  AMyFirstWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPFLearnWPFLearn  5   	       WPFLearn.Loc   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPFLearn     5   	     � Title$	  Loc��5   	   $	��450��6   $	��800��6"   .��5	      �  � 	Resources 5
   
   =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%  '        �� 5      "  6   .�5      ��  � ��$ Center=�6?   �� 5       � ��
 �����6/   �� 5       � ��$ 40��6+   �� 5       � ��$ SemiBold"�6/   �� 5       � ��$ 1q�64   �� 5       � ��
 �����60   5      5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $	��dtg��5      $��0��6   $��2��6.   $��6��6B      AutoGenerateColumns$ False��6O      CanUserAddRows$ False��6k      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã nhân viên��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 6;   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6F   �� *MaNV+  5      $ Họ và tên��6%   $	 1* 68   
 6C   �� *Ten+  5      $ 
Ngày sinh��6%   $	 1* 68   
 6C   �� *
NgaySinh+ �� StringFormat$ 
dd/MM/yyyy��  5      $ Giới tính��6%   $	 1* 68   
 6C   �� *
GioiTinh+  5      $ 
Phòng ban��6%   $	 1* 68   
 6C   �� *
PhongBan+  5      $ Hệ số lương��6%   $	 1* 6:   
 6E   �� *	HeSoLuong+5       5!      5"      