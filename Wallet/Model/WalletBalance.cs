using Opium.MVVM.Framework.Model;

namespace Opium.Wallet.Model
{
    public class WalletBalance: BaseNotify
    {
        private double _transparentBalance;
        public double TransparentBalance
        {
            get => _transparentBalance;
            set
            {
                _transparentBalance = value;
                RaisePropertyChanged(() => TransparentBalance);
            }
        }

        private double _privateBalance;
        public double PrivateBalance
        {
            get => _privateBalance;
            set
            {
                _privateBalance = value;
                RaisePropertyChanged(() => PrivateBalance);
            }
        }

        private double _totalBalance;
        public double TotalBalance
        {
            get => _totalBalance;
            set
            {
                _totalBalance = value;
                RaisePropertyChanged(() => TotalBalance);
            }
        }

        private double _transparentUnconfirmedBalance;
        public double TransparentUnconfirmedBalance
        {
            get => _transparentUnconfirmedBalance;
            set
            {
                _transparentUnconfirmedBalance = value;
                RaisePropertyChanged(() => TransparentUnconfirmedBalance);
            }
        }

        private double _privateUnconfirmedBalance;
        public double PrivateUnconfirmedBalance
        {
            get => _privateUnconfirmedBalance;
            set
            {
                _privateUnconfirmedBalance = value;
                RaisePropertyChanged(() => PrivateUnconfirmedBalance);
            }
        }

        private double _totalUnconfirmedBalance;
        public double TotalUnconfirmedBalance
        {
            get => _totalUnconfirmedBalance;
            set
            {
                _totalUnconfirmedBalance = value;
                RaisePropertyChanged(() => TotalUnconfirmedBalance);
            }
        }
    }
}
