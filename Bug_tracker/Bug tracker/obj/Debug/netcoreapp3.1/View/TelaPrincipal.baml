   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5   	   F BBug_tracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Bug_tracker.ViewModelBug_tracker.ViewModel 5   	   $   Bug_tracker.View.TelaPrincipal   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   9	viewmodel#clr-namespace:Bug_tracker.ViewModel     5   	     � Title$  TelaPrincipal��5
   	   $	��450��6   $	��800��6,   .   (System.Windows.Interactivity.Interaction   Triggers 5      /   )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .   (System.Windows.Interactivity.TriggerBase   Actions. 5      6   0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
ListarBugs+5      .��5      �  � 	Resources 5   
    �� 
TargetType �� Property �� Value��%'  '��       '�� u     �� 5      " ��6   .�5      ��  � ��$ 
10,0,10,10q�6+   �� 5       � ��$	 Top=�66   5      �� 5      " ��6   .�5      ��  � ��$ Center=�68   �� 5       � ��$ Bottom=�66   �� 5       � ��$ 20,0,0,0q�6+   5      5      	 � ColumnDefinitions	 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $��20 �6   
 � RowDefinitions
 5*   
   �� 5+      $��20 �6   �� 5,      $��20 �6   �� 5-      $��* �6   �� 5.      $��* �6   �� 5/      $��* �6   �� 50      $��* �6   �� 51      $��20 �6   .+�53   
   �� $��
Prioridade��6   $��1��6&   $��1��64   �� 54   
   $��2��6   $��1��55      $��30��56      $	��Top=�57       �� SelectedValue 58      �� *Bug.Prioridade+��59      �� *Prioridades+�� 5:   
   $��Autor��6   $��1��6!   $��2��6.   �� 5;   
   $��30��6   $��2��6:   $��2��6G   ��6   �� *	Bug.Autor+6G   �� 5<   
   $��Versão��6   $��1��6"   $��3��6/   �� 5=   
   $��30��6   $��2��6;   $��3��6H   ��6   �� *
Bug.Versao+6H   �� 5>   
   $��Comentário��6   $��1��6&   $��4��63   �� 5?   
   $��2��6   $��4��6"   .+�5@      �� $��78��6    �� TextWrapping$
 Wrap=�6B   ��6"   �� *Bug.Comentario+6B   5A      �� 5B   
   $��1��6   $��5��6#   $��Descrição��63   �� 5C   
   $��2��6   $��5��6#   .+�5D      �� $��78��6   $
 Wrap=�6A   ��6"   �� *Bug.Descricao+6A   5E      �� 5F   
   $
��Tela��6   $��1��6!   $��6��6.   �� 5G   
   $��30��6   $��2��69   $��6��6F   ��6   �� *
Bug.Tela+6F   �� 5H   
   $��	Adicionar��6   $��2��6%   $��7��62   $	��Top=�6`   $��60��6x   $��20��6�   ��6B   �� *	Adicionar+6�   �� 5I   
   $��1��6   $��70��6"   $��30��6-   $��3��69   $��Filtrar��6F   ��6X   �� *	Filtrar+�� 5J   
   $��2��6   $��2��6!   $	��140��66   $��30��6B   $��3��6N   $��Limpar Prioridade��6[   ��6w   �� *LimparPrioridade+�� 5K   
   $��4��6   $��2��6!   $	��140��65   $��30��6A   $��3��6M   $��Limpar Tudo��6Z   ��6p   �� *LimparCampos+�� 5L   
   $��3��6   $��6��6"   $��2��62   .+�5M      �� $��Ordenar��6   $��3��6'   $��Center=�6;   �� 5N      $	��140��6    6#   �� *SelectedOrder+��6K   �� *OrdenarList+�� 5O       6   �� *CrescenteDecrescenteSelected+��6N   �� *CrescenteDecrescenteList+�� 5P      $��Ordenar��6   ��6'   �� *	Ordenar+5Q      &   System.Windows.Controls.DataGrid  5R      $��4��6      
IsReadOnly$
 True��5S      $��2��5T      $��1��5U      $��8��5V         CanUserAddRows$ False��6'      AutoGenerateColumns$ False��5W      ��5Y      �� *	ListaBugs+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5Z      0  *System.Windows.Controls.DataGridTextColumn  5[      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6%      Header$ 
Prioridade��6Q   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 62   �� *
Prioridade+6Q     5\      $
 auto 6%   $ Autor��6L    62   �� *Autor+6L     5]      $
 auto 6%   $ Versão��6M    62   �� *Versao+6M     5^      $
 auto 6%   $ Comentário��6Q    62   �� *
Comentario+6Q     5_      $
 auto 6%   $ Descrição��6P    62   �� *	Descricao+6P     5`      $
 auto 6%   $
 Tela��6K    62   �� *Tela+6K   4
  .System.Windows.Controls.DataGridTemplateColumn
  5a       
  CellTemplate 5b      �� 5c      .R�5d      ��  �� Orientation$ 
Horizontal=�6)   .+�5e   "   �� $��Deletar��6�   ��6)   �� *Id+��6I   �� *DataContext.Deletar+ �� RelativeSource ��  �� AncestorType" �6�   �� 5f   "   $��Editar��6�   ��6)   �� *Id+��6I   �� *DataContext.Editar+ �� "  6�   5g      5h      5j      5l      5m      5p      