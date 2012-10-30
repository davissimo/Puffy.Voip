using System;
using System.Collections.Generic;
using Microsoft.WindowsMobile.PocketOutlook;

namespace Puffy.Voip
{
    public class ContactManager
    {
        public List<ContactNumber> GetFilteredContacts(string filter)
        {
            var contacts = this.GetContacts();
            var filteredContacts = new List<ContactNumber>();

            foreach (var contact in contacts)
                if (contact.Name.StartsWith(filter, StringComparison.InvariantCultureIgnoreCase))
                    filteredContacts.Add(contact);

            return filteredContacts;
        }

        public List<ContactNumber> GetContacts()
        {
            var contacts = new List<ContactNumber>();

            List<ContactNumber> phoneContacts = GetPhoneContacts();
            List<ContactNumber> simContacts = GetSimContacts();

            contacts.AddRange(phoneContacts);

            return contacts;
        }

        public List<ContactNumber> GetPhoneContacts()
        {
            var phoneContacts = new List<ContactNumber>();

            var session = new OutlookSession();

            foreach (Contact phoneContact in session.Contacts.Items)
                phoneContacts.AddRange(GetNumbersFrom(phoneContact));

            return phoneContacts;
        }

        private List<ContactNumber> GetNumbersFrom(Contact phoneContact)
        {
            var contactNumbers = new List<ContactNumber>();

            contactNumbers.AddIfPresent(new[]
                {
                    GetNumberFrom(phoneContact, ContactType.Home),
                    GetNumberFrom(phoneContact, ContactType.Mobile),
                    GetNumberFrom(phoneContact, ContactType.Company),
                    GetNumberFrom(phoneContact, ContactType.Business)
                });

            return contactNumbers;
        }

        private ContactNumber GetNumberFrom(Contact phoneContact, string contactType)
        {
            var name = GetContactNameFrom(phoneContact, contactType);
            string number = GetContactTelephoneFrom(phoneContact, contactType);

            if (String.IsNullOrEmpty(number)) return null;

            return new ContactNumber()
            {
                Name = name,
                Number = number
            };
        }

        private static string GetContactNameFrom(Contact phoneContact, string contactType)
        {
            return String.Format("{0}{1}  ({2})", 
                phoneContact.FirstName, phoneContact.LastName.WithLeadingSpace(), contactType);
        }

        private string GetContactTelephoneFrom(Contact phoneContact, string contactType)
        {
            switch (contactType)
            {
                case ContactType.Home:
                    return phoneContact.HomeTelephoneNumber;
                case ContactType.Mobile:
                    return phoneContact.MobileTelephoneNumber;
                case ContactType.Company:
                    return phoneContact.CompanyTelephoneNumber;
                case ContactType.Business:
                    return phoneContact.BusinessTelephoneNumber;
                default:
                    return null;
            }
        }

        private List<ContactNumber> GetSimContacts()
        {
            //todo: implement sim
            return null;
        }
    }
}
