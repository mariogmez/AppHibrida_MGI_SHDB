   M S B A M L   `   `   `  ����N  JAppHibrida_MGI_SHDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:AppHibrida_MGI_SHDB.ViewModelAppHibrida_MGI_SHDB.ViewModel  5   	   9!clr-namespace:AppHibrida_MGI_SHDBAppHibrida_MGI_SHDB  5   	   #    AppHibrida_MGI_SHDB.VentanaPc   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :vm+clr-namespace:AppHibrida_MGI_SHDB.ViewModel     5   	   3local!clr-namespace:AppHibrida_MGI_SHDB     5   	     � Title$  	VentanaPc��5	   	   $	��450��6   $	��800��6(    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � 	Resources 5      7   1AppHibrida_MGI_SHDB.ViewModel.CollectionViewModel   ColeccionVM  txt �� 
TargetType �� Property �� Value  Stack_H  Stack_V  Brd��%9  &	        &	      &	 �     &	 .    &	 �      5   
   6!   �� 5   
   " ��6   .�5      ��  � ��$ WordEllipsis=�6-   �� 5       � ��$
 Wrap=�6-   �� 5       � ��$ 50��6*   �� 5       � ��$ 5q�6'   5      �� 5   
   " ��6    .�5      ��  �@��Orientation$ 
Horizontal=�6,   5      �� 5   
   " ��6    .�5      ��  � ��$	 570��6&   �� 5       � ��$ 2q�6'   5      �� 5   
   " ��6   .�5      ��  � ��
 �����6,   �� 5       � ��$ 2q�60   5      5      .��5       �  � ShowGridLines . $��Center=�6    $��Center=�5!      
�������$	��450��5"      $	��800��6    � ColumnDefinitions 5#   
   �� 5$      $��* �6   �� 5%      $��* �6   .+�5'   
   �� -   5        $��btnClientes��5'   !   $��0��6   $��20(�64   $
��Bold"�6B   .��6n   Gestion de Clientes6�   �� 5(   
   -   5        $��
btnPedidos��5(   !   $��1��6   $��20(�63   $
��Bold"�6A   .��6l   Gestion de Pedidos6�   5)      5*      