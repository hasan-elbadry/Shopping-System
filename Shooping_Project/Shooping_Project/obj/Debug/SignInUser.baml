   M S B A M L   `   `   `  ����K  GShooping_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Shooping_ProjectShooping_Project  5      !    Shooping_Project.SignInUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Shooping_Project     5        N� Title$  
SignInUser��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $
��159* �6   �� 5      $
��641* �6    � RowDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��81* �6   �� 5      $
��320* �6   .+�5   
   �� $��
Login User��6   $��25(�5      $
��Left=�5      $	��Top=�5      $
��Bold"�5       �� Padding$ 10q�5      $��2��6   $��1��6#   $��	156,0,0,0q�63   G� 5   
   -   5         G�Name$ Password��5      $��2��6(   $	��0,5q�5      $��0,0,0,1q�5      $��113,38,272,0q�6   $	��Top=�61   $��1��6I   �� 5   
   -   5         ��Name$ UserName��5   ,   $��0,0,0,1q�6   $��113,37,272,0q�6>   $��1��6T   $��1��6a      TextBoxStyle#��[  6q   �� 5    
   -   5         ��Name$ BtnLogin��5       $��Login��6#   $��153,0,312,101q�63   $��2��6J   
���   �
�������$��22(�6}   $��54��6�   $��Bottom=�6�   $��1��6�    � 	Resources 5!       �� 
TargetType	 �� Property
 �� Value��%d   '��       �� 5"      " ��6   .�5#      �� 	 �@��CornerRadius$
 10��65   6B   5$      5%      5&      �� 5'   
   $��UerName��6   $
��Left=�6"   $��	113,6,0,0q�6=   $��1��6P   $	��Top=�6]    J� RenderTransformOrigin$ 0.008,0.197&�6u   $��1��6�   �� 5(   
   $��Password��6   $
��Left=�6#   $��	113,9,0,0q�6>   $��2��6Q   $ 0.008,0.197&�6^   $��1��6�   $��26��6�   $	��Top=�6�   �� 5)   
   -   5        $ ForgetPassowrd��5)      $��Forget Passowrd��6)   $��113,70,398,0q�6C   $��2��6Y   $��21��6f   
���   �$	��Top=�6�   $��11(�6�   
������ $��1��6�   ��6�   Z� 6�   �� 5*   
   -   5        $ 	SignUpBtn��5*      $��SignUp��6$   $��153,0,312,37q�65   $��2��6K   
���   �
�������$��22(�6~   $��54��6�   $��Bottom=�6�   $��1��6�    5+      ��%_   '��       �� 5,      " ��6   .�5-      �� 	 �@��CornerRadius$
 10��65   5.      5/      50      51      52      