   M S B A M L   `   `   `  ����B  >Semana6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Semana6.ViewSemana6.View  5   	   !    Semana6.View.ListaProductos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Semana6.View     5   	     � Title$  ListaProductos��5   	   $	��450��6    $	��800��6-    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Comic Sans MS)�6+   �� 5       � ��$ 14(�6)   5      5      .��5      � .+�5   
   �� .+�5      �� .+�5      �� $��LISTA DE PRODUCTOS��6   5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ botonConsultar��5      ��61   �� *ConsultarCommand+.��6W   	Consultar6b   �� 5      -   5        $ 
botonNuevo��5      ��6-   �� *NuevoCommand+.��6N   Nuevo6U   5      �� 5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgvProducto��5   *   $��180px��6      AutoGenerateColumns . 	   GridLinesVisibility$	 Vertical=�5      
   HeadersVisibility$	
 All=�6:   
�������   RowBackground
 �����   AlternatingRowBackground
 ��ح�
�������$��5q�5   .   ��6B   �� *	Productos+5      5      5       5!      5"      