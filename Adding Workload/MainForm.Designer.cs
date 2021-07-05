/*
 * Created by SharpDevelop.
 * User: CIASI
 * Date: 6/26/2021
 * Time: 4:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Adding_Workload
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtpn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.ComboBox cmbdept;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox cmbProcess;
		private System.Windows.Forms.Label lblid;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button4;

		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.lblid = new System.Windows.Forms.Label();
			this.cmbProcess = new System.Windows.Forms.ComboBox();
			this.button3 = new System.Windows.Forms.Button();
			this.cmbdept = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtpn = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button4 = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.lblid);
			this.panel2.Controls.Add(this.cmbProcess);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.cmbdept);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txtpn);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(586, 57);
			this.panel2.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(289, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 19);
			this.label8.TabIndex = 31;
			this.label8.Text = "Process";
			// 
			// lblid
			// 
			this.lblid.Location = new System.Drawing.Point(516, 17);
			this.lblid.Name = "lblid";
			this.lblid.Size = new System.Drawing.Size(57, 33);
			this.lblid.TabIndex = 30;
			// 
			// cmbProcess
			// 
			this.cmbProcess.FormattingEnabled = true;
			this.cmbProcess.Location = new System.Drawing.Point(289, 30);
			this.cmbProcess.Name = "cmbProcess";
			this.cmbProcess.Size = new System.Drawing.Size(102, 21);
			this.cmbProcess.TabIndex = 29;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(397, 10);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 41);
			this.button3.TabIndex = 27;
			this.button3.Text = "Search";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// cmbdept
			// 
			this.cmbdept.FormattingEnabled = true;
			this.cmbdept.Location = new System.Drawing.Point(155, 30);
			this.cmbdept.Name = "cmbdept";
			this.cmbdept.Size = new System.Drawing.Size(128, 21);
			this.cmbdept.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(155, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 19);
			this.label6.TabIndex = 23;
			this.label6.Text = "Department";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 19);
			this.label1.TabIndex = 18;
			this.label1.Text = "Part Number";
			// 
			// txtpn
			// 
			this.txtpn.Location = new System.Drawing.Point(6, 31);
			this.txtpn.Name = "txtpn";
			this.txtpn.Size = new System.Drawing.Size(143, 20);
			this.txtpn.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(5, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 19);
			this.label5.TabIndex = 22;
			this.label5.Text = "Emp ID";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(5, 31);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(83, 20);
			this.txtid.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(94, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 15);
			this.label2.TabIndex = 21;
			this.label2.Text = "Password";
			// 
			// txtpass
			// 
			this.txtpass.Location = new System.Drawing.Point(94, 31);
			this.txtpass.Name = "txtpass";
			this.txtpass.PasswordChar = '*';
			this.txtpass.Size = new System.Drawing.Size(96, 20);
			this.txtpass.TabIndex = 17;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.txtid);
			this.panel3.Controls.Add(this.comboBox1);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.txtpass);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 296);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(586, 61);
			this.panel3.TabIndex = 25;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(426, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 50);
			this.button1.TabIndex = 27;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Location = new System.Drawing.Point(210, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 19);
			this.label7.TabIndex = 26;
			this.label7.Text = "Total Item";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(210, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 26);
			this.label4.TabIndex = 25;
			this.label4.Text = "0";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"01 Tape",
			"02 PreTreatment"});
			this.comboBox1.Location = new System.Drawing.Point(321, 30);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(102, 21);
			this.comboBox1.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(321, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 19);
			this.label3.TabIndex = 24;
			this.label3.Text = "Process";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(503, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(71, 50);
			this.button2.TabIndex = 22;
			this.button2.Text = "End";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.Location = new System.Drawing.Point(0, 57);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(586, 239);
			this.dataGridView1.TabIndex = 26;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(516, 10);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(51, 41);
			this.button4.TabIndex = 32;
			this.button4.Text = "Add";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 357);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adding Workload";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
		
	
}
}
