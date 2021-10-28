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
           //var result = ATHmanager.Add(Athlete);
           // Assert.AreEqual(1, ATHmanager );


        }

        public void DeleteTest()
        {
            Assert.Fail();
        }
    }
}