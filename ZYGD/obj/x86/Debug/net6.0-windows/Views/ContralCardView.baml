   M S B A M L   `   `   `  ?????  ;ZYGD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ZYGD.ViewModelsZYGD.ViewModels  5      'clr-namespace:ZYGD.Views
ZYGD.Views  5	           ZYGD.Views.ContralCardView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      &vmclr-namespace:ZYGD.ViewModels  5      [ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      &localclr-namespace:ZYGD.Views   5	        ? 	Resources  5         BtnStyle ?? 
TargetType $  MaterialDesignFlatAccentBgButton ?? BasedOn ?? Property ?? Value ?? Triggers P? Property P? Value??%.  &	        7  ?? 5   
   " ??6!   8   ?5      ?? 5       ? ??$ 2q?6+   ?? 5       ? ??$ 30??6-   ?? 5       ? ??$ 10??6.   ?? 5       ? ?? ?#E6E6E66/   ?? 5       ? ??$ 0q?64    5      P? 5       ?@J?IsMouseOver$
 True??61   . ?5      ??  ? ?? ?#96969663   ?? 5       ? ?? ?#96969664   5      P? 5       ?@J?IsMouseCaptured$
 True??65   . ?5      ??  ? ?? ?#70707063   ?? 5       ? ?? ?#70707064   5      5       5!      .??5"      ?  ? RowDefinitions 5#   
   ?? 5$      $??1* ?6   ?? 5%      $??9* ?6   .+?5'   
   ? $??0??6   .+?5(      ?? 	 ?? Orientation$	 
Horizontal=?6   $??Center=?62   .+?5)      ?? $??保存参数??6   $	??100??6)   #??[  65   $??10 0 0 0q?6w   
 ? Cursor$

 Hand??6?   ??6W   ?? *
btnCommand+6?   5*      5+      ? 5,   
   $??1??6   .+?5-      ?? ??6   ?? *	AxisParas+??5.      ?? 5/      .R?50      ? 51      ??53      ?? 55      .R?56      #  MaterialDesignThemes.Wpf.Card  +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=?6#   $	??100??6H   $	??100??6X   $??5q?6g   .??57      ?? $??5q?6)   .+?58   "   ]? .+?59   &   ?? $??轴名称：??60   
???   ?6=   ?? 5:   &   
???   ???60   ?? *Name+ ?? Mode$ TwoWay=?6S   5;   #   ]? 5<   "   .+?5=   &   ?? $??轴ID：??60   
???   ?6=   ?? 5>   &   
???   ?$??0q?6b   ??6.   ?? *ID+$ TwoWay=?6b   5?   #   ]? 5@   "   .+?5A   &   ?? $??	速度：??60   
???   ?6<   ?? 5B   &   
???   ?$??0q?6e   ??6.   ?? *Speed+$ TwoWay=?6e   5C   #   ]? 5D   "   .+?5E   &   ?? $??加速度：??60   
???   ?6=   ?? 5F   &   
???   ?$??0q?6c   ??6.   ?? *Acc+$ TwoWay=?6c   5G   #   ]? 5H   "   .+?5I   &   ?? $??减速度：??60   
???   ?6=   ?? 5J   &   
???   ?$??0q?6c   ??6.   ?? *Dec+$ TwoWay=?6c   5K   #   5L      5M      5N      5Q      5R      5S      5T      