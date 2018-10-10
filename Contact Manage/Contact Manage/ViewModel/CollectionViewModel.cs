using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contact_Manage.Models;

namespace Contact_Manage.ViewModel
{
    public class CollectionViewModel
    {
        public Person Person { get; set; }
        public List<Contact> Contact { get; set; }

        public CollectionViewModel()
        {
            Person = new Person();
            Contact = new List<Contact>();
        }
    }
}