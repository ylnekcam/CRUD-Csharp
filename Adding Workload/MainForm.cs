/*
 * Created by SharpDevelop.
 * User: CIASI
 * Date: 6/26/2021
 * Time: 4:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Adding_Workload
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		String DbPath = @"Data Source=DB\data.db;Version=3; FailIfMissing=True; Foreign Keys=True;";
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
		
		
		
		void editTapeSTime()
		{
			
			
			String sqlstm ="UPDATE tbWorkload SET "+
				"Process='"+comboBox1.Text+
				"',Tape_STime='"+DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")+
				"',Tape_EmpId='"+txtid.Text+
				"' WHERE Nid="+Convert.ToInt32(lblid.Text);
			String a=SqliteClass.tbExecuteData(DbPath,sqlstm);
			
		}
		void editTapeETime()
		{
			
			
			String sqlstm ="UPDATE tbWorkload SET "+
				"Process='"+comboBox1.Text+
				" ok',Tape_STime='"+DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")+
				"',Tape_EmpId='"+txtid.Text+
				"' WHERE Nid="+Convert.ToInt32(lblid.Text);
			String a=SqliteClass.tbExecuteData(DbPath,sqlstm);
			
		}
		
		
		void searchTo(String stSearc)
		{
			dataGridView1.Rows.Clear();
			
			SqliteClass.setDataToGridview(DbPath, stSearc,dataGridView1);
			this.dataGridView1.Columns[0].Visible = false;
			
			
		}
		
		void setDataToCmbBox(String stmt, ComboBox cmbbox)
		{
			SqliteClass.setdataToCombo(DbPath,stmt,cmbbox);
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
			{
				lblid.Text=row.Cells[0].Value.ToString();
			}
					
				if (lblid.Text!="") {	
						if(comboBox1.SelectedIndex!=0){
							editTapeSTime();
						}
				}
				else
				{
					MessageBox.Show("Please Select Item", "Saving");
				}
			
		
		
		}
		void Button2Click(object sender, EventArgs e)
		{
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			searchTo("Select * from tbWorkload where Process = ''");
			cmbdept.Items.Add("All");
			setDataToCmbBox ("Select DeptName from tbDept",cmbdept);
			cmbProcess.Items.Add("All");
			setDataToCmbBox ("Select ProcessName from tbProcess",cmbProcess);
			
		}

		void Button3Click(object sender, EventArgs e)
		{
			searchTo("Select * from tbWorkload where Process = '"+cmbProcess.Text+"%' and Part_Num like '%"+txtpn.Text
			         +"%' and Dept like '%" +cmbdept.Text+"%'");
		}
		void Button4Click(object sender, EventArgs e)
		{
			Form1 frm = new Form1();
			frm.Show();
		}
	

		

	}
}
