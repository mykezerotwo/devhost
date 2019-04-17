/*
 * Created by SharpDevelop.
 * User: mofo
 * Date: 13/05/2018
 * Time: 20:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace devhost
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        string path = @"C:\windows\system32\drivers\etc\hosts.1.txt";
        string hostFilepath = @"C:\windows\system32\drivers\etc\hosts"; // actual winsock host file
public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			


        // This text is added only once to the file.
        if (File.Exists(path))
        {
            // Create a file to write to.
         string SavedConfig = File.ReadAllText(path);
         
         txHostMap.Text = SavedConfig;
         LbMessages.Text = "config: file loaded.";
         txHostMap.Text = txHostMap.Text.Replace(" # Added by Dev Hostname switcher app", "");
  
        }
           else
            {
         	LbMessages.Text = "no config: showing example.";
         	}
         
        }




void BtnWriteDataClick(object sender, EventArgs e)
		{
	      
		 	
			
			String L = "";
			
			txHostMap.Text = txHostMap.Text.Replace(" # Added by Dev Hostname switcher app", "");
			
			foreach (string LineOfTxt in txHostMap.Lines) 
			
			{
				if (LineOfTxt.Length > 15)
				{
				 L = L + LineOfTxt ;
			 
				 L = L + " # Added by Dev Hostname switcher app" + Environment.NewLine;   
				 System.IO.File.WriteAllText (path, L); 
				 
			    // write to dummy file to store it for next time
				 
				}
				
				
				
			}
				
         
		//mirror to hostfile actual 	
			
			 if (File.Exists(path))
        {
            // Create a file to write to.
         string RunningConfig = File.ReadAllText(path);
         
         File.AppendAllText(hostFilepath, RunningConfig);
  
        }
			
			
			
      }
		
		
		
void Button1Click(object sender, EventArgs e)
		{
			String L = "";
			 var allLines = File.ReadAllLines(hostFilepath);
		     
			 
			 foreach (string Ln in allLines) 
			
			{
			 	if (!Ln.Contains("# Added by Dev Hostname switcher app"))
				{
				 L = L + Ln + Environment.NewLine; 
				}	
			
		    }
			 
			  File.WriteAllText(hostFilepath, L);
		}
	
	}
	
	
}
