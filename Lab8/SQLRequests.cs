using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Xml;
using System.Data;
using System.Windows.Forms;

namespace Lab6
{
    class SQLRequests
    {
        public System.Data.SqlClient.SqlConnection con = new SqlConnection();
        DataSet dataSet = new DataSet();

        public static string servername = @"RENDER-MACHINE\SQLEXPRESS";
        public static string databasename = "AutomotiveIndustry";

        public void createConnection()
        {
            try
            {
                con.ConnectionString = @"Data Source=" + servername + "; " +
                    "integrated security=true;" +
                    "initial catalog=" + databasename + ";";
                con.Open();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public DataSet data(string sql)
        {
            SqlDataAdapter adaptsql = new SqlDataAdapter(sql, con);
            DataSet data = new DataSet();
            adaptsql.Fill(data);
            return data;
        }

        public void unionTables(string sql, DataGridView dGV)
        {
            try
            {
                dataSet = new DataSet();
                dataSet = data(sql);
                dGV.DataSource = dataSet.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getTableNames(ComboBox cb)//получение названия таблиц 
        {
            try
            {
                DataTable schema = con.GetSchema("Tables");//получаем названия 
                foreach (DataRow row in schema.Rows)
                {
                    if (!row[2].ToString().Contains("sysdiagrams"))
                    {
                        cb.Items.Add(row[2]);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getFields(ComboBox cbField, ComboBox cbTable, CheckedListBox checkedListBox)//получение названия полей таблицы
        {
            string select = "select * from " + cbTable.SelectedItem;
            DataSet ds = data(select);

            cbField.Items.Clear();
            checkedListBox.Items.Clear();
            for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
            {
                if ((ds.Tables[0].Columns[j].ColumnName).ToString().Contains("id"))
                {
                    cbField.Items.Add(ds.Tables[0].Columns[j].ColumnName);
                }
                checkedListBox.Items.Add(ds.Tables[0].Columns[j].ColumnName);
            }
            cbField.SelectedIndex = 0;
        }

        public void updateDataGrid(ComboBox cbTable, DataGridView dGV, int action)
        {
            try
            {
                dataSet = new DataSet();
                string select = "";
                switch (action)
                {
                    case 0://без условий
                        {
                            select += "select * from " + cbTable.SelectedItem;
                            break;
                        }
                    case 5://удаление
                        {
                            select = "Delete from " + cbTable.SelectedItem + " where " + "id" + cbTable.SelectedItem + " = '" + dGV.SelectedRows[0].Cells[0].Value + "'";
                            dataSet = data(select);
                            select = "select * from " + cbTable.SelectedItem;
                            dataSet = data(select);
                            dGV.DataSource = dataSet.Tables[0];
                            break;
                        }
                    case 6://изменение
                        select = "select * from " + cbTable.SelectedItem;
                        EditElementForm editElement = new EditElementForm(cbTable, dGV, dataSet, con, select);
                        editElement.Show();
                        break;
                    case 7://добавление
                        {
                            select = "select * from " + cbTable.SelectedItem;
                            AddElementForm addElement = new AddElementForm(cbTable, dGV, dataSet, con, select);
                            addElement.Show();
                            break;
                        }
                    default:
                        break;
                }
                dataSet = data(select);
                dGV.DataSource = dataSet.Tables[0];
            }
            catch (Exception exc)//сообщение об ошибке
            {
                MessageBox.Show(exc.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}