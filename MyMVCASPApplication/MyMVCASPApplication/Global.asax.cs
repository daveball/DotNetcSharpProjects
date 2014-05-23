/*
 * Created by SharpDevelop.
 * User: Ball.Dave
 * Date: 14/02/2014
 * Time: 09:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyMVCASPApplication
{
	public class MvcApplication : HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.Ignore("{resource}.axd/{*pathInfo}");
			
			routes.MapRoute(
				"Default",
				"{controller}/{action}/{id}",
				new {
					controller = "Home",
					action = "Index",
					id = UrlParameter.Optional
				});
		}
		
		protected void Application_Start()
		{
			RegisterRoutes(RouteTable.Routes);
		}
	}
}
