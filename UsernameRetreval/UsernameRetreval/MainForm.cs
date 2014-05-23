/*
 * Created by SharpDevelop.
 * User: ball.dave
 * Date: 17/04/2014
 * Time: 11:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Devart.Data.Oracle;
using FileHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UsernameRetreval
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string getUsername(OracleConnection connection, string UCRN)
    {
        OracleCommand command = connection.CreateCommand();
        command.CommandText = "select   (apps.hz_parties.ATTRIBUTE3) as Username from apps.hz_parties  where apps.hz_parties.ATTRIBUTE1 = '"+ UCRN +"'";
        string username= null;
   
        // return value of ExecuteNonQuery (i) is the number of rows affected by the command
        using (OracleDataReader reader = command.ExecuteReader())
        {
        	//MessageBox.Show(reader.GetValue(1).ToString() + " "+ reader.FieldCount.ToString());
        	// printing the column names
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i).ToString() + "\t");;
           // MessageBox.Show(reader.GetName(i).ToString());
            }
            Console.Write(Environment.NewLine);
            // Always call Read before accesing data
            while (reader.Read())
            {
                // printing the table content
                for (int i = 0; i < reader.FieldCount; i++)
                {
                	Console.Write(reader.GetValue(i).ToString() + "\t");
                	//MessageBox.Show(reader.GetValue(i).ToString());
                	username=reader.GetValue(0).ToString();
                	
                }
                Console.Write(Environment.NewLine);
            }
            return username;
       // int i = command.ExecuteNonQuery();
        //Console.WriteLine(Environment.NewLine + "Rows in DEPT updated: {0}", i + Environment.NewLine);
    
		}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			OracleConnection oracleConnection1 = new OracleConnection();
			oracleConnection1.UserId="dball";
			oracleConnection1.Password="Password321!";
			OracleConnectionStringBuilder oraCSB = new OracleConnectionStringBuilder();
			//oraCSB
			oraCSB.Direct = true;
			oraCSB.Server = "127.0.0.1";
			oraCSB.Port = 1561;
			oraCSB.ServiceName="CASP";
			//oraCSB.Sid = "CASU";
			oraCSB.UserId = "dball";
			oraCSB.Password = "Password543!";
			oraCSB.MaxPoolSize = 150;
			oraCSB.ConnectionTimeout = 30;
			DateTime now = DateTime.Now;
			 List<ResolvedFile> Resolved_File = new List<ResolvedFile>();
			string outfilenamewithpath =@"c:/test/MDMWUsername"+now.Day.ToString()+ now.Month.ToString()+ now.Year.ToString()+ now.Hour.ToString()+now.Minute.ToString()+".txt";
			OracleConnection myConnection = new OracleConnection(oraCSB.ConnectionString);
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
   			{
      			FileHelperEngine engine = new FileHelperEngine(typeof(MDMWFile)); 
	          engine.Options.IgnoreFirstLines=1;
			 
				MDMWFile[] res = engine.ReadFile(openFileDialog1.FileName) as MDMWFile[]; 
			List<MDMWFile>  list_lines = new List<MDMWFile>(res);	
			  myConnection.Open();
			Parallel.ForEach(list_lines,
    			new ParallelOptions { MaxDegreeOfParallelism = 20 }, cust =>
    			{
    			string    Username=string.Empty;
    				try
    				{
    				
    					Username = getUsername(myConnection,cust.UCRN);
    				}
    				catch(Exception Ex)
    				{
    				}
    				ResolvedFile myResolvedFile = new ResolvedFile(cust,Username);
			     					
			     	Resolved_File.Add(myResolvedFile);
			  });
			}
			   FileHelperEngine engineMatch = new FileHelperEngine(typeof(ResolvedFile)); 
	         engineMatch.WriteFile(outfilenamewithpath,Resolved_File);
	         MessageBox.Show("Completted retrevial of Usernames");
			
		}
	}
}
