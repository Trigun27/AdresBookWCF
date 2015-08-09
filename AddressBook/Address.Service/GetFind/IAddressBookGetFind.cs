using System.Collections.Generic;
using System.ServiceModel;
using AddressBook.Entites;

namespace Address.Service.GetFind
{
    [ServiceContract]
    public interface IAddressBookGetFind
    {
        [OperationContract]
        List<Contact> GetContact();

        [OperationContract]
        List<Contact> FindContactbyPhone(string phoneNumber);

        [OperationContract]
        List<Contact> FindContactbyName(int varOperation, string str);


    }
}
