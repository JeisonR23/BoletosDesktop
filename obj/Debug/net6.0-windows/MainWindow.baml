   M S B A M L   `   `   `  ����I  EBoletosDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BoletosDesktopBoletosDesktop  5   	       BoletosDesktop.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:BoletosDesktop     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��61* �6   �� 5      $
��339* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Eventos��6   $��20(�6#   $
��Bold"�61   $
��Left=�6C   $��
10,10,0,20q�6^   $��1��6r   �� 5   
   -   5         ��Name$ eventosListBox��5      $��1��6   $��20,20,20,20q�67   $��2��6   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��5q�6B   ��6$   �� *nombreEvento+6B   �� 5      $��5q�6A   ��6$   �� *descripcion+6A   �� 5      $��5q�6;   ��6$   �� *fecha+6;   �� 5      $��5q�6?   ��6$   �� *	ubicacion+6?   5       5!      5#      �� 5&   
   $��1��6   $
��Left=�6"   $	��Top=�6=   $��
20,317,0,0q�6U   $ 
Horizontal=�6i   $��1��6�   .+�5'      �� -   5        $��Obtener Eventos��5'      $��10q�6R   �� 5(      -   5        $��Crear Evento��5(      $��10q�6L   �� 5)      -   5        $��Ir a Boletos��5)      $��10q�6K   5+      5,      5-      