   M S B A M L   `   `   `  ����  BoletosDesktop    BoletosDesktop.Boletos   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Crear Boleto��5   	   $	��450��6   $	��800��6+   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��ID de Evento:��6   �� 5   
   -   5         ��Name$ idEventoComboBox��5       $��1��6    �� DisplayMemberPath$ eventoId��6:    �� SelectedValuePath$ eventoId��6W   �� 5   
   $��2��6   $��Cantidad de Boletos:��6   �� 5   
   -   5         ��Name$ cantidadBoletosTextBox��5      $��3��6   6   �� 5   
   $��6��6   $��Tipo de Asiento:��6   �� 5   
   -   5        $ tipoAsientoTextBox��5      $��7��6   $��	0,0,0,-18q�6;   �� 5   
   $��4��6   $��Precio:��6   �� 5   
   -   5        $ precioTextBox��5      $��5��6   6   �� 5   
   -   5        $��7��5      $��Guardar��6   $��
0,55,0,-94q�6R   5       5!      