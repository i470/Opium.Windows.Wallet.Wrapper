using System;
using System.Collections.ObjectModel;
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
        public IActionCommand CopyAddressToClibaordCommand;
        public IActionCommand AddNewContactCommand;
        public IActionCommand SendContactMessageCommand;
        public IActionCommand PlaceBetWithaContactCommand;

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
            CopyAddressToClibaordCommand = new ActionCommand<AddressBookEntry>(copyAddress);
            AddNewContactCommand=new ActionCommand<AddressBookEntry>(addNewContact);


        }

#region Methods

        private void addNewContact(AddressBookEntry address)
        {
            throw new NotImplementedException();
            saveAddressBook();
        }

        public void LoadAddressBook()
        {
            //todo add service to load address
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
        private void saveAddressBook()
        {
            throw new NotImplementedException();
        }

#endregion

    }

    
}
