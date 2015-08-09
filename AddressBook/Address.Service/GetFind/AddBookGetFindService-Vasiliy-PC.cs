using System;
using System.Collections.Generic;
using System.Linq;
using AddressBook.Data;
using AddressBook.Entites;

namespace Address.Service.GetFind
{
    public class AddBookGetFindService : IAddressBookGetFind
    {
        readonly AdBookDbContext _context = new AdBookDbContext();

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
                        contacts.Where(
                            contact => string.Compare(contact.LastName, str, StringComparison.CurrentCulture) == 0).ToList();
                    }break;
                case 2:
                    {
                        contacts.Where(
                            contact => string.Compare(contact.MiddelName, str, StringComparison.CurrentCulture) == 0).ToList();
                    } break;
                case 3:
                    {
                        contacts.Where(
                            contact => string.Compare(contact.FirstName, str, StringComparison.CurrentCulture) == 0).ToList();
                    } break;
                case 4:
                {
                    throw new NotImplementedException();
                }

            }
            return null;
        }



        /*public List<Contact> FindContactbyName(string firstName, string middleName, string lastName)
        {
          throw new NotImplementedException();
        } */ 

    }
}
