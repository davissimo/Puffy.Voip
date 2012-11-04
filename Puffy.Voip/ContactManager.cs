using System;
using System.Collections.Generic;
using System.Linq;

namespace Puffy.Voip
{
    public class ContactManager
    {
        private readonly PhoneContactProvider _phoneContactProvider;
        private readonly SimContactProvider _simContactProvider;

        private string _lastFilter;
        private List<ContactNumber> _cachedContacts;

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

            _cachedContacts = contacts
                              .OrderBy(c => c.Name)
                              .ToList();

            return _cachedContacts;
        }

        public List<ContactNumber> GetFilteredContacts(string filter)
        {
            bool isSubFilter = _lastFilter == null || filter.StartsWith(_lastFilter);
            _lastFilter = filter;

            List<ContactNumber> allContacts = isSubFilter
                                              ? _cachedContacts
                                              : this.GetAllContacts();

            _cachedContacts = allContacts
                .Where(contact => contact.Name.StartsWith(filter, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return _cachedContacts;
        }
    }
}