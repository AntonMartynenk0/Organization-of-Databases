using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Lab6
{
    public partial class form1 : Form
    {

        SQLRequests sqlR = new SQLRequests();

        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlR.createConnection();
                sqlR.getTableNames(comboBoxTable1);
                sqlR.getTableNames(comboBoxTable2);
                sqlR.getTableNames(comboBoxTable3);
                sqlR.getTableNames(comboBoxTableEdit);
                comboBoxTable1.SelectedIndex = 0;
                comboBoxTable2.SelectedIndex = 0;
                comboBoxTable3.SelectedIndex = 0;
                comboBoxTableEdit.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
        }

        private void comboBoxTableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlR.getFields(comboBoxField1, comboBoxTable1, checkedListBox1);
                sqlR.getFields(comboBoxField2, comboBoxTable2, checkedListBox2);
                sqlR.getFields(comboBoxField3, comboBoxTable3, checkedListBox3);
                //sqlR.getFields(cbField: comboBoxFieldList, cbFieldInt: comboBoxcomboBoxFieldListCount, comboBoxTableNames, dGV: dGV);
                //sqlR.updateDataGrid(comboBoxTableNames, comboBoxFieldList, comboBoxSort, comboBoxcomboBoxFieldListCount, comboBoxCount, dGV, textBoxCustomRequest, textBoxSearch, 0);
            }
            catch (Exception)
            {

            }
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            sqlR.updateDataGrid(comboBoxTableEdit, dGV, 5);
            //    sqlR.updateDataGrid(comboBoxTableNames, comboBoxFieldList, comboBoxSort, comboBoxcomboBoxFieldListCount, comboBoxCount, dGV, textBoxCustomRequest, textBoxSearch, 5);
        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            sqlR.updateDataGrid(comboBoxTableEdit, dGV, 6);
            //sqlR.updateDataGrid(comboBoxTableNames, comboBoxFieldList, comboBoxSort, comboBoxcomboBoxFieldListCount, comboBoxCount, dGV, textBoxCustomRequest, textBoxSearch, 6);
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            sqlR.updateDataGrid(comboBoxTableEdit, dGV, 7);
            //sqlR.updateDataGrid(comboBoxTableNames, comboBoxFieldList, comboBoxSort, comboBoxcomboBoxFieldListCount, comboBoxCount, dGV, textBoxCustomRequest, textBoxSearch, 7);
        }

        private string getCheckedFields()
        {
            string fields = " ";
            if (!checkBox2.Checked)
            {
                if (checkedListBox1.CheckedItems.Count > 0 && checkedListBox1.CheckedItems.Count > 0)
                {
                    foreach (var item in checkedListBox1.CheckedItems)
                    {
                        fields += item + ", ";
                    }

                    foreach (var item in checkedListBox2.CheckedItems)
                    {
                        fields += item + ", ";
                    }
                    fields = fields.Remove(fields.Length - 2);
                    fields += " ";
                }
            }
            else
            {
                if (checkedListBox1.CheckedItems.Count > 0 && checkedListBox2.CheckedItems.Count > 0 && checkedListBox3.CheckedItems.Count > 0)
                {
                    foreach (var item in checkedListBox1.CheckedItems)
                    {
                        fields += item + ", ";
                    }

                    foreach (var item in checkedListBox2.CheckedItems)
                    {
                        fields += item + ", ";
                    }

                    foreach (var item in checkedListBox3.CheckedItems)
                    {
                        fields += item + ", ";
                    }
                    fields = fields.Remove(fields.Length - 2);
                    fields += " ";
                }
            }
            return fields;
        }

        private void buttonUnion_Click(object sender, EventArgs e)
        {
            string select;
            string fields = getCheckedFields();
            string first_table = comboBoxTable1.Text;
            string second_table = comboBoxTable2.Text;
            string third_table = comboBoxTable3.Text;
            string id_tables1 = comboBoxField1.Text + " = " + comboBoxField2.Text;
            string id_tables2 = comboBoxField2.Text + " = " + comboBoxField3.Text;
            select = "SELECT " + fields + " FROM " + first_table + " JOIN " + second_table + " ON " + id_tables1;
            if (checkBox2.Checked)
            {
                select += " JOIN " + third_table + " ON " + id_tables2;
            }
            sqlR.unionTables(select, dGV);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBoxField3.Enabled = true;
                comboBoxTable3.Enabled = true;
                checkedListBox3.Enabled = true;
            }
            else
            {
                comboBoxField3.Enabled = false;
                comboBoxTable3.Enabled = false;
                checkedListBox3.Enabled = false;
            }
        }

        private void comboBoxTableEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlR.updateDataGrid(comboBoxTableEdit, dGV, 0);
        }

        private void checkBoxEditTable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEditTable.Checked)
            {
                comboBoxTableEdit.SelectedIndex = 1;
                comboBoxTableEdit.SelectedIndex = 0;
                comboBoxTableEdit.Enabled = true;
                
                buttonAddRecord.Enabled = true;
                buttonDeleteRecord.Enabled = true;
                buttonEditRecord.Enabled = true;
                
                comboBoxTable1.Enabled = false;
                comboBoxTable2.Enabled = false;

                comboBoxField1.Enabled = false;
                comboBoxField2.Enabled = false;

                checkedListBox1.Enabled = false;
                checkedListBox2.Enabled = false;

                checkBox2.Checked = false;
            }
            else
            {
                comboBoxTableEdit.Enabled = false;
                
                buttonAddRecord.Enabled = false;
                buttonDeleteRecord.Enabled = false;
                buttonEditRecord.Enabled = false;

                comboBoxTable1.Enabled = true;
                comboBoxTable2.Enabled = true;
                
                comboBoxField1.Enabled = true;
                comboBoxField2.Enabled = true;
             
                checkedListBox1.Enabled = true;
                checkedListBox2.Enabled = true;
            }
        }
    }
}