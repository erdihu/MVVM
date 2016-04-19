using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model
{
    public class MockRepo : IRepository
    {
        private ObservableCollection<Person> _persons;

        public MockRepo()
        {
            var _addresses = new ObservableCollection<Address>
            {
               new Address
               {
                   Id = new Guid(),
                   Street = "Northway 1",
                   City = "Northcity",
                   PostalCode = "12345",
                   Country = "Mars",
               }, 
               new Address
               {
                   Id = new Guid(),
                   Street = "Redway 2",
                   City = "Ghostcity",
                   PostalCode = "12345",
                   Country = "Jupiter",
               }
            };

            _persons = new ObservableCollection<Person>
            {
                new Person
                {
                    Id = new Guid(),
                    FirstName = "The",
                    LastName = "Martian",
                    Email = "martian@mars.com",
                    TelephoneMain = "01234",
                    TelephoneOther = "N/A",
                    Skype = "martian",
                    Website = "www.mars.com",
                    Address = _addresses[0]
                },
                new Person
                {
                    Id = new Guid(),
                    FirstName = "Big",
                    LastName = "Guy",
                    Email = "N/A",
                    TelephoneMain = "01234",
                    TelephoneOther = "N/A",
                    Skype = "big_guy123",
                    Website = "www.jupiter.com",
                    Address = _addresses[1]
                },
            };
        } 
        public void Delete(Person person)
        {
            var toBeDeleted = _persons.FirstOrDefault(p => p.Id == person.Id);

            if (toBeDeleted != null)
            {
                _persons.Remove(toBeDeleted);
            }
        }

        public ObservableCollection<Person> Get()
        {
            return _persons;
        }

        public Person Get(Person person)
        {
            var fetched = _persons.FirstOrDefault(p => p.Id == person.Id);
            return fetched ?? null;
        }

        public Person Insert(Person p)
        {
            _persons.Add(p);
            return p;
        }

        public Person Insert(string firstName, string lastName, string email, string telephoneMain, string telephoneOther, string skype, string website, Address address)
        {
            Person person = new Person
            {
                Id = new Guid(),
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                TelephoneMain = telephoneMain,
                TelephoneOther = telephoneOther,
                Skype = skype,
                Website = website,
                Address = address
            };

            _persons.Add(person);
            return person;
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Person person) //HOW?
        {
            var toBeUpdated = _persons.FirstOrDefault(p => p.Id == person.Id);

            if (toBeUpdated != null)
            {
                toBeUpdated = person;
            }
            SaveChanges();
        }
    }
}
