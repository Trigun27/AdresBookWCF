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
            char[] charsToTrim = { '-', ' ', '(', ')' };

            List<Contact> contacts = _context.Contacts.ToList();
            return contacts.Where(contact =>
                string.Compare(contact.PhoneNumber.Trim(charsToTrim), phoneNumber, StringComparison.CurrentCulture) == 0).ToList();

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
                    return
                        contacts.Where(
                            contact =>
                                string.Compare(contact.LastName + contact.FirstName + contact.MiddleName, str.Replace(" ",""),
                                    StringComparison.CurrentCulture) == 0).ToList();
                }
                    
            }
            return null;
        }

        public void AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        public void ChangePhoneNumber(int contactId, string phoneNumber)
        {
            var contact = _context.Contacts.Find(contactId);

            contact.PhoneNumber = phoneNumber;

           _context.SaveChanges();
        }

        public void DeleteContact(int contactId)
        {
            var contact = _context.Contacts.Find(contactId);
            _context.Contacts.Remove(contact);
            _context.SaveChanges();
        }



        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
