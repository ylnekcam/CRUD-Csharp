/*
 * Created by SharpDevelop.
 * User: My Asus
 * Date: 11/3/2019
 * Time: 8:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

using System.Data.SQLite;

namespace Adding_Workload
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public static class SqliteClass
	{
		public static String tbExecuteData(String DbPath, String sql)
		{
			String result = " ";
			try {
				using (SQLiteConnection sQLiteConnection = new SQLiteConnection(DbPath)) {
					sQLiteConnection.Open();
					SQLiteCommand sQLiteCommand = new SQLiteCommand(sql, sQLiteConnection);
					sQLiteCommand.ExecuteNonQuery();
					sQLiteConnection.Close();
					result = "ok";
				}
			}
			catch (SQLiteException arg) {
				result = "Error:" + arg;
			}
			return result;
		}

		public static int tbGetDataCount (String DbPath,String dbquery)
		{
			
			int x=0;
			try
			{
				using (SQLiteConnection conn = new SQLiteConnection(DbPath))
				{
					conn.Open();
					
					using (SQLiteCommand cmd = new SQLiteCommand(dbquery, conn))
					{
						using (SQLiteDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								
								x=x+1;
								
							}
						}
					}
					conn.Close();
				}
			}
			catch (SQLiteException arg) {
				
			}
			
			return x;
		}
		
		
		public static void setdataToCombo (String DbPath,String dbquery,ComboBox cmbbox)
		{
			String cmbdata="";
		try
			{
				using (SQLiteConnection conn = new SQLiteConnection(DbPath))
				{
					conn.Open();
					
					using (SQLiteCommand cmd = new SQLiteCommand(dbquery, conn))
					{
						using (SQLiteDataReader reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								
								cmbbox.Items.Add(reader[0].ToString());
								
							}
							
						}
					}
					conn.Close();
				}
			}
			catch (SQLiteException arg) {
				
			}
			
		}
		

		public static void setDataToGridview(string DbPath, string dbquery, DataGridView datagrid)
		{
			checked {
				try {
					using (SQLiteConnection sQLiteConnection = new SQLiteConnection(DbPath)) {
						sQLiteConnection.Open();
						using (SQLiteCommand sQLiteCommand = new SQLiteCommand(dbquery, sQLiteConnection)) {
							using (SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader()) {
								datagrid.ColumnCount = sQLiteDataReader.FieldCount;
								for (int i = 0; i < sQLiteDataReader.FieldCount; i++) {
									datagrid.Columns[i].Name = sQLiteDataReader.GetName(i);
									
								}
								
								
								while (sQLiteDataReader.Read()) {
									object[] array = new object[sQLiteDataReader.FieldCount];
									for (int j = 0; j < sQLiteDataReader.FieldCount; j++) {
										array[j] = sQLiteDataReader.GetValue(j);
									}
									datagrid.Rows.Add(array).ToString();
								}
							}
						}
						sQLiteConnection.Close();
					}
				}
				catch (SQLiteException value) {
					Console.Write(value);
				}
			}
		}

		
	}
}
