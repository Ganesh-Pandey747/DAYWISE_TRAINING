using System.Collections.Generic;
using System.Linq;
using ContactRepo.Models;

namespace ContactRepo.Repository
{
    public class ContactsRepository : IContactsRepository
    {
        List<Contacts> listcontacts=new List<Contacts>(); //listcontacts is an object to perform the manupulation
        void IContactsRepository.Add(Contacts contacts)
        {
            listcontacts.Add(contacts);
        }

        Contacts IContactsRepository.Find(int Id)
        {
            var contacts =listcontacts.Where(ctr=>ctr.EmployeeId==Id).SingleOrDefault();
            return contacts;
        }

        List<Contacts> IContactsRepository.GetAll()
        {
            return listcontacts;
        }

        void IContactsRepository.Remove(int Id)
        {
           var contactToRemove =listcontacts.Where(ctr=>ctr.EmployeeId==Id).SingleOrDefault();
           if(contactToRemove!=null)
           {
               listcontacts.Remove(contactToRemove);
           } 
        }

        void IContactsRepository.Update(Contacts contacts)
        {
          var contactToUpdate =listcontacts.Where(ctr=>ctr.EmployeeId==contacts.EmployeeId).SingleOrDefault(); 
          if(contactToUpdate!=null)
          {
            contactToUpdate.EmployeeName=contacts.EmployeeName;
            contactToUpdate.EmployeeMail=contacts.EmployeeMail;
          } 
        }
    }
}