   M S B A M L   `   `   `  ����D  @TDSClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:TDSClient.PropertiesTDSClient.Properties  5   	   -    'TDSClient.Forms.frmRouteActivityRouting   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8	globalres"clr-namespace:TDSClient.Properties     5   	   X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44tool)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$  frmRouteActivityRouting��5   	   $	��510��6)   $	��416��66   $��11(�6B   $��Global User Interface)�6P    � 
ResizeMode$ NoResize=�6�    � ShowInTaskbar .  .��5      � .+�5	   
   �� $   TDSClient.Properties.Resources   strSourcePoint#��Z 6   $��26��6H   $
��Left=�6T   $	��Top=�6o   $	��145��6�   $��0,52,0,0q�6�   �� 5
   
      strTargetPoint#��Z 6   $��26��6H   $
��Left=�6T   $��0,90,0,0q�6o   $	��Top=�6�   $��77��6�   �� 5   
   $��X:��6   $��26��6   $
��Left=�6)   $��
159,72,0,0q�6D   $	��Top=�6X   $��21��6p   �� 5   
   $��Y:��6   $��26��6   $
��Left=�6)   $��
302,72,0,0q�6D   $	��Top=�6X   $��21��6p   �� 5   
   $��X:��6   $��26��6   $
��Left=�6)   $��159,106,0,0q�6D   $	��Top=�6Y   $��21��6q   �� 5   
   $��Y:��6   $��26��6   $
��Left=�6)   $��302,106,0,0q�6D   $	��Top=�6Y   $��21��6q   �� 5   
   -   5        $��
txtSourceX��5   -   $
��Left=�6   $��22��6?   $��
182,72,0,0q�6K    �� 
IsReadOnly .  �� TextWrapping$
 Wrap=�6q   $�� ��6�   $	��Top=�6�   $��67��6�   �� 5   
   -   5        $��
txtSourceY��5   -   $
��Left=�6   $��22��6?   $��
325,72,0,0q�6K    . $
 Wrap=�6q   $�� ��6�   $	��Top=�6�   $��67��6�   �� 5   
   -   5        $��
txtTargetX��5   -   $
��Left=�6   $��22��6?   $��182,106,0,0q�6K    . $
 Wrap=�6r   $�� ��6�   $	��Top=�6�   $��67��6�   �� 5   
   -   5        $��
txtTargetY��5   -   $
��Left=�6   $��22��6?   $��325,106,0,0q�6K    . $
 Wrap=�6r   $�� ��6�   $	��Top=�6�   $��67��6�   �� 5   
   -   5         ��Name$ cmdClearAutoRoute��5   �   #��Z 6   $��20��6J   $
��Left=�6V   $��178,382,0,4q�6q   $	��Top=�6�   $��46��6�   $y�Hidden=�6�   �� 5   
   -   5        $ cmdRoute��5   s      strRoute#��Z 6   $
��Left=�6C   $��231,446,0,0q�6^   $��46��6�   $��20��6�   $	��Top=�6�   �� 5   
   -   5        	 ��Name$	 checkBoxMapSource��5   j   
   strMarkOnTheMap#��Z
 6   $��17��6L   $��6,74,0,0q�6X   $	��Top=�6�   $
��Left=�6�   $	��128��6�   6�   �� 5   
   -	   5        $	 checkBoxMapTarget��5   k   #��Z
 6   $��17��6L   $��	6,108,0,0q�6X   $	��Top=�6�   $
��Left=�6�   $	��128��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ dtGridRoute��5      $��	2,154,0,0q�6(   
������    RowBackground
 ���� $	��106��6q   $	��Top=�6~   $
��Left=�6�   $	��314��6�   6�   �� 5   
   -   5        $ cmdNew��5   2   $��20��6   $��328,160,0,0q�6   $	��Top=�6B   $
��Left=�6Z   $��66��5   
      	strbtnNew#��Z 6*   �� 5   
   -   5        $ 	cmdDelete��5   '   $��328,208,0,0q�6   $
��Left=�6:   $��66��6U      strbtnDelete#��Z 5   
   $��20��6X   $	��Top=�6d   �� 5   
      strIntermediatepoints#��Z 6   $
��Left=�6O   $��26��6j   $��	0,129,0,0q�6v   $	��Top=�6�   $	��293��6�   �� 5   
   -   5        $��chkCarMostImportant��5   M      strHighLevelRoad#��Z 6   $
��Left=�6h   $��17��6�   $��
10,279,0,0q�6�   $	��Top=�6�   $	��239��6�   �� 5    
   -   5        $	 chkCarMediumImportant��5    O      strMediumLevelRoad#��Z 6   $
��Left=�6n   $��17��6�   $��
10,297,0,0q�6�   $	��Top=�6�   $	��239��6�   �� 5!   
   -   5        $	 chkCarLowImportant��5!   O      strLowLevelRoad#��Z 6   $
��Left=�6n   $��17��6�   $��
10,316,0,0q�6�   $	��Top=�6�   $	��267��6�   �� 5"   
   -   5        $	 chkConstruction��5"   Q      strUnderConstruction#��Z 6   $
��Left=�6j   $��17��6�   $��
10,335,0,0q�6�   $	��Top=�6�   $	��267��6�   �� 5$   
   -   5         ��Name$ textBlockRouteName��5%   
   $
��Wrap=�5$      $��16��6)   $
��Left=�65   $��3,8,0,0q�6P   $	��Top=�5%   &   $��79��6>      strRouteName#��Z 6J   �� 5&   
   -   5         ��Name$ txtRouteName��5&   0   $��20��6   $��87,6,0,0q�6   $	��Top=�6F   $
��Left=�6^   $	��236��6y   �� 5(   
   -   5        $ textBlockRouteName_Copy��5)   
   $
��Wrap=�5(      $��16��6)   $
��Left=�65   $��3,29,0,0q�6P   $	��Top=�5)   +   $��79��6C      strPlatformName#��Z 6O   �� 5+   
   -   5        $ txPlatformName��5+   1   $��20��6   $��	87,30,0,0q�6   $	��Top=�6I   $
��Left=�6a   $	��236��6|   �� 5-   
   -   5        $ cmdExit��5-   &   $��294,446,0,0q�6      strSaveAndExit#��Z 6M   $��20��5.   
   $	��Top=�6   $
��Left=�6.   $��93��6I   �� 5/   
      strRoadsFilter#��Z 6   $
��Left=�6H   $��26��6c   $��	0,259,0,0q�6o   $	��Top=�6�   $	��293��6�   �� 50   
   -   5        $ 	cmdInsert��50   2   $��20��6   $��328,184,0,0q�6   $	��Top=�6E   $
��Left=�6]   $��66��51   
      strbtnInsert#��Z 6   6L   &   Xceed.Wpf.Toolkit.TimeSpanUpDown  52   
   -   5        $��startActivity��52   3   $��
96,358,0,0q�6   #   FractionalSecondsDigitsCount$ 0��6H   $��75��6j   $��24��6u   $	��Top=�6�   $
��Left=�6�     53   
   -   5          Name$ durationActivity��53   4   $��269,359,0,0q�6   $ 0��6N   $��75��6o   $��24��6z   $	��Top=�6�   $
��Left=�6�   �� 54   
      strStartActivity#��Z 6   $
��Left=�6J   $��
10,359,0,0q�6e   $	��Top=�6y   $	��107��6�   �� 55   
      strDuration#��Z 6   $
��Left=�6E   $��203,360,0,0q�6`   $	��Top=�6u   $��63��6�   �� 56   
   $��+��6   $
��Left=�6   $��
79,359,0,0q�67   $	��Top=�6K   $��17��6c   %  Xceed.Wpf.Toolkit.IntegerUpDown  57   
   -   5        $��speedUpDown��57   w   $��
96,387,0,0q�6   �  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   	Increment$ 1X�61   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]    Minimum$  0X�6?   !   Maximum$	! 200X�6L   "   FormatString$" N��6Z   $��24��6k   $
��Left=�6�   $��75��6�   $	��Top=�6�   �� 58   
   #   strGridHeaderSpeedKmh#��Z# 6   $
��Left=�6O   $��
10,386,0,0q�6j   $	��Top=�6~   $��81��6�   5;      5<      