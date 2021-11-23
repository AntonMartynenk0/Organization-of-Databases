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
                sqlR.getTableNames(comboBoxTableNames);
                comboBoxTableNames.SelectedIndex = 0;
                comboBoxSort.SelectedIndex = 0;
                comboBoxCount.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }

        private void comboBoxTableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCustomRequest.Text = null;
            try
            {
                sqlR.getFields(cbField: comboBoxFieldList, cbFieldInt: comboBoxcomboBoxFieldListCount, comboBoxTableNames, dGV: dGV);
                sqlR.updateDataGrid(comboBoxTableNames, comboBoxFieldList, comboBoxSort, comboBoxcomboBoxFieldListCount, comboBoxCount, dGV, textBoxCustomRequest, textBoxSearch, 0);
            }
            catch (Exception)
            {

            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            sqlR.updateDataGrid(comboBoxTableNames, comboBoxFieldList, comboBoxSort, comboBoxcomboBoxFieldListCount, comboBoxCount, dGV, textBoxCustomRequest, textBoxSearch, 1);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            sqlR.updateDataGrid(comboBoxTableNames, comboBoxFieldList, comboBoxSort, comboBoxcomboBoxFieldListCount, comboBoxCount, dGV, textBoxCustomRequest, textBoxSearch, 2);
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            sqlR.updateDataGrid(comboBoxTableNames, comboBoxFieldList, comboBoxSort, comboBoxcomboBoxFieldListCount, comboBoxCount, dGV, textBoxTitleOfNewHeader, textBoxSearch, 3);
        }

        private void button_custom_request_Click(object sender, EventArgs e)
        {
            sqlR.updateDataGrid(comboBoxTableNames, comboBoxFieldList, comboBoxSort, comboBoxcomboBoxFieldListCount, comboBoxCount, dGV, textBoxCustomRequest, textBoxSearch, 4);
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            sqlR.updateDataGrid(comboBoxTableNames, comboBoxFieldList, comboBoxSort, comboBoxcomboBoxFieldListCount, comboBoxCount, dGV, textBoxCustomRequest, textBoxSearch, 5);
        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            sqlR.updateDataGrid(comboBoxTableNames, comboBoxFieldList, comboBoxSort, comboBoxcomboBoxFieldListCount, comboBoxCount, dGV, textBoxCustomRequest, textBoxSearch, 6);
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            sqlR.updateDataGrid(comboBoxTableNames, comboBoxFieldList, comboBoxSort, comboBoxcomboBoxFieldListCount, comboBoxCount, dGV, textBoxCustomRequest, textBoxSearch, 7);
        }
    }
}
