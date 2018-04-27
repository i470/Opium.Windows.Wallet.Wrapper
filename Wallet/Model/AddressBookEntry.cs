using Opium.MVVM.Framework.Model;

namespace Opium.Wallet.Model
{
    public class AddressBookEntry:BaseNotify
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged(() => Address);
            }
        }

        private string _address;
        public string Address
        {
            get => _address;
            set
            {
                _address = value;
                RaisePropertyChanged(() => Address);
            }
           
            
        }

        public AddressBookEntry(string name, string address)
        {
            Name = name;
            Address = address;
        }

        
    }
}
