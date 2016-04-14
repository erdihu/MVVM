using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model
{
    public interface IRepository
    {
        List<Person> Get();
        Person Get(Person person);
        void Update(Person person);
        void Delete(Person person);
        Person Insert(string firstName, string lastName, string email, string telephoneMain, string telephoneOther, string skype, string website, Address address);
        void SaveChanges();
    }
}
