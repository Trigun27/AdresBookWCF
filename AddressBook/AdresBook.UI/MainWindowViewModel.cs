using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Address.Service.Codes;
using AddressBook.Entites;
using AdresBook.UI.ServiceReference1;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;

namespace AdresBook.UI
{
    class MainWindowViewModel : BindableBase
    {
        private ObservableCollection<Contact> _contacts;
        

        public MainWindowViewModel()
        {
            GetContactsCommand = new DelegateCommand(OnGetContacts);
            FindContactbyPhoneCommand = new DelegateCommand(OnFindContactbyPhone);
            FindContactbyNameCommand = new DelegateCommand(OnFindContactbyName);
            AddContactCommand = new DelegateCommand(OnAddContact);
            DeleteContactCommand = new DelegateCommand(OnDeleteContact);
            ChangePhoneNumberCommand = new DelegateCommand(OnChangePhoneNumber);
        }



        public ObservableCollection<Contact> Contacts 
        { 
            get { return _contacts; }
            set { SetProperty(ref _contacts, value); } 
        }

        private string _firstName;

        public string FirstName
        { 
            get { return _firstName; } 
            set { SetProperty(ref _firstName, value); }
        }

        private string _middleName;

        public string MiddleName
        {
            get { return _middleName; }
            set { SetProperty(ref _middleName, value); }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }

        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public DelegateCommand GetContactsCommand { get; private set; }

        private void OnGetContacts()
        {
            if (!DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                LoadContacts();
            }
        }

        private async void LoadContacts()
        {
            AddressBookServiceClient proxy = new AddressBookServiceClient("BasicHttpBinding_IAddressBookService");

            try
            {

                Contacts = await proxy.GetContactAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
            finally
            {
                proxy.Close();
            }


        }

        public DelegateCommand FindContactbyPhoneCommand { get; private set; }

        private void OnFindContactbyPhone()
        {
            FindContact();
        }

        private async void FindContact()
        {
            AddressBookServiceClient proxy = new AddressBookServiceClient("BasicHttpBinding_IAddressBookService");
            try
            {
                Contacts = await proxy.FindContactbyPhoneAsync(_phoneNumber);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
            finally
            {
                proxy.Close();
            }
        }

        public DelegateCommand FindContactbyNameCommand { get; private set; }

        private void OnFindContactbyName()
        {
            FindContactbyName();
        }

        private async void FindContactbyName()
        {
            AddressBookServiceClient proxy = new AddressBookServiceClient("BasicHttpBinding_IAddressBookService");
            try
            {
                Contacts = await proxy.FindContactbyNameAsync(4, _fullName);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
            finally
            {
                proxy.Close();
            }
        }

        public DelegateCommand AddContactCommand { get; private set; }

        private void OnAddContact()
        {
            AddContact();
        }

        private async void AddContact()
        {
            Contact newContact = new Contact();
            AddressBookServiceClient proxy = new AddressBookServiceClient("BasicHttpBinding_IAddressBookService");
            

            try
            {
                string[] fio = _fullName.Trim().Split(' ');

                var buffContacts = await proxy.GetContactAsync();
                newContact.FullName = _fullName.Trim();
                newContact.LastName = fio[0];
                newContact.FirstName = fio[1];
                newContact.MiddleName = fio[2];
                //newContact.PhoneNumber = _phoneNumber.Insert(0,"(").Insert(4,") ").Insert(9,"-");
                newContact.PhoneNumber = _phoneNumber;
                newContact.Id = buffContacts.Count + 1;

                await proxy.AddContactAsync(newContact);
                Contacts = await proxy.GetContactAsync();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
            finally
            {
                proxy.Close();
            }
        }

        public DelegateCommand DeleteContactCommand { get; private set; }

        private void OnDeleteContact()
        {
            DeleteContact();
        }

        private async void DeleteContact()
        {
            AddressBookServiceClient proxy = new AddressBookServiceClient("BasicHttpBinding_IAddressBookService");
            try
            {
                await proxy.DeleteContactAsync(_id);
                Contacts = await proxy.GetContactAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
            finally
            {
                proxy.Close();
            }
        }

        public DelegateCommand ChangePhoneNumberCommand { get; private set; }

        private void OnChangePhoneNumber()
        {
            ChangePhoneNumber();
        }

        private async void ChangePhoneNumber()
        {
            AddressBookServiceClient proxy = new AddressBookServiceClient("BasicHttpBinding_IAddressBookService");
            try
            {    
                await proxy.ChangePhoneNumberAsync(_id,_phoneNumber.Insert(0,"(").Insert(4,") ").Insert(9,"-"));
                Contacts = await proxy.FindContactbyPhoneAsync(_phoneNumber);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
            finally
            {
                proxy.Close();
            }
        }
    
    
    
    
    }
}
