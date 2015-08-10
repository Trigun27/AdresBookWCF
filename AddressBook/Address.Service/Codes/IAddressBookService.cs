using System.Collections.Generic;
using System.ServiceModel;
using AddressBook.Entites;

namespace Address.Service.Codes
{
    [ServiceContract]
    public interface IAddressBookService
    {
        [OperationContract]
        List<Contact> GetContact();

        [OperationContract]
        List<Contact> FindContactbyPhone(string phoneNumber);

        [OperationContract]
        List<Contact> FindContactbyName(int varOperation, string str);

        [OperationContract]
        void AddContact(Contact contact);

        [OperationContract]
        int ChangePhoneNumber();

        [OperationContract]
        int DeleteContact();

    }
}
