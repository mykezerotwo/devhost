/*
 * Created by SharpDevelop.
 * User: mofo
 * Date: 13/05/2018
 * Time: 20:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace devhost
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txHostMap;
		private System.Windows.Forms.Button btnWriteData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LbMessages;
		private System.Windows.Forms.Button bnRemoveEntries;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txHostMap = new System.Windows.Forms.TextBox();
			this.btnWriteData = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.LbMessages = new System.Windows.Forms.Label();
			this.bnRemoveEntries = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txHostMap
			// 
			this.txHostMap.Location = new System.Drawing.Point(12, 28);
			this.txHostMap.Multiline = true;
			this.txHostMap.Name = "txHostMap";
			this.txHostMap.Size = new System.Drawing.Size(400, 232);
			this.txHostMap.TabIndex = 0;
			this.txHostMap.Text = "66.66.66.66   Server2.example.net.org\r\n77.77.77.77   Server2.example.net.org";
			// 
			// btnWriteData
			// 
			this.btnWriteData.Location = new System.Drawing.Point(22, 266);
			this.btnWriteData.Name = "btnWriteData";
			this.btnWriteData.Size = new System.Drawing.Size(118, 23);
			this.btnWriteData.TabIndex = 1;
			this.btnWriteData.Text = "Enable Alias Entries";
			this.btnWriteData.UseVisualStyleBackColor = true;
			this.btnWriteData.Click += new System.EventHandler(this.BtnWriteDataClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Add IP Address, + two or more Spaces Then DNS names";
			// 
			// LbMessages
			// 
			this.LbMessages.Location = new System.Drawing.Point(22, 315);
			this.LbMessages.Name = "LbMessages";
			this.LbMessages.Size = new System.Drawing.Size(437, 23);
			this.LbMessages.TabIndex = 3;
			// 
			// bnRemoveEntries
			// 
			this.bnRemoveEntries.Location = new System.Drawing.Point(22, 289);
			this.bnRemoveEntries.Name = "bnRemoveEntries";
			this.bnRemoveEntries.Size = new System.Drawing.Size(118, 23);
			this.bnRemoveEntries.TabIndex = 4;
			this.bnRemoveEntries.Text = "Disable Alias Entries";
			this.bnRemoveEntries.UseVisualStyleBackColor = true;
			this.bnRemoveEntries.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 332);
			this.Controls.Add(this.bnRemoveEntries);
			this.Controls.Add(this.LbMessages);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnWriteData);
			this.Controls.Add(this.txHostMap);
			this.MaximumSize = new System.Drawing.Size(445, 372);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DevHostfileSwitch";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
