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

        public void getFields(ComboBox cbField, ComboBox cbFieldInt, ComboBox cbTable, DataGridView dGV)//получение названия полей таблицы
        {
            string select = "select * from " + cbTable.SelectedItem;
            DataSet ds = data(select);

            cbField.Items.Clear();
            cbFieldInt.Items.Clear();
            for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
            {
                cbField.Items.Add(ds.Tables[0].Columns[j].ColumnName);
                if ((ds.Tables[0].Columns[j].DataType).ToString().Contains("Int"))
                {
                    cbFieldInt.Items.Add(ds.Tables[0].Columns[j].ColumnName);
                }
            }
            cbField.SelectedIndex = 0;
            cbFieldInt.SelectedIndex = 0;
        }

        public void updateDataGrid(ComboBox cbTable, ComboBox cbField, ComboBox cbSort, ComboBox cbFieldInt, ComboBox cbCount, DataGridView dGV, TextBox tbCustom, TextBox tbSearch, int action)
        {
            try
            {
                DataTable table = new DataTable("Servicemans");
                dataSet = new DataSet();
                string select = "";
                switch (action)
                {
                    case 0://без условий
                        {
                            select += "select * from " + cbTable.SelectedItem;
                            break;
                        }
                    case 1://сортировка
                        {
                            string sort;
                            if (cbSort.SelectedItem.ToString() == "Ascending")
                            {
                                sort = "asc";
                            }
                            else
                            {
                                sort = "desc";
                            }
                            select = "select * from " + cbTable.SelectedItem + " order by " + cbField.SelectedItem + " " + sort;
                            break;
                        }
                    case 2://поиск
                        {
                            select = "select * from " + cbTable.SelectedItem + " where " + cbField.SelectedItem + " like '" + tbSearch.Text + "'";
                            break;
                        }
                    case 3://подсчет значения
                        {
                            select = "select " + cbCount.SelectedItem + "(" + cbFieldInt.SelectedItem.ToString() + ") as '" + tbCustom.Text + "' from " + cbTable.SelectedItem;
                            break;
                        }
                    case 4://свое условие
                        {
                            if (tbCustom.Text != "")//свой запрос
                                select = tbCustom.Text;
                            break;
                        }
                    case 5://удаление
                        {
                            select = "Delete from " + cbTable.SelectedItem + " where " + cbField.Items[0] + " = '" + dGV.SelectedRows[0].Cells[0].Value + "'";
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