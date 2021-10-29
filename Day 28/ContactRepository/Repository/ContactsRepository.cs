using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ContactRepository.Models;
using ContactRepository.Context;
using System.Collections.Generic;
using System.Linq;

namespace ContactRepository.Repository
{
    public class ContactsRepository : IContactsRepository
    {
        ContactsDbcontext contactsDbcontext;

        public ContactsRepository(ContactsDbcontext _contactsDbcontext)
        {
            contactsDbcontext= _contactsDbcontext;
        }
        async Task IContactsRepository.Add(Contact item)
        {
            await contactsDbcontext.AddAsync(item);
            await contactsDbcontext.SaveChangesAsync();
        }

        async Task<Contact> IContactsRepository.Find(int key)
        {
            return await contactsDbcontext.contacts.SingleOrDefaultAsync(ctr=>ctr.Id==key);
            
        }

        async Task<IEnumerable<Contact>> IContactsRepository.GetAll()
        {
          return await contactsDbcontext.contacts.ToListAsync();
        }
    }
}