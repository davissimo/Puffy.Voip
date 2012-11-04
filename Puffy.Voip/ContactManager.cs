using System;
using System.Collections.Generic;
using System.Linq;

namespace Puffy.Voip
{
    public class ContactManager
    {
        private readonly PhoneContactProvider _phoneContactProvider;
        private readonly SimContactProvider _simContactProvider;

        public ContactManager()
        {
            _phoneContactProvider = new PhoneContactProvider();
            _simContactProvider = new SimContactProvider();
        }

        public List<ContactNumber> GetAllContacts()
        {
            var contacts = new List<ContactNumber>();

            contacts.AddRange(_phoneContactProvider.GetPhoneContacts());
            contacts.AddRange(_simContactProvider.GetSimContacts());

            return contacts
                .OrderBy(c => c.Name)
                .ToList();
        }

        public List<ContactNumber> GetFilteredContacts(string filter)
        {
            var filteredContacts = new List<ContactNumber>();
            List<ContactNumber> allContacts = this.GetAllContacts();

            foreach (var contact in allContacts)
                if (contact.Name.StartsWith(filter, StringComparison.InvariantCultureIgnoreCase))
                    filteredContacts.Add(contact);

            return filteredContacts;
        }
    }
}