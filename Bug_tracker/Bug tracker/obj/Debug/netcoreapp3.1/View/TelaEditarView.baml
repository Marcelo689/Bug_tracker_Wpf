   M S B A M L   `   `   `  ����F  BBug_tracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Bug_tracker.ViewBug_tracker.View  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	   %    Bug_tracker.View.TelaEditarView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Bug_tracker.View     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	     � Title$  TelaEditarView��5	   	   $	��450��6    $	��800��6-   .  (System.Windows.Interactivity.Interaction   Triggers 5
      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
PegarBug+5      .��5      �  � 	Resources 5   
    �� 
TargetType �� Property �� Value��%   '��       '�� v     �� 5      " ��6   .�5      ��  � ��$ 10,10,10,10q�6+   �� 5       � ��$	 Top=�66   5      �� 5      " ��6   .�5      ��  � ��$ Center=�68   �� 5       � ��$ 20,0,0,0q�6+   5      5      	 � ColumnDefinitions	 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $��20 �6   
 � RowDefinitions
 5(   
   �� 5)      $��20 �6   �� 5*      $��20 �6   �� 5+      $��* �6   �� 5,      $��* �6   �� 5-      $��* �6   �� 5.      $��* �6   �� 5/      $��20 �6   .+�51   
   �� $��
Prioridade��6   $��1��6&   $��1��64   �� 52   
   $��2��6   $��1��53      $��30��54      $��Center=�6    �� SelectedValue 55      �� *Bug.Prioridade+��56      �� *Prioridades+�� 57   
   $��Autor��6   $��1��6!   $��2��6.   �� 58   
   $��Center=�6   $��30��6-   $��2��6T   $��2��6a   ��69   �� *	Bug.Autor+6a   �� 59   
   $��Versão��6   $��1��6"   $��3��6/   �� 5:   
   $��Center=�6   $��30��6-   $��2��6U   $��3��6b   ��69   �� *
Bug.Versao+6b   �� 5;   
   $��Comentário��6   $��1��6&   $��4��63   �� 5<   
   $��2��6   $��4��6"   .+�5=      �� $��78��6    �� TextWrapping$
 Wrap=�6B   ��6"   �� *Bug.Comentario+6B   5>      �� 5?   
   $��1��6   $��5��6#   $��Descrição��63   �� 5@   
   $��2��6   $��5��6#   .+�5A      �� $��78��6   $
 Wrap=�6A   ��6"   �� *Bug.Descricao+6A   5B      �� 5C   
   $
��Tela��6   $��1��6!   $��6��6.   �� 5D   
   $��Center=�6   $��30��6-   $��2��6S   $��6��6`   ��69   �� *
Bug.Tela+6`   �� 5E   
   $��	Atualizar��6   $��Center=�6%   $��2��6@   $��7��6M   $��60��6{   $��20��6�   ��6]   �� *	Atualizar+6�   �� 5F   
   $��2��6   $��2��6!   $	��140��66   $��30��6B   $��3��6N   $��Limpar Prioridade��6[   ��6w   �� *LimparPrioridade+�� 5G   
   $��4��6   $��2��6!   $	��140��66   $��30��6B   $��3��6N   $��Limpar Tudo��6[   ��6q   �� *LimparCampos+5H      5I      