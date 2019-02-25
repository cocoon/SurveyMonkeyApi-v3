using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using SurveyMonkey.Containers;
using SurveyMonkey.RequestSettings;

namespace SurveyMonkey
{
    public partial class SurveyMonkeyApi
    {
        // CONTACTS

        public List<Contact> GetContacts()
        {
            var settings = new GetContactsSettings();
            return GetContactsPager(settings);
        }

        private List<Contact> GetContactsPager(GetContactsSettings settings)
        {
            string endPoint = String.Format("/contacts");
            const int maxResultsPerPage = 1000;
            var results = Page(settings, endPoint, typeof(List<Contact>), maxResultsPerPage);
            return results.ToList().ConvertAll(o => (Contact)o);
        }

        public Contact GetContactDetails(long contactId)
        {
            string endPoint = String.Format("/contacts/{0}", contactId);
            var verb = Verb.GET;
            JToken result = MakeApiRequest(endPoint, verb, new RequestData());
            DUMPFILE.Dump("JSON_GetContactDetails_" + contactId.ToString() + "-" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".txt", result.ToString()); // DUMP json to txt
            var contactsList = result.ToObject<Contact>();
            return contactsList;
        }


        // CONTACTSLISTS
        public List<ContactList> GetContactsLists()
        {
            var settings = new GetContactsListsSettings();
            return GetContactsListsPager(settings);
        }

        private List<ContactList> GetContactsListsPager(GetContactsListsSettings settings)
        {
            string endPoint = String.Format("/contact_lists");
            const int maxResultsPerPage = 1000;
            var results = Page(settings, endPoint, typeof(List<ContactList>), maxResultsPerPage);
            return results.ToList().ConvertAll(o => (ContactList)o);
        }

        public ContactList GetContactsListDetails(long contactsListId)
        {
            string endPoint = String.Format("/contact_lists/{0}", contactsListId);
            var verb = Verb.GET;
            JToken result = MakeApiRequest(endPoint, verb, new RequestData());
            DUMPFILE.Dump("JSON_GetContactsListDetails_" + contactsListId.ToString() + "-" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".txt", result.ToString()); // DUMP json to txt
            var contactsList = result.ToObject<ContactList>();
            return contactsList;
        }

        // CONTACTSLISTS CONTATCS

    }
}