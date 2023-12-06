using Laboratorium_3.Controllers;
using Laboratorium_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Laboratorium_9___UnitTests
{
    public class ContactControllerTest
    {
        private ContactController _controller;
        private IContactService _service;
        public ContactControllerTest()
        {
            _service = new MemoryContactService(new CurrentDateTimeProvider());
            _service.Add(new Contact() { Name = "Test1" });
            _service.Add(new Contact() { Name = "Test2" });
            _controller = new ContactController(_service);
        }

        [Fact]
        public void IndexTest()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            Assert.IsType<List<Contact>>(view?.Model);
            List<Contact>? contacts = view.Model as List<Contact>;
            Assert.NotNull(contacts);
            Assert.Equal(2, contacts.Count);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void DetailsTestForExistingContacts(int id) 
        {
            var result = _controller.Details(id);
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            Assert.IsType<Contact>(view?.Model);
            Contact? contact = view.Model as Contact;
            Assert.NotNull(contact);
            Assert.Equal(id, contact.Id);
        }

        [Fact]
        public void DetailsTestForNonExistingContacts()
        {
            var result = _controller.Details(3);
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void CreateTest()
        {
            Contact model = new Contact() { Name  = "Test", Email = "test@wsei.pl", Phone="123"};
            var count = _service.FindAll().Count;
            var result = _controller.Create(model);
            Assert.Equal(count + 1, _service.FindAll().Count);
        }
    }
}