   M S B A M L   `   `   `  ����I  EBoletosDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BoletosDesktopBoletosDesktop  5   	   !    BoletosDesktop.CrearEventos   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .localclr-namespace:BoletosDesktop     5   	     � Title$  Crear Evento��5   	   $	��450��6   $	��800��6+   .��5      �  � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Nombre del Evento:��6   �� 5   
   -   5         ��Name$ nombreEventoTextBox��5      $��1��6   ��6<   �� *NombreEvento+ �� Mode$ TwoWay=� �� RelativeSource ��  �� AncestorType local:CrearEventos�� 5   
   $��2��6   $��Descripción:��6   �� 5   
   -   5        $ descripcionTextBox��5      $��3��6    �� TextWrapping$
 Wrap=�6;    �� AcceptsReturn$
 True��6O   ��6d   �� *Descripcion+$ TwoWay=� ��  local:CrearEventos�� 5   
   $��4��6   $��Fecha:��6   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ fechaDatePicker��5   "   $��5��6   	   SelectedDate	 6;   �� *Fecha+$ TwoWay=� ��  local:CrearEventos�� 5   
   $��6��6   $��Ubicación:��6   �� 5   
   -   5        $ ubicacionTextBox��5      $��7��6   ��69   �� *	Ubicacion+$ TwoWay=� ��  local:CrearEventos�� 5    
   -   5        $��8��5       $��Guardar��6   60   5!      5"      