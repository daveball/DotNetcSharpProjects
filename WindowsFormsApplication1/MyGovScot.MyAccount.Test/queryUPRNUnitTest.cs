using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGovScot.MyAccount.QueryUPRNService;
namespace MyGovScot.MyAccount.Test
{
    [TestClass]
    public class queryUPRNUnitTest
    {
        string CallerToken = "Joe";
        string UPRN = "111222333444";
        string addressLine1 = "flat 9";
        string addressLine2 = "8 Riverview Place";
        string addressLine3="Kingston";
        string town = "Glasgow";
        string postCode = "G5 8EB";

        [TestMethod]
        public void queryUPRNNoType()
        {
           queryUPRNRequest1 myQueryUPRNRequest = new queryUPRNRequest1(CallerToken, UPRN);
           MyGovScot.MyAccount.QueryUPRNService.UPRNType myUPRNType = new MyGovScot.MyAccount.QueryUPRNService.UPRNType();
          myUPRNType = (MyGovScot.MyAccount.QueryUPRNService.UPRNType)myQueryUPRNRequest.queryUPRN.queryUPRNRequest.RequestBody.Item;
            Assert.AreEqual(UPRN, myUPRNType.Value);
            Assert.AreEqual(false, myUPRNType.UPRNType1Specified);
        }

        [TestMethod]
        public void queryUPRNAddressDetails()
        {
             queryUPRNRequest1 myQueryUPRNRequest = new queryUPRNRequest1(CallerToken,addressLine1,addressLine2,addressLine3,town,postCode);
             MyGovScot.MyAccount.QueryUPRNService.AddressDetails myAddressDetails = (MyGovScot.MyAccount.QueryUPRNService.AddressDetails)myQueryUPRNRequest.queryUPRN.queryUPRNRequest.RequestBody.Item;
            Assert.AreEqual(addressLine1, myAddressDetails.AddressLine.AddressLine1);
            Assert.AreEqual(addressLine2, myAddressDetails.AddressLine.AddressLine2);
            Assert.AreEqual(addressLine3, myAddressDetails.AddressLine.AddressLine3);
            Assert.AreEqual(town, myAddressDetails.Town);
            Assert.AreEqual(postCode, myAddressDetails.PostCode);
            
        }

        [TestMethod]
        public void queryUPRNAddressDetailsMissingCallerToken()
        {
            try
            {
                queryUPRNRequest1 myQueryUPRNRequest = new queryUPRNRequest1(null, addressLine1, addressLine2, addressLine3, town, postCode);
                AddressDetails myAddressDetails = (AddressDetails)myQueryUPRNRequest.queryUPRN.queryUPRNRequest.RequestBody.Item;
                Assert.AreEqual(addressLine1, myAddressDetails.AddressLine.AddressLine1);
                Assert.AreEqual(addressLine2, myAddressDetails.AddressLine.AddressLine2);
                Assert.AreEqual(addressLine3, myAddressDetails.AddressLine.AddressLine3);
                Assert.AreEqual(town, myAddressDetails.Town);
                Assert.AreEqual(postCode, myAddressDetails.PostCode);
            }
            catch(Exception ex)
            {
                Assert.AreEqual( "Parameter cannot be null\r\nParameter name: CallerToken",ex.Message);
            }

        }
    }
}
