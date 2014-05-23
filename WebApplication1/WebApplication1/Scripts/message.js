function onMessage1(messageEvent) {
		if (messageEvent.data["refreshParent"]) {
			if(messageEvent.data["refreshParent"] =='true')
			{
				document.loginForm.method="post";
				document.loginForm.action="samlAttrServlet";
				document.loginForm.submit();
			}
		}
		if (messageEvent.data["hideLoginFrame"]) {
			if(messageEvent.data["hideLoginFrame"] =='true')
			{
				document.getElementById('loginFrame').width="5px";
				document.getElementById('loginFrame').height="5px";
			}
		}
		if (messageEvent.data["showLoginFrame"]) {
			if(messageEvent.data["showLoginFrame"] =='true')
			{
				document.getElementById('loginFrame').width="280px";
				document.getElementById('loginFrame').height="150px";
			}
		}
	}

	var windowProxy1;
	window.onload=function(){
		Porthole.trace("onload");
		// Create a proxy window to send to and receive message from the guest iframe
		windowProxy1 = new Porthole.WindowProxy('https://is-jasig-cas:8080/proxy.html', 'loginFrame');
		windowProxy1.addEventListener(onMessage1);
	};
	function testfunction()
	{
		windowProxy1.post({'color':'red'});
	}
