/*
 * Created by SharpDevelop.
 * User: CIASI
 * Date: 7/4/2021
 * Time: 9:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Adding_Workload
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		
		String DbPath = @"Data Source=DB\data.db;Version=3; FailIfMissing=True; Foreign Keys=True;";
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void cleartext()
		{
			txtpn.Text="";
			txtpass.Text="";
			txtqty.Text="";
			txtid.Text="";
		}
		
				
		void addWorkload()
		{
			String sqlstm="insert into tbWorkload (Part_Num,Name,Dept,QTY,Process,Tape_EmpId,Tape_Stime,Tape_Etime,E001_EmpId,E001_Stime,E001_Etime) values ('"+
				txtpn.Text+"','"+
				txtname.Text+"','"+
				cmbdept.Text+"','"+
				txtqty.Text+"','','"+
				txtid.Text+"','','' ,'','','');";
			
			String a=SqliteClass.tbExecuteData(DbPath,sqlstm);
			if (a=="ok") {
				MessageBox.Show("Data Saved", "Saving");
				
				int b=0;
				b= SqliteClass.tbGetDataCount(DbPath,"Select * from tbPartNumber where Part_Num='" + txtpn.Text+"'");
				
				if (b==0) {	
				String sqlstm2="insert into tbPartNumber (Part_Num,Name,Remarks) values ('"+
				txtpn.Text+"','"+
				txtpass.Text+"','');";
				SqliteClass.tbExecuteData(DbPath,sqlstm2);
				}
					
				cleartext();
			}
		}
		
		void setDataToCmbBox(String stmt, ComboBox cmbbox)
		{
			SqliteClass.setdataToCombo(DbPath,stmt,cmbbox);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int b=0;
				b= SqliteClass.tbGetDataCount(DbPath,"Select * from tbUser where empid='" + txtid.Text+"' and emppass='"+txtpass.Text+"'");
				
				if (b!=0) {	
				addWorkload();
				}
				else
				{
					MessageBox.Show("Wrong Employee id or Password", "Saving");
				}
			
		
		
		}
		void Button2Click(object sender, EventArgs e)
		{
			cleartext();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			setDataToCmbBox ("Select DeptName from tbDept",cmbdept);
		}
	}
}
