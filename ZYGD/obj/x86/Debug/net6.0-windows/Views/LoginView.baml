   M S B A M L   `   `   `  ?????  ;ZYGD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ZYGD.Views
ZYGD.Views  5      )clr-namespace:ZYGD.CommonZYGD.Common  5	      1clr-namespace:ZYGD.ViewModelsZYGD.ViewModels  5
          ZYGD.Views.LoginView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      [ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      $localclr-namespace:ZYGD.Views  5      &Commonclr-namespace:ZYGD.Common  5	      &vmclr-namespace:ZYGD.ViewModels  5
      
?????? #  Prism.Services.Dialogs.Dialog    WindowStyle  5      ?? 5   
    ?? 
TargetType" ?6   .?5      ??  ?? Property ?@ WindowStartupLocation ?? Value$ CenterScreen=?6C   ?? 5      '  !System.Windows.Shell.WindowChrome ?@ WindowChrome 5        5         CaptionHeight$ 0Q?6#      ResizeBorderThickness$ 1q?65   5      ?? 5       ?@?WindowStyle$
 None=?6,   ?? 5       ?@J?	AllowDrop$
 True??6*   ?? 5       ? ??$ 0q?60   ?? 5       ?@?ShowInTaskbar$ False??6.   ?? 5       ?@?SizeToContent$ Manual=?6.   ?? 5       ? ??$	 300??6'   ?? 5       ? ??$	 600??6&   ?? 5       ? ??
 ?????6+   ?? 5       ?@?Topmost$
 True??6(   ?? 5        ?@?ShowInTaskbar$ False??6.   5"       ? 	Resources 5&         BtnStyle $  MaterialDesignFlatAccentBgButton ?? BasedOn ?? Triggers	 P? Property
 P? Value??%.  &	        7  ?? 5'   
   " ??6!   8   ?5(      ?? 5)       ? ??$ 2q?6+   ?? 5*       ? ??$ 50??6*   ?? 5+       ? ??$ 40??6+   ?? 5,       ? ?? ?#4B9EE76/   ?? 5-       ? ??$ 0q?64    5/      P? 50      	 ?@J?IsMouseOver$

 True??61   . ?51      ??  ? ?? ?#166DC063   ?? 52       ? ?? ?#166DC064   53      P? 54      	 ?@J?IsMouseCaptured$

 True??65   . ?55      ??  ? ?? ?#8ECDF763   ?? 56       ? ?? ?#8ECDF764   57      59      5:      .??5;      ? .+?5<   
   ?? 
???????._?5=      ?  ? ColumnDefinitions 5>      ?? 5?      $??5* ?6'   ?? 5@      $??5* ?6'   .+?5B      ?? 
???????6   ?? 5D      $??	310,0,0,0q?6   ??5E      ?? 5F       ?? EndPoint$ 0.5,1&?6.    ?? 
StartPoint$ 0.5,0&?6?   .??5G      ?  ? Color$ #1D9BF0??6+    ? Offset$ 1Q?6;   ? 5H      $ #006CBE??6+   ? 5I      $ #8ECDF7??6+   $ 0.566Q?6;   5J      5L      ?? 5M      .+?5N      ?? -   5         ??Name$ 	btn_Close??5Q   j   $??2 2 0 0q?5N      $??30??6/   $??20??6:   $??0q?6G   $
??Left=?5O      
???????$??0q?5Q      #??[  61   ???	#FF31577E??6}   ?? *	btn_Close+.??5R      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=?6'   $??15??64   $??15??6?   $??Center=?6K   $??Center=?6f   5S      ?? 5T      $??0??6!   $??	20,0,0,10q?61   .+?5U      ?? $??Login??6    $??Segoe UI Black)?60   $??24(?6L   $	??0,5q?6Z   $	??Top=?6g   $
??Left=?6   ?? 5X      $
??0,15q?6%    ?? Orientation$ 
Horizontal=?63   .+?5Y        $ Account=?6*   $??Center=?69   ???#7070706T   ?? 5Z      -   5         ??Name$ UserName??5Z   &   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	用户名??6_   $	??250??6x   $??5q?6?   ??68   ?? *
Username+ ?? Mode$ TwoWay=?6?   5[      ?? 5\      $ 
Horizontal=?6%   .+?5]        $	 Key=?6*   $??Center=?65   ???#7070706P   G? 5^      -   5         G?Name$ Password??5^   *   $ 密码??6<   $	??250??6T   $??5q?6`   5c      ? 5d      .+?5e      ?? $??记住用户名??6'   $
??5,10q?67   ???#7070706E   ?? 5f      $??忘记密码??6$   $??Right=?63   $??Center=?6O   $??10q?6j   ???#7070706v   5g      ?? 5h      $??Center=?6!   $??登录??6>   $??Impact)?6K   $??18(?6_   $	??100??6m   #??[  6{    ? Cursor$
 Hand??6?   ??6?   ?? *	btn_Login+6?   ?? 5i      $
??Left=?6;   $??Bottom=?6V   $??2 15 0 0q?6q   ???#FF6666$??15(?6?   ??6    ?? *Remind+6?   5j      5k      ?? 5l      $??1??6   ???#8ECDF7._?5n      ?? $??0,0,0,50q?6"   .+?5p      ?? $??琢越光电??6$   $??	0 100 0 0q?61   
???????$??Center=?6W   $??48(?6t   $??Champagne & Limousines)?6?   $
??Bold"?6?   ?? 5q      $??湖北省.武汉市??6$   
???????$
??Left=?6F   $	??280??6a   $??12(?6m   $??Champagne & Limousines)?6{   $
??Wrap=?6?    ?? TextAlignment$ Center=?6?   5s      5t      5v      5w      5x      5y      