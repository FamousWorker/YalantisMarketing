   M S B A M L   `   `   `  ���� L  HYalantisMarketing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:YalantisMarketingYalantisMarketing  G(clr-namespace:YalantisMarketing.ControlsYalantisMarketing.Controls  "    YalantisMarketing.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:YalantisMarketing     =controls(clr-namespace:YalantisMarketing.Controls       � Title$  Yalantis Marketing��$��343.632��$��336.795�� � WindowStartupLocation$ CenterScreen=�.��� -    �Name$ 	Main_Grid�� � RowDefinitions �� $��* ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -   $��5q�$��0��.@��� $��Outreach��.��0   *YalantisMarketing.Controls.OutreachControl  -     Name$ Outreach_tab_control���� $��	Data Sync��.��0   *YalantisMarketing.Controls.DataSyncControl  -     Name$ DataSync_tab_control���� $��
RankParser��.��2   ,YalantisMarketing.Controls.RankParserControl  -     Name$ RankParser_tab_control���� $��Whois��.��-   'YalantisMarketing.Controls.WhoisControl  -     Name$ Whois_tab_control���� $	��Lan��.��+   %YalantisMarketing.Controls.LanControl  -     Name$ Lan_tab_control���� -   	 ��Name$	 Outreach_panel��
 �� Orientation$
 
Horizontal=�$��1��$��Right=�.+��� -	    ��Name$ Check_button��$��Check��$��60��$��23��$��5q�$��Right=��� -
   $	 Data_sync_panel��$
 
Horizontal=�$��2��$��Right=�.+��� -   $ Sync_button��$
��Sync��$��60��$��23��$��5q�$��Right=��� -   $	 Rank_parser_panel��$
 
Horizontal=�$��3��$��Right=�.+��� -   $ Rank_Start_button��$��Start��$��60��$��23��$��5q�$��Right=��� -   $ Rank_Pause_button��$y�	Collapsed=�$��Pause��$��60��$��23��$��5q�$��Right=��� -   $ Rank_Continue_button��$y�	Collapsed=�$��Continue��$��60��$��23��$��5q�$��Right=��� -   $ Rank_Cancel_button��{�.  $��Cancel��$��60��$��23��$��5q�$��Right=��� -   $	 Whois_panel��$
 
Horizontal=�$��4��$��Right=�.+��� -   $ Whois_Start_button��$��Start��$��60��$��23��$��5q�$��Right=��� -   $ Whois_Pause_button��$y�	Collapsed=�$��Pause��$��60��$��23��$��5q�$��Right=��� -   $ Whois_Continue_button��$y�	Collapsed=�$��Continue��$��60��$��23��$��5q�$��Right=��� -   $ Whois_Cancel_button��{�.  $��Cancel��$��60��$��23��$��5q�$��Right=�� -   $ 	Lan_panel��$��5�� � ColumnDefinitions �� $��* ��� $
��Auto ��� $
��Auto �.+��� -   $ Delete_button��$��Delete��$��60��$��23��$��5q�$��0��$
��Left=��� -   $ Save_button��$
��Save��$��60��$��23��$��5q�$��1��$��Right=�