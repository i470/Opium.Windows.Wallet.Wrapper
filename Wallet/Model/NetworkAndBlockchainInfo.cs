using System;
using Opium.MVVM.Framework.Model;

namespace Opium.Wallet.Model
{
    public class NetworkAndBlockchainInfo: BaseNotify
    {
        private int _numConnections;
        public int NumConnections
        {
            get => _numConnections;
            set
            {
                _numConnections = value;
                RaisePropertyChanged(() => NumConnections);
            }
        }

        private DateTime _lastBlockDate;
        public DateTime LastBlockDate
        {
            get => _lastBlockDate;
            set
            {
                _lastBlockDate = value;
                RaisePropertyChanged(() => LastBlockDate);
            }
        }

        private string _lastBlockHeight;
        public string LastBlockHeight
        {
            get => _lastBlockHeight;
            set
            {
                _lastBlockHeight = value;
                RaisePropertyChanged(() => LastBlockHeight);
            }
        }
    }
}
