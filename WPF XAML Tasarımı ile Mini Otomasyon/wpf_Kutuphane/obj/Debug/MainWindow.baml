   M S B A M L   `   `   `  ����H  Dwpf_Kutuphane, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:wpf_Kutuphanewpf_Kutuphane  5   	       wpf_Kutuphane.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:wpf_Kutuphane     5   	     � Title$!  Kullanıcı Giriş Sayfası��5   	   $	��500��6)   $	��750��66    � WindowStartupLocation$ CenterScreen=�6C   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      $
��100* �6   �� 5      $	��27* �6   �� 5      $
��575* �6   ��5   
   �� 5       �� ImageSource$$ İmages/kutuphane arkaplan.jpg��6    j� TileMode$ FlipX=�6E   .+�5   
   �� $��3��6   
�������$0��*Kütüphane WPF Tasarımı Giriş Sayfası��63   $
��Left=�6b   $
��Bold"�6}   $��	36,64,0,0q�6�   $	��Top=�6�   $��22(�6�   $��46��6�   $	��407��6�   �� 5   
   $��3��6   $��İmages/username.png��6    $��92,-76,453,75q�6=   �� 5   
   $��3��6   $��İmages/password.png��6    $��91,17,453,-19q�6=   �� 5   
   -   5        $��txt_Username��5      $��3��6&   $
��Left=�66   $��166,141,0,0q�6Q   $��24(�6f   $	��Top=�6t   $	��192��6�   $��37��6�   G� 5   
   -   5        $��txt_password��5      $��24(�6*   $��3��68   $
��Left=�6H   $��166,242,0,0q�6c   $	��Top=�6x   $	��192��6�   $��36��6�   6�   �� 5   
   -   5        $��Login��5   �   $��3��6   $��0q�6!   $
��Left=�66   $��345,316,0,0q�6Q   $	��Top=�6f   
������ $	��109��6�   $��55��6�   .��5      �� $��İmages\login.png��6   60   5      5      5      