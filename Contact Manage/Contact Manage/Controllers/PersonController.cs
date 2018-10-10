using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Contact_Manage.Models;
using Contact_Manage.ViewModel;
using Microsoft.AspNet.Identity;

namespace Contact_Manage.Controllers
{
    public class PersonController : Controller
    {

        private PhoneBookDbEntities _phoneBookDb;

        public PersonController()
        {
            _phoneBookDb = new PhoneBookDbEntities();
        }

        protected override void Dispose(bool disposing)
        {
            _phoneBookDb.Dispose();
        }

        [Authorize]
        // GET: Person
        public ActionResult Index()
        {
            try
            {
                //Get the id of logged In User
                string user = User.Identity.GetUserId();
                //Convert the Selected persons to the list
                var person = _phoneBookDb.People.Include(c => c.Contacts).Where(t => t.AddedBy == user).ToList();
                return View(person);
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            //Gives the person with this id
            var viewModel =  _phoneBookDb.People.Include(c => c.Contacts).Single(c => c.PersonId == id);
            return View(viewModel);
        }

        [Authorize]
        // GET: Person/Create
        public ActionResult Create()
        {
            string user = User.Identity.Name;
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(DbViewModel collection)
        {
            string user = User.Identity.GetUserId();
            try
            {
                //Data Enter in the form added to this Person present in DB
                var person = new Person();
                person.FirstName = collection.Person.FirstName;
                person.MiddleName = collection.Person.MiddleName;
                person.LastName = collection.Person.LastName;
                person.DateOfBirth = collection.Person.DateOfBirth;
                person.AddedOn = DateTime.Now;
                person.AddedBy = user;
                person.HomeAddress = collection.Person.HomeAddress;
                person.HomeCity = collection.Person.HomeCity;
                person.FaceBookAccountId = collection.Person.FaceBookAccountId;
                person.LinkedInId = collection.Person.LinkedInId;
                person.TwitterId = collection.Person.TwitterId;
                person.EmailId = collection.Person.EmailId;
                _phoneBookDb.People.Add(person);

                //Data Enter in the form added to this Contact present in DB
                //var contact = new Contact();
                //contact.ContactNumber = collection.Contact.ContactNumber;
                //contact.Type = collection.Contact.Type;
                //contact.PersonId = collection.Person.PersonId;
                //_phoneBookDb.Contacts.Add(contact);

                //Save Changes to the Database
                _phoneBookDb.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            var persons = _phoneBookDb.People.SingleOrDefault(c => c.PersonId == id);

            //Add these to the View Model
            var viewList = new DbViewModel
            {
                Person = persons,
            };
            return View(viewList);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DbViewModel collection)
        {
            try
            {
                //Select the Person and Contact of that Id
                var person = _phoneBookDb.People.Single(m => m.PersonId == id);

                //Update the Person DB
                person.FirstName = collection.Person.FirstName;
                person.MiddleName = collection.Person.MiddleName;
                person.LastName = collection.Person.LastName;
                person.DateOfBirth = collection.Person.DateOfBirth;
                person.HomeAddress = collection.Person.HomeAddress;
                person.HomeCity = collection.Person.HomeCity;
                person.FaceBookAccountId = collection.Person.FaceBookAccountId;
                person.LinkedInId = collection.Person.LinkedInId;
                person.TwitterId = collection.Person.TwitterId;
                person.EmailId = collection.Person.EmailId;

                //Add Update Time to Person Table
                _phoneBookDb.People.Single(m => m.PersonId == id).UpdateOn = DateTime.Now.Date;

                _phoneBookDb.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            //Select the Person and Contact of that Id
            var persons = _phoneBookDb.People.SingleOrDefault(c => c.PersonId == id);
            var contacts = _phoneBookDb.Contacts.Where(t => t.PersonId == id).ToList();

            //Add these to the View Model
            var viewList = new CollectionViewModel
            {
                Person = persons,
                Contact = contacts
            };
            return View(viewList);
        }

        // POST: Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CollectionViewModel collection)
        {
            try
            {
                var person = _phoneBookDb.People.Single(c => c.PersonId == id);
                _phoneBookDb.Contacts.Where(c => c.PersonId == id)
                    .ToList().ForEach(p => _phoneBookDb.Contacts.Remove(p));
                _phoneBookDb.People.Remove(person);
                _phoneBookDb.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        public ActionResult DashBoard()
        {
            string user = User.Identity.GetUserId();
            var person = _phoneBookDb.People.Where(t => t.AddedBy == user).ToList();
            return View(person);
        }

        public ActionResult CreateContact(int? id)
        {
 
            return View();
        }

        [HttpPost]
        public ActionResult CreateContact(int id, Contact collection)
        {
            var contact = new Contact();
            contact.ContactNumber = collection.ContactNumber;
            contact.Type = collection.Type;
            contact.PersonId = _phoneBookDb.People.Single(c => c.PersonId == id).PersonId;
            _phoneBookDb.Contacts.Add(contact);
            _phoneBookDb.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult EditContact(int id)
        {
            var contact = _phoneBookDb.Contacts.SingleOrDefault(c => c.ContactId == id);

            return View(contact);
        }

        [HttpPost]
        public ActionResult EditContact(int id, Contact collection)
        {
            var contact = _phoneBookDb.Contacts.Single(c => c.ContactId == id);
            contact.ContactNumber = collection.ContactNumber;
            contact.Type = collection.Type;
            _phoneBookDb.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteContact(int? id)
        {
            var contact = _phoneBookDb.Contacts.SingleOrDefault(c => c.ContactId == id);

            return View(contact);
        }

        [HttpPost, ActionName("DeleteContact")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteContact(int id)
        {
           
             var contact = _phoneBookDb.Contacts.Single(c => c.ContactId == id);
             _phoneBookDb.Contacts.Remove(contact);
             _phoneBookDb.SaveChanges();

            return RedirectToAction("Index");

        }
    }

    
}
