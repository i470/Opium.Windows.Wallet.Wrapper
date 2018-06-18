using Opium.MVVM.Framework.Model;

namespace Opium.Wallet.Model
{
    public class DaemonInfo: BaseNotify
    {

        private double _residentSizeMb;
        public double ResidentSizeMb
        {
            get => _virtualSizeMb;
            set
            {
                _virtualSizeMb = value;
                RaisePropertyChanged(() => ResidentSizeMb);
            }
        }

        private double _virtualSizeMb;
        public double VirtualSizeMb
        {
            get => _virtualSizeMb;
            set
            {
                _virtualSizeMb = value;
                RaisePropertyChanged(() => VirtualSizeMb);
            }
        }

        private double _cpuPercentage;
        public double CpuPercentage
        {
            get => _cpuPercentage;
            set
            {
                _cpuPercentage = value;
                RaisePropertyChanged(() => CpuPercentage);
            }
        }

        private DaemonStatus _status;
        public DaemonStatus Status
        {
            get => _status;
            set
            {
                _status = value;
                RaisePropertyChanged(() => Status);
            }
        }
    }

    public enum DaemonStatus
    {
        RUNNING,
        NOT_RUNNING,
        UNABLE_TO_ASCERTAIN
    }


}
