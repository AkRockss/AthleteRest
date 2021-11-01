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
            Athlete a = new Athlete { Id = 1, Name = "Aleksander K", Country = "Sverige", Height = 1.22 };
            Athlete ath = ATHmanager.Add(a);
            Assert.AreEqual("Aleksander k", ath.Name);
        }

        //public void DeleteTest()
        //{
        //    Athlete b = new Athlete { Id = 1, Name = "Aleksander K", Country = "Sverige", Height = 1.22 };
        //    Athlete ath = ATHmanager.Delete(b);
        //    Assert.AreEqual()
        //}
    }
}