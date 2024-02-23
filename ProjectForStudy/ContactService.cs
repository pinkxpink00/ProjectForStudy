using ProjectForStudy.Models;

namespace ProjectForStudy
{
    public class ContactService
    {
        public List<Contact> ContactList = new List<Contact>;

        public AddContact(Contact contact)
        {
            ContactList.Add(contact);
        }

    }
}
