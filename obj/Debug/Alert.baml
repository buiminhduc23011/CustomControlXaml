   M S B A M L   `   `   `  ����L  HCustomControlXaml, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CustomControlXamlCustomControlXaml  5   	       CustomControlXaml.Alert   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CustomControlXaml     5   	     � WindowStyle$
  None=�5   	    � AllowsTransparency .  � 
ResizeMode$ NoResize=�5
   	    � Title$ Alert��5   	   $��80��6   $	��400��6#   
����  �.��5      � .+�5   
   � $��45��6   $��44��6   $��15,0,0,0q�6'   $��Center=�69   $
��Left=�6T   $��2��6o   .+�5      �� -   5         ��Name$ Custom_AlertICon��5      $K��Epack://application:,,,/CustomControlXaml;component/Images/success.png��6/   $
��Fill=�6~   $��Center=�6�   $��Center=�6�   6�   5      �� 5   
   -   5         ��Name$ lblMsg��5   (   $��Alert_Message��6   $��Center=�68   $��	72,0,10,0q�5      $��20(�6#   
�������$��Normal$�5      $��Source Sans Pro)�5      � 5   
   $��Center=�6   $
��Left=�6*   $��	340,0,0,0q�6E   .+�5      �� -   5         ��Name$ Cancel��5      
������ $��60��6T   $��35��6_   .��5      �� $J��Dpack://application:,,,/CustomControlXaml;component/Images/Cancel.png��6   $
��Fill=�6f   $��Center=�6u   ��5      �� 5       �� Color$ Transparent��6&   5      5      5      5      