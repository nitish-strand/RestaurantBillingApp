   M S B A M L   `   `   `  ����K  GRestaurantModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:RestaurantModule.ViewsRestaurantModule.Views  5      )    #RestaurantModule.Views.CustomerInfo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:RestaurantModule.Views     5      P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� ��6   �� *
MyProperty+�� 5   
   .+�5      �� $��0��6   $*��$Please enter the following details:-��6!   $��5q�6P   $��15(�6[   $
��Bold"�6i   $��Center=�6{   �� 5       �� Orientation$ 
Horizontal=�6   $
��Left=�62   $��10q�6M   $��1��6Y   .+�5      �� $��	FirstName��6   $
��Bold"�6,   $��5q�6>   �� 5      $��5q�6=   $	��380��6H   ��6   �� *CustomerFirstName+6H   5      �� 5       $ 
Horizontal=�6   $
��Left=�62   $��10q�6M   $��2��6Y   .+�5!      �� $��LastName��6   $
��Bold"�6+   $��5q�6=   �� 5"      $��5q�6<   $	��380��6G   ��6   �� *CustomerLastName+6G   5#      �� 5%      $ 
Horizontal=�6   $
��Left=�62   $��10q�6M   $��3��6Y   .+�5&      �� $��Location��6   $
��Bold"�6+   $��5q�6=   �� 5'      $��5q�6<   $	��380��6G   ��6   �� *CustomerLocation+6G   5(      �� 5*      $ 
Horizontal=�6   $
��Left=�62   $��10q�6M   $��4��6Y   .+�5+      �� $"��Number of people accompanied��6   $
��Bold"�6?   $��5q�6Q   �� 5,      $��5q�6>   $	��180��6I   ��6   �� *CustomerWithNumber+6I   5-      �� 50      $ Vertical=�6   $��5q�60   .+�51      �� $��5��6   $��Submit��6&   $��Right=�6V   $��5q�6r   $��10q�6~   ��67   �� *
SubmitInfo+6~   �� 53      $ 
Horizontal=�6   $��5q�66   y�6A   �� *CheckVisibility+.+�54      �� $��6��6   
���  ��$
��Left=�6V   $��5q�6q   ��6)   �� *	Message+6q   �� 55      $��6��6   $��Order��6*   $��Right=�6X   $��5q�6t   $��5q�6�   ��6:   �� *	TakeOrder+6�   56      57      59      5;      5<      