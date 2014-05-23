/*
 * Created by SharpDevelop.
 * User: ball.dave
 * Date: 24/01/2014
 * Time: 12:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace ASP_WEBFORM
{
	/// <summary>
	/// Description of WebControl1
	/// </summary>
	public class WebControl1 : Control
	{	
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region Data
		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region Constructor

		public WebControl1()
		{
			Init += new EventHandler( OnInit );
			Load += new EventHandler( OnLoad );
		}
		
		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region OnInit
		
		private void OnInit(object sender, EventArgs e)
		{
		}
		
		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region OnLoad
		
		private void OnLoad(object sender, EventArgs e)
		{
		}
		
		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region Properties
		#endregion
		//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
		#region Render

		protected override void Render(HtmlTextWriter Writer)
		{	
			Writer.Write( "WebControl1 Control" );
		}
		#endregion
	}
}
