using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab6
{
    public partial class EditElementForm : Form
    {
        public string str = "";
        public string select = "";
        List<string> fieldsList = new List<string>();
        List<Control> textBoxes = new List<Control>();
        SQLRequests sQLRequests = new SQLRequests();
        ComboBox cbTables = new ComboBox();
        DataGridView dataGridView;
        public SqlConnection con = new SqlConnection();
        private DataSet ds;
        public EditElementForm(ComboBox cbTables, DataGridView dataGridView, DataSet ds, SqlConnection con, string select)
        {
            InitializeComponent();
            this.cbTables = cbTables;
            this.dataGridView = dataGridView;
            this.ds = ds;
            this.con = con;
            this.str = select;
            this.select = select;
        }

        public DataSet data(string sql)
        {
            SqlDataAdapter adaptsql = new SqlDataAdapter(sql, con);
            DataSet data = new DataSet();
            adaptsql.Fill(data);
            return data;
        }

        public void edit()
        {
            str = "UPDATE " + cbTables.SelectedItem + " set ";
            for (int i = 1; i < fieldsList.Count; i++)
            {
                if (i == fieldsList.Count-1)
                {
                    if (textBoxes[i].GetType().ToString().Contains("NumericUpDown"))
                    {
                        if (textBoxes[i].Text == "0")
                        {
                            str += fieldsList[i] + " = NULL ";
                        }
                        else
                        {
                            str += fieldsList[i] + " = " + textBoxes[i].Text + " ";
                        }
                    }
                    else
                    {
                        if (textBoxes[i].Text == "")
                        {
                            str += fieldsList[i] + " = NULL ";
                        }
                        else
                        {
                            str += fieldsList[i] + " = '" + textBoxes[i].Text + "' ";
                        }
                    }
                }
                else
                {
                    if (textBoxes[i].GetType().ToString().Contains("NumericUpDown"))
                    {
                        if (textBoxes[i].Text == "0")
                        {
                            str += fieldsList[i] + " = NULL, ";
                        }
                        else
                        {
                            str += fieldsList[i] + " = " + textBoxes[i].Text + ", ";
                        }
                    }
                    else
                    {
                        if (textBoxes[i].Text == "")
                        {
                            str += fieldsList[i] + " = NULL, ";
                        }
                        else
                        {
                            str += fieldsList[i] + " = '" + textBoxes[i].Text + "', ";
                        }
                    }
                }
            }
            str += "where " + fieldsList[0] + " = " + dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                ds = data(str);
                MessageBox.Show("Запись успешно изменена!", "Результат выполнения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditElementForm_Load(object sender, EventArgs e)
        {
            ds = data(str);

            int x = 12, y = 12;
            int width = 200, height = 20;
            for(int k = 0; k < ds.Tables[0].Rows.Count; k++)
            {
                if (ds.Tables[0].Rows[k].ItemArray[0].ToString() == dataGridView.SelectedRows[0].Cells[0].Value.ToString())
                {
                    for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                    {
                        Label label = new Label();
                        label.Text = ds.Tables[0].Columns[i].ColumnName.ToString();
                        label.Location = new Point(x, y);
                        label.Size = new Size(200, 20);

                        if ((ds.Tables[0].Columns[i].DataType).ToString().Contains("String"))
                        {
                            TextBox textBox = new TextBox();
                            textBox.Size = new System.Drawing.Size(width, height);
                            textBox.Location = new System.Drawing.Point(x, y + 20);
                            textBox.Text = (ds.Tables[0].Rows[k].ItemArray[i]).ToString();
                            panel1.Controls.Add(textBox);
                            textBoxes.Add(textBox);
                        }
                        else if ((ds.Tables[0].Columns[i].DataType).ToString().Contains("Int"))
                        {
                            NumericUpDown numericUpDown = new NumericUpDown();
                            numericUpDown.Size = new System.Drawing.Size(width, height);
                            numericUpDown.Location = new System.Drawing.Point(x, y + 20);
                            numericUpDown.Maximum = (decimal)999999999;
                            try
                            {
                                numericUpDown.Value = (decimal)Convert.ToInt32(ds.Tables[0].Rows[k].ItemArray[i]);
                            }
                            catch (Exception)
                            {
                                numericUpDown.Value = 0;
                            }
                            panel1.Controls.Add(numericUpDown);
                            textBoxes.Add(numericUpDown);
                        }
                        y += height + 40;
                        panel1.Controls.Add(label);
                    }
                }
            }
            this.Location = new Point(form1.ActiveForm.Location.X + form1.ActiveForm.Width, form1.ActiveForm.Location.Y);
            getFields();
        }

        private void getFields()
        {
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                fieldsList.Add(ds.Tables[0].Columns[i].ColumnName);
            }
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            edit();
            ds = data(select);
            dataGridView.DataSource = ds.Tables[0];
        }
    }
}