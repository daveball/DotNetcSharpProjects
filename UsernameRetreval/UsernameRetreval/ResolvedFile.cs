/*
 * Created by SharpDevelop.
 * User: ball.dave
 * Date: 17/04/2014
 * Time: 13:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FileHelpers;

namespace UsernameRetreval
{
	/// <summary>
	/// Description of ResolvedFile.
	/// </summary>
	/// 
	[DelimitedRecord(",")] 
	public class ResolvedFile
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
			[FieldQuoted()] 
			public string returnedUsername;
			
			public ResolvedFile()
  		{}
		public ResolvedFile(MDMWFile record, string User)
		{
			UCRN= record.UCRN;
			Username= record.Username;
			Email =record.Email;
				Validated =record.Validated;
				UPRN = record.UPRN;
				Addr1=record.Addr1;
   Addr2=record.Addr2;
  		Addr3=record.Addr3;
  		 Addr4=record.Addr4;
		 PCode= record.PCode;
  	
			returnedUsername=User;
		}
		
	}
}
