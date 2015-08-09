using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Entites
{
    [DataContract]
    public class Contact
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string FullName 
        { 
            get { return string.Format("{0} {1} {2}", LastName, FirstName, MiddleName); } 
            set {} 
        }

        
    }
}
