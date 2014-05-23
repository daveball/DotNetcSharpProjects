using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGovScot.MyAccount.SearchCitizenDetails;


namespace MyGovScot.MyAccount.Test
{
    [TestClass]
    public class UnitTest1
    {
        DateTime DoB = new DateTime(1974, 11, 26);

        [TestMethod]
        public void searchCitizenDetailsRequestUCRN()
        {

            searchCitizenDetailsRequest1 mysearchCitizenDetailsRequest1 = new searchCitizenDetailsRequest1("dave","123");
            Assert.AreEqual("dave", mysearchCitizenDetailsRequest1.searchCitizenDetails.CallerToken);
            MyGovScot.MyAccount.SearchCitizenDetails.UCRNType myUCRN = (MyGovScot.MyAccount.SearchCitizenDetails.UCRNType)mysearchCitizenDetailsRequest1.searchCitizenDetails.searchCitizenDetailsRequest.RequestBody.Item;       
            Assert.AreEqual("123", myUCRN.Value);
        }

        [TestMethod]
        public void searchCitizenDetailsRequestBasicCitizenDetails()
        {

            searchCitizenDetailsRequest1 mysearchCitizenDetailsRequest1 = new searchCitizenDetailsRequest1("dave","Dave","Ball",DoB,GenderType.M);
            Assert.AreEqual("dave", mysearchCitizenDetailsRequest1.searchCitizenDetails.CallerToken);
            MyGovScot.MyAccount.SearchCitizenDetails.CitizenDetails myCitizenDetails = (MyGovScot.MyAccount.SearchCitizenDetails.CitizenDetails)mysearchCitizenDetailsRequest1.searchCitizenDetails.searchCitizenDetailsRequest.RequestBody.Item;
            Assert.AreEqual("Dave", myCitizenDetails.Name.FirstName);
            Assert.AreEqual("Ball", myCitizenDetails.Name.LastName);
            Assert.AreEqual(DoB, myCitizenDetails.DateOfBirth);
            Assert.AreEqual(GenderType.M, myCitizenDetails.Gender);
            Assert.AreEqual(null, myCitizenDetails.MothersBirthSurname);
            Assert.AreEqual(null, myCitizenDetails.PlaceOfBirth);
        }
        [TestMethod]
        public void searchCitizenDetailsRequestFullCitizenDetails()
        {

            searchCitizenDetailsRequest1 mysearchCitizenDetailsRequest1 = new searchCitizenDetailsRequest1("dave", "Dave", "Ball", DoB, GenderType.M,"Clarke","Glasgow");
            Assert.AreEqual("dave", mysearchCitizenDetailsRequest1.searchCitizenDetails.CallerToken);
            CitizenDetails myCitizenDetails = (CitizenDetails)mysearchCitizenDetailsRequest1.searchCitizenDetails.searchCitizenDetailsRequest.RequestBody.Item;
            Assert.AreEqual("Dave", myCitizenDetails.Name.FirstName);
            Assert.AreEqual("Ball", myCitizenDetails.Name.LastName);
            Assert.AreEqual(DoB, myCitizenDetails.DateOfBirth);
            Assert.AreEqual(GenderType.M, myCitizenDetails.Gender);
            Assert.AreEqual("Clarke", myCitizenDetails.MothersBirthSurname);
            Assert.AreEqual("Glasgow", myCitizenDetails.PlaceOfBirth);
        }

        [TestMethod]
        public void searchCitizenDetailsRequestNECNumber()
        {

            searchCitizenDetailsRequest1 mysearchCitizenDetailsRequest1 = new searchCitizenDetailsRequest1("dave", 123123123123);
            Assert.AreEqual("dave", mysearchCitizenDetailsRequest1.searchCitizenDetails.CallerToken);
            MyGovScot.MyAccount.SearchCitizenDetails.Card myCard = (MyGovScot.MyAccount.SearchCitizenDetails.Card)mysearchCitizenDetailsRequest1.searchCitizenDetails.searchCitizenDetailsRequest.RequestBody.Item;
            Assert.AreEqual(123123123123, myCard.CardNumber);
            Assert.AreEqual(true, myCard.CardNumberSpecified);
        
        }
        [TestMethod]
        public void searchCitizenDetailsRequestContactDetails()
        {

            searchCitizenDetailsRequest1 mysearchCitizenDetailsRequest1 = new searchCitizenDetailsRequest1("dave", "01414332322", "0781111111", "dave@somewhere.com");
            Assert.AreEqual("dave", mysearchCitizenDetailsRequest1.searchCitizenDetails.CallerToken);

           Contact myContact = (Contact)mysearchCitizenDetailsRequest1.searchCitizenDetails.searchCitizenDetailsRequest.RequestBody.Item;
           Assert.AreEqual("0781111111", myContact.MobileNumber);
           Assert.AreEqual("01414332322", myContact.LandlineNumber);
           Assert.AreEqual("dave@somewhere.com", myContact.EmailAddress);

        }
    }
}
