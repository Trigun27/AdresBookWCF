using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using AddressBook.Data;
using AddressBook.Entites;

namespace Address.Service.Codes
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class AddBookService : IAddressBookService, IDisposable
    {
        readonly AddBookDbContext _context = new AddBookDbContext();

        public List<Contact> GetContact()
        {
            return _context.Contacts.ToList();
        }

        public List<Contact> FindContactbyPhone(string phoneNumber)
        {
            List<Contact> contacts = _context.Contacts.ToList();
            return contacts.Where(contact =>
                string.Compare(contact.PhoneNumber, phoneNumber, StringComparison.CurrentCulture) == 0).ToList();

        }

        public List<Contact> FindContactbyName(int varOperation, string str)
        {
            List<Contact> contacts = _context.Contacts.ToList();
           
            switch (varOperation)
            {
                case 1:
                    {
                        return contacts.Where(contact => string.Compare(contact.LastName, str, StringComparison.CurrentCulture) == 0).ToList();
                    }
                case 2:
                    {
                        return contacts.Where(contact => string.Compare(contact.MiddleName, str, StringComparison.CurrentCulture) == 0).ToList();
                    } 
                case 3:
                    {
                        return contacts.Where(contact => string.Compare(contact.FirstName, str, StringComparison.CurrentCulture) == 0).ToList();
                    } 
                case 4:
                {
                    throw new NotImplementedException();
                }
                    
            }
            return null;
        }

        public void AddContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public int ChangePhoneNumber()
        {
            throw new NotImplementedException();
        }

        public int DeleteContact()
        {
            throw new NotImplementedException();
        }


        /*public List<Contact> FindContactbyName(string firstName, string middleName, string lastName)
        {
          throw new NotImplementedException();
        } */


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
