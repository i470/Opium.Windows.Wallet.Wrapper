using System.ComponentModel.Composition.Hosting;
using System.Windows;
using Prism.Mef;

namespace Opium.Wallet
{
    public class OpiumBootStrapper : MefBootstrapper
    {
       
        protected override DependencyObject CreateShell()
        {
           return Container.GetExportedValue<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Shell)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();

            
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(OpiumBootStrapper).Assembly));
            //var catalog = new DirectoryCatalog("Plugins");
            //AggregateCatalog.Catalogs.Add(catalog);
        }

      

    }
    
}

  
