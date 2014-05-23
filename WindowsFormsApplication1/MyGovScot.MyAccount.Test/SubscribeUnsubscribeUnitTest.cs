using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGovScot.MyAccount.SubscribeUnsubscribeService;
namespace MyGovScot.MyAccount.Test
{
    [TestClass]
    class subscribeUnsubscribeUnitTest
    {
        [TestMethod]
        public void SubcribetoService()
        {
            subscribeUnsubscribeServiceRequest1 mySubscribeMessage = new subscribeUnsubscribeServiceRequest1();
            mySubscribeMessage.subscribeUnsubscribeService = new subscribeUnsubscribeService();
            mySubscribeMessage.subscribeUnsubscribeService.CallerToken = "test";
            mySubscribeMessage.subscribeUnsubscribeService.subscribeUnsubscribeServiceRequest = new SubscribeUnsubscribeServiceRequest();
            mySubscribeMessage.subscribeUnsubscribeService.subscribeUnsubscribeServiceRequest.RequestBody = new RequestBody();
            SubscribeUnsubscribeServiceRequest myRequest = new SubscribeUnsubscribeServiceRequest();
            //myRequest.RequestBody.ServiceID="11";
            //myRequest.RequestBody.OperationCode="2222";
             myRequest.RequestBody.UCRN = new UCRNType();
            myRequest.RequestBody.OperationCode= MyAccount.SubscribeUnsubscribeService.RequestBodyOperationCode.S ;
            myRequest.RequestBody.ServiceID =12;
            myRequest.RequestBody.UCRN.Value="1222222222";
        }

    }
}
