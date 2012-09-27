using System.Data.Entity;

namespace WebContacts.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext()
            : base("Contacts")
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}