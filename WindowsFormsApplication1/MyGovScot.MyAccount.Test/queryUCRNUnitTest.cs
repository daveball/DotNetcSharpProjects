using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.ComponentModel;
using MyGovScot.MyAccount.QueryUCRNService;

namespace MyGovScot.MyAccount.Test
{
    [TestClass]
    public class queryUCRNUnitTest
    {
        string CallerToken = "Joe";
        string UCRN = "111222333444";
        string Forename = "Joe";
        string Surname = "Bloggs";
        DateTime DoB = new DateTime(1974, 11, 26);
        MyGovScot.MyAccount.QueryUCRNService.GenderType Gender = MyGovScot.MyAccount.QueryUCRNService.GenderType.M;
        string MotherBirthSurname = "Becks";
        string PlaceOfBirth = "Aberdeen";
        MyGovScot.MyAccount.QueryUCRNService.UCRNTypeUCRNType myUCRNTypeType = QueryUCRNService.UCRNTypeUCRNType.P;

        [TestMethod]
        public void queryUCRNnoTypeSpecified()
        {
            
       queryUCRNRequest1    myQueryUCRNRequest =  new queryUCRNRequest1(CallerToken, UCRN);
        
        queryUCRN myQueryUCRN= myQueryUCRNRequest.queryUCRN;
        MyGovScot.MyAccount.QueryUCRNService.UCRNType myUCRNType = (MyGovScot.MyAccount.QueryUCRNService.UCRNType)myQueryUCRN.queryUCRNRequest.RequestBody.Item;
        UCRNType TestUCRNType = new UCRNType();
        TestUCRNType.Value = UCRN;
        TestUCRNType.UCRNType1Specified = false;
        Assert.AreEqual(CallerToken, myQueryUCRNRequest.queryUCRN.CallerToken);
        Assert.AreEqual(TestUCRNType.Value,myUCRNType.Value);
        Assert.AreEqual(UCRN, myUCRNType.Value);
        Assert.AreEqual(TestUCRNType.UCRNType1Specified, myUCRNType.UCRNType1Specified);

        }
        [TestMethod]
        public void queryUCRNTypePSpecified()
        {
            //Create an Instance of the queryUCRNWrapper Class
            //MyAccount.queryUCRNWrapper myQueryUCRNwrapper = new queryUCRNWrapper();
        
            //Create a queryUCRNRequest1 using the method on the wrapper class

            queryUCRNRequest1 myQueryUCRNRequest = new queryUCRNRequest1(CallerToken, UCRN, true, MyGovScot.MyAccount.QueryUCRNService.UCRNTypeUCRNType.P);
           
            //queryUCRN myQueryUCRN = new queryUCRN();
            MyGovScot.MyAccount.QueryUCRNService.UCRNType myUCRNType = (MyGovScot.MyAccount.QueryUCRNService.UCRNType)myQueryUCRNRequest.queryUCRN.queryUCRNRequest.RequestBody.Item;
            MyGovScot.MyAccount.QueryUCRNService.UCRNType TestUCRNType = new  QueryUCRNService.UCRNType();
            TestUCRNType.Value = UCRN;
            TestUCRNType.UCRNType1Specified = true;
            TestUCRNType.UCRNType1 = myUCRNTypeType;
            // Check that the Caller Token Value  matches the string  value set
            Assert.AreEqual(CallerToken, myQueryUCRNRequest.queryUCRN.CallerToken);
            Assert.AreEqual(TestUCRNType.Value, myUCRNType.Value);
            Assert.AreEqual(UCRN, myUCRNType.Value);
            Assert.AreEqual(TestUCRNType.UCRNType1Specified, myUCRNType.UCRNType1Specified);
            Assert.AreEqual(TestUCRNType.UCRNType1, myUCRNType.UCRNType1);

        }
        [TestMethod]
        public void queryUCRNTypeTSpecified()
        {
           


            queryUCRNRequest1 myQueryUCRNRequest = new queryUCRNRequest1(CallerToken, UCRN, true, MyGovScot.MyAccount.QueryUCRNService.UCRNTypeUCRNType.T);
            queryUCRN myQueryUCRN = myQueryUCRNRequest.queryUCRN;
            MyGovScot.MyAccount.QueryUCRNService.UCRNType myUCRNType = (MyGovScot.MyAccount.QueryUCRNService.UCRNType)myQueryUCRN.queryUCRNRequest.RequestBody.Item;
            MyGovScot.MyAccount.QueryUCRNService.UCRNType TestUCRNType = new MyGovScot.MyAccount.QueryUCRNService.UCRNType();
            TestUCRNType.Value = UCRN;
            TestUCRNType.UCRNType1Specified = true;
            Assert.AreEqual(CallerToken, myQueryUCRNRequest.queryUCRN.CallerToken);
            TestUCRNType.UCRNType1 = MyGovScot.MyAccount.QueryUCRNService.UCRNTypeUCRNType.T;
            Assert.AreEqual(TestUCRNType.Value, myUCRNType.Value);
            Assert.AreEqual(UCRN, myUCRNType.Value);
            Assert.AreEqual(TestUCRNType.UCRNType1Specified, myUCRNType.UCRNType1Specified);
            Assert.AreEqual(TestUCRNType.UCRNType1, myUCRNType.UCRNType1);

        }
        [TestMethod]
        public void queryUCRNTypePUSpecified()
        {
           // MyAccount.queryUCRNWrapper myQueryUCRNwrapper = new queryUCRNWrapper();

            queryUCRNRequest1 myQueryUCRNRequest =  new queryUCRNRequest1(CallerToken, UCRN, true, MyGovScot.MyAccount.QueryUCRNService.UCRNTypeUCRNType.PU);
            Assert.AreEqual(CallerToken, myQueryUCRNRequest.queryUCRN.CallerToken);
            queryUCRN myQueryUCRN = myQueryUCRNRequest.queryUCRN;
            MyGovScot.MyAccount.QueryUCRNService.UCRNType myUCRNType = (MyGovScot.MyAccount.QueryUCRNService.UCRNType)myQueryUCRN.queryUCRNRequest.RequestBody.Item;
            MyGovScot.MyAccount.QueryUCRNService.UCRNType TestUCRNType = new MyGovScot.MyAccount.QueryUCRNService.UCRNType();
            TestUCRNType.Value = UCRN;
            TestUCRNType.UCRNType1Specified = true;
            TestUCRNType.UCRNType1 = MyGovScot.MyAccount.QueryUCRNService.UCRNTypeUCRNType.PU;
            Assert.AreEqual(TestUCRNType.Value, myUCRNType.Value);
            Assert.AreEqual(UCRN, myUCRNType.Value);
            Assert.AreEqual(TestUCRNType.UCRNType1Specified, myUCRNType.UCRNType1Specified);
            Assert.AreEqual(TestUCRNType.UCRNType1, myUCRNType.UCRNType1);

        }
         [TestMethod]
        public void queryUCRNCitizenDetailsOnly()
        {
            queryUCRNRequest1 myQueryUCRNRequest =  new queryUCRNRequest1(CallerToken, Forename, Surname, DoB, Gender);
            MyGovScot.MyAccount.QueryUCRNService.CitizenDetails myCitizenDetail = (MyGovScot.MyAccount.QueryUCRNService.CitizenDetails)myQueryUCRNRequest.queryUCRN.queryUCRNRequest.RequestBody.Item;

            Assert.AreEqual(Forename, myCitizenDetail.Name.FirstName);
            Assert.AreEqual(Surname, myCitizenDetail.Name.LastName);
            Assert.AreEqual(DoB, myCitizenDetail.DateOfBirth);
            Assert.AreEqual(Gender, myCitizenDetail.Gender);

        }
         [TestMethod]
         public void queryUCRNCitizenDetailsMotherBirthSurnameAndPlaceOfBirth()
         {
             queryUCRNRequest1 myQueryUCRNRequest =  new queryUCRNRequest1(CallerToken, Forename, Surname, DoB, Gender,PlaceOfBirth,MotherBirthSurname);
             MyGovScot.MyAccount.QueryUCRNService.CitizenDetails myCitizenDetail = (MyGovScot.MyAccount.QueryUCRNService.CitizenDetails)myQueryUCRNRequest.queryUCRN.queryUCRNRequest.RequestBody.Item;

             Assert.AreEqual(Forename, myCitizenDetail.Name.FirstName);
             Assert.AreEqual(Surname, myCitizenDetail.Name.LastName);
             Assert.AreEqual(DoB, myCitizenDetail.DateOfBirth);
             Assert.AreEqual(Gender, myCitizenDetail.Gender);
             Assert.AreEqual(PlaceOfBirth,myCitizenDetail.PlaceOfBirth);
             Assert.AreEqual(MotherBirthSurname,myCitizenDetail.MothersBirthSurname);
                 


         }
         [TestMethod]
         public void queryUCRNCitizenCallerTokenEmptyString()
         {
             try
             {
                //queryUCRNRequest1 myQueryUCRNRequest = new  queryUCRNRequest1("", Forename, Surname, DoB, Gender, PlaceOfBirth, MotherBirthSurname);
             }
             catch (Exception ex)
             {
                 Assert.AreEqual("CallerToken cannot  be null or empty string", ex.Message);
             }
         }
        [TestMethod]
        public void queryUCRNCitizenForenameEmptyString()
         {
             try
             {
                //queryUCRNRequest1 myQueryUCRNRequest = new queryUCRNRequest1(CallerToken, "", Surname, DoB, Gender, PlaceOfBirth, MotherBirthSurname);
             }
            catch(Exception ex)
             {
                 Assert.AreEqual("Forename cannot  be null or empty string", ex.Message);
             }
         }
        [TestMethod]
        public void queryUCRNCitizenSurnameEmptyString()
        {
            try
            {
              //queryUCRNRequest1 myQueryUCRNRequest = new queryUCRNRequest1(CallerToken, Forename, "", DoB, Gender, PlaceOfBirth, MotherBirthSurname);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Surname cannot  be null or empty string", ex.Message);
            }
        }

        //[TestMethod]
        //public  void CallWebserviceWithUCRN()
        //{    try
        //   {
        //    string myCallerToken ="sp_super_admin";
        //    string myPassword = "FFfwsf2cAIp8aow6MHT9Ow==";
        //    QueryUCRNServiceClient myQueryUCRNService = new QueryUCRNServiceClient();
        //    myQueryUCRNService.ClientCredentials.UserName.UserName = myCallerToken ;
        //    myQueryUCRNService.ClientCredentials.UserName.Password = myPassword;
        //    queryUCRN myQueryUCRNRequest = new queryUCRN(myCallerToken, "200017120001711003");
        //    queryUCRNResponse myQueryUCRNResponse= new queryUCRNResponse();
         
        //       myQueryUCRNResponse = myQueryUCRNService.queryUCRN(myQueryUCRNRequest);
        //       Assert.AreEqual("e", "");

        //   }
        //    catch (Exception ex)
        //   {
        //       MessageBox.Show(ex.Message);
        //   }
        //}    
    }
} 
