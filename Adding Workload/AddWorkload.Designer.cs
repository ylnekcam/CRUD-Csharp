/*
 * Created by SharpDevelop.
 * User: CIASI
 * Date: 7/4/2021
 * Time: 9:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Adding_Workload
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtname;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbdept;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtqty;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtpn;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtname = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbdept = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtqty = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtpn = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtname
			// 
			this.txtname.Location = new System.Drawing.Point(4, 161);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(209, 20);
			this.txtname.TabIndex = 32;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(4, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 19);
			this.label4.TabIndex = 31;
			this.label4.Text = "Name";
			// 
			// cmbdept
			// 
			this.cmbdept.FormattingEnabled = true;
			this.cmbdept.Location = new System.Drawing.Point(4, 206);
			this.cmbdept.Name = "cmbdept";
			this.cmbdept.Size = new System.Drawing.Size(128, 21);
			this.cmbdept.TabIndex = 23;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(4, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 19);
			this.label6.TabIndex = 30;
			this.label6.Text = "Dept";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(4, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 19);
			this.label5.TabIndex = 29;
			this.label5.Text = "Emp ID";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(4, 22);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(212, 20);
			this.txtid.TabIndex = 19;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(98, 233);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 38);
			this.button2.TabIndex = 27;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(160, 233);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 38);
			this.button1.TabIndex = 26;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(138, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 19);
			this.label3.TabIndex = 28;
			this.label3.Text = "QTY";
			// 
			// txtqty
			// 
			this.txtqty.Location = new System.Drawing.Point(138, 206);
			this.txtqty.Name = "txtqty";
			this.txtqty.Size = new System.Drawing.Size(78, 20);
			this.txtqty.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 15);
			this.label2.TabIndex = 24;
			this.label2.Text = "Password";
			// 
			// txtpass
			// 
			this.txtpass.Location = new System.Drawing.Point(4, 66);
			this.txtpass.Name = "txtpass";
			this.txtpass.PasswordChar = '*';
			this.txtpass.Size = new System.Drawing.Size(212, 20);
			this.txtpass.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 19);
			this.label1.TabIndex = 21;
			this.label1.Text = "Part Number";
			// 
			// txtpn
			// 
			this.txtpn.Location = new System.Drawing.Point(4, 115);
			this.txtpn.Name = "txtpn";
			this.txtpn.Size = new System.Drawing.Size(212, 20);
			this.txtpn.TabIndex = 22;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(222, 281);
			this.Controls.Add(this.txtname);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbdept);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtqty);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtpass);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtpn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Add Workload";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
