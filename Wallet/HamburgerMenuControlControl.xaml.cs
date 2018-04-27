using System.Windows.Controls;
using MahApps.Metro.Controls;

namespace Opium.Wallet
{
    /// <summary>
    /// Interaction logic for HamburgerMenuControlControl.xaml
    /// </summary>
    public partial class HamburgerMenuControlControl : UserControl
    {
        public HamburgerMenuControlControl()
        {
            InitializeComponent();
        }
        private void HamburgerMenuControl_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
        {
            HamburgerMenuControl.Content = e.InvokedItem;
        }
    }
}
