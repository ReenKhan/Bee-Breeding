   M S B A M L   `   `   `  ����F  BBeeBreeding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BeeBreedingBeeBreeding  5   	       BeeBreeding.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BeeBreeding     5   	     � Title$  BeeBreeding��5   	   $	��750��6   $
��1050��6*   .��5	      � 
������� � ColumnDefinitions 5   
   �� 5      $
��1.5* �6   6.   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��1.5* �6   6,   �� 5      $
��0.5* �6   6,   �� 5      $
��0.5* �6   6,   .+�5   
   �� $��0��6   $��0��6    .��5      �� $��picture.png��6   $
��Fill=�6)   6:   5      �� 5   
   $��0��6   $��1��6    $G��AEnter input below in format:[eg:19 30]/Termination Point is [0 0]��6-   $��DemiBold"�6y   $��1q�5   	   
���   �$��10q�61   $��20(�6=   $��Center=�6K   $��Center=�6m   �� 5   
   -   5        $��InputNumber��5   h   $��0��5      $��2��6"   $��DemiBold"�6/   $��1q�5   	   
���   �$��10q�61   $��30(�6=    � ToolTip$ To terminate enter [0 0]��6{   $��Center=�5   	   $��Center=�6+   ��5   K   �� *InputNumber+5   +   �� 5   
   $��1��6   $��0��6"   $��2��6/   $��10q�6@   $��20(�6L   ��5    
   ��  �� Path$ Output�5!      �� 5#   
   -   5        $��	Calculate��5#   ]   $��1��6   $��2��6!   $��	Calculate��6.   $��10q�6C   $��35(�6O   $��Center=�5$   !   $��Center=�6C   5%      5&      