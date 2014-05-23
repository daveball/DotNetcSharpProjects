/*
 * Created by SharpDevelop.
 * User: ball.dave
 * Date: 17/04/2014
 * Time: 11:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FileHelpers;

namespace UsernameRetreval
{
	/// <summary>
	/// Description of MDMWFile.
	/// </summary>
	/// 
	[IgnoreEmptyLines] 
	[DelimitedRecord(",")] 
	public class MDMWFile
	{
		
			[FieldQuoted()]		
			public string UCRN;
			
			[FieldQuoted()] 
			public string Username;		
			[FieldQuoted()]
			public string Email;
			[FieldQuoted()] 
			public string Validated;
			[FieldQuoted()] 
			public string UPRN;
			[FieldQuoted()] 
			public string Addr1;
			[FieldQuoted()] 
			public string Addr2;
			[FieldQuoted()] 
			public string Addr3;
			[FieldQuoted()] 
			public string Addr4;
			[FieldQuoted()] 
			public string PCode;
		
	}
}
