using AtheleteLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;

namespace AthleteRest.Manager.Tests
{
    [TestClass()]
    public class AthletesManagerTests
    {


        AthletesManager ATHmanager = new AthletesManager();
        

        [TestMethod()]
        public void GetAllTest()
        {
            var result = ATHmanager.GetAll("s");
            Assert.AreEqual(5, result.Count);

        }

        [TestMethod()]
        public void AddTest()
        {
            Athlete newAthlete = new Athlete { Id = 6, Name = "Aleksander K", Country = "Sverige", Height = 1.22 };
            Athlete addedAth = ATHmanager.Add(newAthlete);
            Assert.AreEqual(6, addedAth.Id);
            Assert.AreEqual(6, ATHmanager.GetAll("s").Count);

        }

        [TestMethod()]
        public void DeleteTest()
        {
            Athlete deleteAth = ATHmanager.Delete(1);
            Assert.AreEqual(1, deleteAth.Id);
            Assert.AreEqual(4, ATHmanager.GetAll("s").Count);

     
        }

        [TestMethod()]
        public void GetByCountryTest()
        {
            var result = ATHmanager.GetByCountry("Danmark");
            Assert.AreEqual(3, result.Count);

        }




        //[TestMethod]
        //public void TestItAll()
        //// We cannot control the execution order of test methods.
        //// unless we have only one test method ...
        //{
        //    BooksManager manager = new BooksManager();

        //    List<Book> allBooks = manager.GetAll();
        //    Assert.AreEqual(3, allBooks.Count);

        //    Book book = manager.GetById(1);
        //    Assert.AreEqual("C# is nice", book.Title);

        //    Assert.IsNull(manager.GetById(100));

        //    Book newBook = new Book { Title = "Android Programing", Price = 17.85 };
        //    Book addedBook = manager.Add(newBook);
        //    Assert.AreEqual(4, addedBook.Id);
        //    Assert.AreEqual(4, manager.GetAll().Count);

        //    Book updates = new Book { Title = "Android Programming", Price = 18.1 };
        //    Book updatedBook = manager.Update(3, updates);
        //    Assert.AreEqual("Android Programming", updatedBook.Title);

        //    Assert.IsNull(manager.Update(100, updates));

        //    Book deletedBook = manager.Delete(3);
        //    Assert.AreEqual("Android Programming", deletedBook.Title);
        //    Assert.AreEqual(3, manager.GetAll().Count);

        //    Assert.IsNull(manager.Delete(100));
        //}


    }
}