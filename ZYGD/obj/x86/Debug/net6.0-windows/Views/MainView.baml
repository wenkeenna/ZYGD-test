   M S B A M L   `   `   `  ?????  ;ZYGD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ZYGD.ExtensionsZYGD.Extensions  5   	   clr-namespace:ZYGDZYGD  5	   	   1clr-namespace:ZYGD.ViewModelsZYGD.ViewModels  5   	       ZYGD.Views.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   [ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	   )extclr-namespace:ZYGD.Extensions   5   	    localclr-namespace:ZYGD   5	   	   _	 [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors 	 5
   	   &vmclr-namespace:ZYGD.ViewModels 	 5   	   -   5          ? Title$  
MainWindow??5   	   $	??700??5   	   $
??1300??5   	   
??????? ? 
ResizeMode$ NoResize=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	    ? WindowStyle$
 None=?5   	    ? 	Resources 5         BtnStyle ?? 
TargetType $  MaterialDesignFlatAccentBgButton ?? BasedOn ?? Property ?? Value	 ?? Triggers
 P? Property P? Value??%?  &	        7  ?? 5   
   " ??6!   8   ?5      ?? 5       ? ??$ 2q?6+   ?? 5       ? ??$ 60??6*   ?? 5       ? ??$ 30??6+   ?? 5       ? ?? ?#FFFFFF6/   ?? 5       ? ??$ 0q?64   ?? 5       ? ??$ 10(?6-   ?? 5       ? ??$ 0q?6,   ?? 5       ? ??$
 Bold"?6/   	 5!      P? 5"      
 ?@J?IsMouseOver$
 True??61   . ?5#      ??  ? ?? ?#F0F0F063   ?? 5$       ? ?? ?#F0F0F064   5%      P? 5&      
 ?@J?IsMouseCaptured$
 True??65   . ?5'      ??  ? ?? ?#D3D3D363   ?? 5(       ? ?? ?#D3D3D364   5)      5+      5-      .??5.      ? ???#FFFFFF.+?5/   
   ]? .+?50      ? -   5         ?Name$ TitleBorder??50   )   $	??Top=?6    ? ColumnDefinitions 51      ?? 52      ?? 53      ?? 54      .+?57      ]? $??0??6$   $
??Left=?64   .+?58      ?? -   5         ??Name$ HomeView??58   %   #??[  67   $??	主   页??6Y   $??HomeView??6?   ??6i   ?? *NavigateCommand+6?   ?? 59      -   5        $ 
ManualView??59   %   #??[  69   $??手  动??6[   $??
ManualView??6?   ??6j   ?? *NavigateCommand+6?   ?? 5:      -   5        $ 
CameraView??5:   %   #??[  69   $??相机参数??6[   $??
CameraView??6?   ??6j   ?? *NavigateCommand+6?   ?? 5;      -   5        $ ContralCardView??5;   %   #??[  6>   $??控制卡参数??6`   $??ContralCardView??6?   ??6p   ?? *NavigateCommand+6?   ?? 5<      -   5        $ InspectView??5<   %   #??[  6:   $??检测参数??6\   $??InspectView??6?    ? Cursor$
 Hand??6?   ??6k   ?? *NavigateCommand+6?   ?? 5=      $y?Hidden=?6$   5>      ?? 5?      $??1??6   ]? 5@      $??2??6   $??Right=?6,   .+?5A      ?? -   5        $ BtnMin??5A   %   #??[  66   $
 Hand??6X   .??5B   "   ]? .+?5C   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Minimize=?62   $??0q?6B   $??0q?6M   $??30??6Y   $??30??6d   $??Center=?6p   $	??Top=?6?   
???   ?6?   5D   #   5E      ?? 5F      -	   5        $ BtnMax??5F   %   #??[  66   $
 Hand??6X   .??5G   "   ]? .+?5H   &     $ Maximize=?62   $??0q?6B   $??0q?6M   $??20??6Y   $??30??6d   $??Center=?6p   $	??Top=?6?   
???   ?6?   5I   #   5J      ?? 5K      -
   5        $ BtnClose??5K   %   #??[  68   .??5L   "   ]? .+?5M   &     $ Close=?62   $??0q?6?   $??0q?6J   $??25??6V   $??30??6a   $??Center=?6m   $	??Top=?6?   
???   ?6?   5N   #   5O      5P      5S      ? 5U      $??Bottom=?6    5V      ?? 5W      $
??235* ?6+   ?? 5X      $
??535* ?6+   ?? 5Y      $	??68* ?6+   ?? 5Z      $
??362* ?6+   .+?5\      ?? "   ZYGD.Extensions.PrismManager   MainViewRegionName!  Prism.Regions.RegionManager   
RegionName# Z 6&   $??4??6v   5]      5_      5`      5a      