using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGovScot.MyAccount.Registration;

namespace MyGovScot.MyAccount.Test
{
    [TestClass]
    public class registrationUnitTest
    {
        string CallerToken = "Joe";
        string UCRN = "111222333444";
        string UPRN = "3333333333";
        string Forename = "Joe";
        string Surname = "Bloggs";
        DateTime DoB = new DateTime(1974, 11, 26);
        MyGovScot.MyAccount.Registration.GenderType Gender = MyGovScot.MyAccount.Registration.GenderType.M;
        string MotherBirthSurname = "Becks";
        string PlaceOfBirth = "Aberdeen";
        string  add1="flat 9";
        string add2="8 Riverview Place";
        string add3 ="Kingston" ;
        string town ="Glasgow";
        string postcode = "G5 8EB";

        [TestMethod]
        public void registerUCRNUPRN()
        {
            registrationRequest1 myRegistrationRequest = new registrationRequest1(CallerToken, UCRN, UPRN);
            Assert.AreEqual(CallerToken, myRegistrationRequest.registration.CallerToken);
            MyGovScot.MyAccount.Registration.UCRNType myUCRN = (MyGovScot.MyAccount.Registration.UCRNType)myRegistrationRequest.registration.registrationRequest.RequestBody.Item;
            MyGovScot.MyAccount.Registration.UPRNType myUPRN = (MyGovScot.MyAccount.Registration.UPRNType)myRegistrationRequest.registration.registrationRequest.RequestBody.Item1;
            Assert.AreEqual(myUCRN.Value, UCRN);
            Assert.AreEqual(myUPRN.Value, UPRN);
        }
        [TestMethod]
        public void registerCitizenDetailsUPRN()
        {
            registrationRequest1 myRegistrationRequest = new registrationRequest1(CallerToken, Forename,Surname,Gender,DoB, UPRN);
            Assert.AreEqual(CallerToken, myRegistrationRequest.registration.CallerToken);
            MyGovScot.MyAccount.Registration.CitizenDetails myCitizenDetails = (MyGovScot.MyAccount.Registration.CitizenDetails)myRegistrationRequest.registration.registrationRequest.RequestBody.Item;
            MyGovScot.MyAccount.Registration.UPRNType myUPRN = (MyGovScot.MyAccount.Registration.UPRNType)myRegistrationRequest.registration.registrationRequest.RequestBody.Item1;
        
            Assert.AreEqual(myCitizenDetails.Name.FirstName ,Forename);
            Assert.AreEqual(myCitizenDetails.Name.LastName, Surname);
            Assert.AreEqual(myCitizenDetails.DateOfBirth, DoB);
            Assert.AreEqual(myCitizenDetails.Gender, Gender);
            Assert.AreEqual(myUPRN.Value, UPRN);
        }

        [TestMethod]
        public void registerCitizenandAddressDetails()
        {
            registrationRequest1 myRegistrationRequest = new registrationRequest1(CallerToken, Forename,Surname,Gender,DoB,add1, add2, add3, town,postcode ,2222);
            Assert.AreEqual(CallerToken, myRegistrationRequest.registration.CallerToken);
            MyGovScot.MyAccount.Registration.CitizenDetails myCitizenDetails = (MyGovScot.MyAccount.Registration.CitizenDetails)myRegistrationRequest.registration.registrationRequest.RequestBody.Item;
            AddressInput myAddressInput = (AddressInput)myRegistrationRequest.registration.registrationRequest.RequestBody.Item1;
            Assert.AreEqual(myCitizenDetails.Name.FirstName, Forename);
            Assert.AreEqual(myCitizenDetails.Name.LastName, Surname);
            Assert.AreEqual(myCitizenDetails.DateOfBirth, DoB);
            Assert.AreEqual(myCitizenDetails.Gender, Gender);
            Assert.AreEqual(myAddressInput.AddressLine.AddressLine1, add1);
            Assert.AreEqual(myAddressInput.AddressLine.AddressLine2, add2);
            Assert.AreEqual(myAddressInput.AddressLine.AddressLine3, add3);
            Assert.AreEqual(myAddressInput.Town, town);
            Assert.AreEqual(myAddressInput.PostCode, postcode);
           
        }
    }
}
