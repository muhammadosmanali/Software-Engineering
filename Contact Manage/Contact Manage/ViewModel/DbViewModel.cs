using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contact_Manage.ViewModel
{
    public class DbViewModel
    {
        public Person Person { get; set; }
        public Contact Contact { get; set; }

        public DbViewModel()
        {
            Person = new Person();
            Contact = new Contact();
        }
    }
}