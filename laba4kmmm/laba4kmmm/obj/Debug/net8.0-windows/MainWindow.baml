   M S B A M L   `   `   `  ����D  @laba4kmmm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:laba4kmmm	laba4kmmm  5   	       laba4kmmm.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   R NOxyPlot.Wpf, Version=2.1.2.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0Y UOxyPlot.Wpf.Shared, Version=2.1.2.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0"oxyhttp://oxyplot.org/wpf   5   	   %localclr-namespace:laba4kmmm   5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5      � .+�5   
   �� -   5         ��Name$ metod1��5      $!��Метод трапеции��6!   $	��100��6:   $��30��6F   $��10,394,690,10q�6R   6�   �� 5   
   -   5         ��Name$ chag1��5      $��60��6!   $��20��6,   $��12,316,728,98q�68   6R   �� 5   
   -   5        $ chag2��5      $��60��6!   $��20��6,   $��115,316,625,98q�68   6S   �� 5   
   -   5        $ chag3��5      $��60��6!   $��20��6,   $��12,369,728,45q�68   6R   �� 5   
   -   5        $ metod2��5      $��Метод Симсона��6!   $��128,394,578,10q�69   6Q     OxyPlot.Wpf.PlotView  5   
   -   5          Name$ plotView��5      $��12,35,10,155q�6)   �� 5   
   $
��Left=�6   $��
12,284,0,0q�6,   $	��Top=�6@   $@��:Введите границы интегрирования��6X   �� 5   
   $8��2Введите шаг интегрирования��6   $
��Left=�65   $��
12,341,0,0q�6P   $	��Top=�6d   �� 5   
   -   5        $ result1��5      $
��Left=�6#   $��245,406,0,0q�6>    �� TextWrapping$
 Wrap=�6S   $��TextBox��6g   $	��Top=�6v   $	��120��6�   �� 5   
   $��Результат��6   $
��Left=�6$   $��245,383,0,0q�6?   $	��Top=�6T   5      5      