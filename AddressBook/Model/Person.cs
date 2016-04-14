using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Annotations;

namespace AddressBook.Model
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TelephoneMain { get; set; }
        public string TelephoneOther { get; set; }
        public string Skype { get; set; }
        public string Website { get; set; }
        public Address Address { get; set; }
    }
}
