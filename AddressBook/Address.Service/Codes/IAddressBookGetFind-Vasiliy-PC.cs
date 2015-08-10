using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Entites;

namespace Address.Service
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
