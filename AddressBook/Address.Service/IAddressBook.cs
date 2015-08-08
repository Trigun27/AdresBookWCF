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
    public interface IAddressBook
    {
        [OperationContract]
        List<Contact> GetContact();

        [OperationContract]
        List<Contact> FindContactbyPhone();

        [OperationContract]
        List<Contact> FindContactbyName();
    }
}
