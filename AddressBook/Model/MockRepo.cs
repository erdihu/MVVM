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
        private List<Person> _persons;

        public MockRepo()
        {
            List<Address> _addresses = new List<Address>
            {
               new Address
               {
                   Id = Guid.NewGuid(),
                   Street = "Northway 1",
                   City = "Northcity",
                   PostalCode = "12345",
                   Country = "Mars",
               }, 
               new Address
               {
                   Id = Guid.NewGuid(),
                   Street = "Redway 2",
                   City = "Ghostcity",
                   PostalCode = "12345",
                   Country = "Jupiter",
               }
            };

            _persons = new List<Person>
            {
                new Person
                {
                    Id = Guid.NewGuid(),
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
                    Id = Guid.NewGuid(),
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

        public List<Person> Get()
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
                Id = Guid.NewGuid(),
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
                person = toBeUpdated;
            }
        }
    }
}
