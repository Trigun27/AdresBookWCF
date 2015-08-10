﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdresBook.UI.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAddressBookService")]
    public interface IAddressBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBookService/GetContact", ReplyAction="http://tempuri.org/IAddressBookService/GetContactResponse")]
        System.Collections.ObjectModel.ObservableCollection<AddressBook.Entites.Contact> GetContact();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBookService/GetContact", ReplyAction="http://tempuri.org/IAddressBookService/GetContactResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<AddressBook.Entites.Contact>> GetContactAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBookService/FindContactbyPhone", ReplyAction="http://tempuri.org/IAddressBookService/FindContactbyPhoneResponse")]
        System.Collections.ObjectModel.ObservableCollection<AddressBook.Entites.Contact> FindContactbyPhone(string phoneNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBookService/FindContactbyPhone", ReplyAction="http://tempuri.org/IAddressBookService/FindContactbyPhoneResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<AddressBook.Entites.Contact>> FindContactbyPhoneAsync(string phoneNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBookService/FindContactbyName", ReplyAction="http://tempuri.org/IAddressBookService/FindContactbyNameResponse")]
        System.Collections.ObjectModel.ObservableCollection<AddressBook.Entites.Contact> FindContactbyName(int varOperation, string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBookService/FindContactbyName", ReplyAction="http://tempuri.org/IAddressBookService/FindContactbyNameResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<AddressBook.Entites.Contact>> FindContactbyNameAsync(int varOperation, string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBookService/AddContact", ReplyAction="http://tempuri.org/IAddressBookService/AddContactResponse")]
        void AddContact(AddressBook.Entites.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBookService/AddContact", ReplyAction="http://tempuri.org/IAddressBookService/AddContactResponse")]
        System.Threading.Tasks.Task AddContactAsync(AddressBook.Entites.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBookService/ChangePhoneNumber", ReplyAction="http://tempuri.org/IAddressBookService/ChangePhoneNumberResponse")]
        void ChangePhoneNumber(int contactId, string phoneNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBookService/ChangePhoneNumber", ReplyAction="http://tempuri.org/IAddressBookService/ChangePhoneNumberResponse")]
        System.Threading.Tasks.Task ChangePhoneNumberAsync(int contactId, string phoneNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBookService/DeleteContact", ReplyAction="http://tempuri.org/IAddressBookService/DeleteContactResponse")]
        void DeleteContact(int contactId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddressBookService/DeleteContact", ReplyAction="http://tempuri.org/IAddressBookService/DeleteContactResponse")]
        System.Threading.Tasks.Task DeleteContactAsync(int contactId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAddressBookServiceChannel : AdresBook.UI.ServiceReference1.IAddressBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddressBookServiceClient : System.ServiceModel.ClientBase<AdresBook.UI.ServiceReference1.IAddressBookService>, AdresBook.UI.ServiceReference1.IAddressBookService {
        
        public AddressBookServiceClient() {
        }
        
        public AddressBookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AddressBookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddressBookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddressBookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.ObjectModel.ObservableCollection<AddressBook.Entites.Contact> GetContact() {
            return base.Channel.GetContact();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<AddressBook.Entites.Contact>> GetContactAsync() {
            return base.Channel.GetContactAsync();
        }
        
        public System.Collections.ObjectModel.ObservableCollection<AddressBook.Entites.Contact> FindContactbyPhone(string phoneNumber) {
            return base.Channel.FindContactbyPhone(phoneNumber);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<AddressBook.Entites.Contact>> FindContactbyPhoneAsync(string phoneNumber) {
            return base.Channel.FindContactbyPhoneAsync(phoneNumber);
        }
        
        public System.Collections.ObjectModel.ObservableCollection<AddressBook.Entites.Contact> FindContactbyName(int varOperation, string str) {
            return base.Channel.FindContactbyName(varOperation, str);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<AddressBook.Entites.Contact>> FindContactbyNameAsync(int varOperation, string str) {
            return base.Channel.FindContactbyNameAsync(varOperation, str);
        }
        
        public void AddContact(AddressBook.Entites.Contact contact) {
            base.Channel.AddContact(contact);
        }
        
        public System.Threading.Tasks.Task AddContactAsync(AddressBook.Entites.Contact contact) {
            return base.Channel.AddContactAsync(contact);
        }
        
        public void ChangePhoneNumber(int contactId, string phoneNumber) {
            base.Channel.ChangePhoneNumber(contactId, phoneNumber);
        }
        
        public System.Threading.Tasks.Task ChangePhoneNumberAsync(int contactId, string phoneNumber) {
            return base.Channel.ChangePhoneNumberAsync(contactId, phoneNumber);
        }
        
        public void DeleteContact(int contactId) {
            base.Channel.DeleteContact(contactId);
        }
        
        public System.Threading.Tasks.Task DeleteContactAsync(int contactId) {
            return base.Channel.DeleteContactAsync(contactId);
        }
    }
}
