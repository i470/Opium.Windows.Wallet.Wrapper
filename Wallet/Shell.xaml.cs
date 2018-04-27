using System.ComponentModel.Composition;
using MahApps.Metro.Controls;

namespace Opium.Wallet
{

    [Export]
    public partial class Shell : MetroWindow
    {
        public Shell()
        {
            InitializeComponent();
        }

        [Import]
        public ShellViewModel ViewModel
        {
            set => DataContext = value;

     
        }
    }
}
