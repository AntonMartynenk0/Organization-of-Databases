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
    public partial class AddElementForm : Form
    {
        public string str = "";
        public string select = "";
        List<string> fieldsList = new List<string>();
        List<Control> textBoxes = new List<Control>();
        SQLRequests sQLRequests = new SQLRequests();
        ComboBox cb = new ComboBox();
        public SqlConnection con = new SqlConnection();
        private DataSet ds;
        DataGridView dGV = new DataGridView();
        public AddElementForm(ComboBox cb, DataGridView dGV, DataSet ds, SqlConnection con, string select)
        {
            InitializeComponent();
            this.ds = ds;
            this.cb = cb;
            this.str = select;
            this.con = con;
            this.select = select;
            this.dGV = dGV;
        }

        public DataSet data(string sql)
        {
            SqlDataAdapter adaptsql = new SqlDataAdapter(sql, con);
            DataSet data = new DataSet();
            adaptsql.Fill(data);
            return data;
        }

        public void add()
        {
            str = "insert " + cb.SelectedItem + "(";
            for (int i = 0; i < fieldsList.Count; i++)
            {
                if (i == fieldsList.Count - 1)
                    str += fieldsList[i] + ") values (";
                else
                    str += fieldsList[i] + ", ";
            }

            for (int i = 0; i < textBoxes.Count; i++)
            {
                if (i == textBoxes.Count - 1)
                {
                    if (textBoxes[i].GetType().ToString().Contains("NumericUpDown"))
                    {
                        str += textBoxes[i].Text + ") ";
                    }
                    else
                    {
                        str += "'" + textBoxes[i].Text + "') ";
                    }
                }
                else
                {
                    if (textBoxes[i].GetType().ToString().Contains("NumericUpDown"))
                    {
                        str += textBoxes[i].Text + ", ";
                    }
                    else
                    {
                        str += "'" + textBoxes[i].Text + "', ";
                    }
                }
            }

            try
            {
                ds = data(str);
                MessageBox.Show("Запись успешно добавлена!", "Результат выполнения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddElement_Load(object sender, EventArgs e)
        {
            ds = data(str);
            int x = 12, y = 12;
            int width = 200, height = 20;
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
                    textBox.Text = "";
                    panel1.Controls.Add(textBox);
                    textBoxes.Add(textBox);
                }
                else if ((ds.Tables[0].Columns[i].DataType).ToString().Contains("Int"))
                {
                    NumericUpDown numericUpDown = new NumericUpDown();
                    numericUpDown.Size = new System.Drawing.Size(width, height);
                    numericUpDown.Location = new System.Drawing.Point(x, y + 20);
                    numericUpDown.Value = 0;
                    numericUpDown.Maximum = (decimal)999999999;
                    panel1.Controls.Add(numericUpDown);
                    textBoxes.Add(numericUpDown);
                }
                y += height + 40;
                panel1.Controls.Add(label);
            }
            this.Location = new Point(form1.ActiveForm.Location.X + form1.ActiveForm.Width, form1.ActiveForm.Location.Y);
            getFields();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            add();
            ds = data(select);
            dGV.DataSource = ds.Tables[0];
        }

        private void getFields()
        {
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                fieldsList.Add(ds.Tables[0].Columns[i].ColumnName);
            }
        }
    }
}