using System;
using System.Diagnostics;
using System.Windows;
using MahApps.Metro;

namespace Opium.Wallet
{
    
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                ThemeManager.AddAccent("BitcoinPrivateAccent", 
                    new Uri("pack://application:,,,/Opium.Wallet;component/Resources/Theme/BitcoinPrivateTheme.xaml"));

                // get the current app style (theme and accent) from the application
                Tuple<AppTheme, Accent> theme = ThemeManager.DetectAppStyle(Application.Current);

                // now change app style to the custom accent and current theme
                ThemeManager.ChangeAppStyle(Application.Current,
                    ThemeManager.GetAccent("BitcoinPrivateAccent"),
                    theme.Item1);

                var bootStrapper = new OpiumBootStrapper();
                bootStrapper.Run(true);
                base.OnStartup(e);
              
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }
    }
}
