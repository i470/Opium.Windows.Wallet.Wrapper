using System;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using Opium.MVVM.Framework.Command;
using Opium.MVVM.Framework.ViewModel;
using Wallet.Model;

namespace Opium.Wallet.ViewModel
{
    [ExportAsViewModel("AddressBookViewModel")]
    public class AddressBookViewModel: BaseEntityViewModel
    {
        public IActionCommand SendCashCommand;
        public IActionCommand DeleteContactCommand;
        public IActionCommand CopyAddressToClibardCommand;
        public IActionCommand AddNewContactCommand; 

#region Properties

        private ObservableCollection<AddressBookEntry> _addressBookEntries;
        public ObservableCollection<AddressBookEntry> AddressBookEntries
        {
            get => _addressBookEntries;
            set
            {
                _addressBookEntries = value;
                RaiseErrorsChanged(()=>AddressBookEntries);
            }
        }

#endregion

        public AddressBookViewModel()
        {
            LoadAddressBook();
            SendCashCommand=new ActionCommand<AddressBookEntry>(sendCash);
            DeleteContactCommand = new ActionCommand<AddressBookEntry>(deleteContact);
            CopyAddressToClibardCommand = new ActionCommand<AddressBookEntry>(copyAddress);
            AddNewContactCommand=new ActionCommand<AddressBookEntry>(addNewContact);

        }

        private void addNewContact(AddressBookEntry address)
        {
            throw new NotImplementedException();
        }

        private void copyAddress(AddressBookEntry address)
        {
            throw new NotImplementedException();
        }
        
        private void deleteContact(AddressBookEntry address)
        {
            throw new NotImplementedException();
        }

        private void sendCash(AddressBookEntry address)
        {
            throw new NotImplementedException();
        }

        public void LoadAddressBook()
        {
            //todo add service to load address
        }
    }

    
}
