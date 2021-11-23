
namespace Lab6
{
    partial class form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.dGV = new System.Windows.Forms.DataGridView();
            this.comboBoxTableNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustomRequest = new System.Windows.Forms.TextBox();
            this.button_custom_request = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxFieldList = new System.Windows.Forms.ComboBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.comboBoxcomboBoxFieldListCount = new System.Windows.Forms.ComboBox();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTitleOfNewHeader = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.buttonEditRecord = new System.Windows.Forms.Button();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.AllowUserToOrderColumns = true;
            this.dGV.AllowUserToResizeColumns = false;
            this.dGV.AllowUserToResizeRows = false;
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV.BackgroundColor = System.Drawing.Color.White;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV.Location = new System.Drawing.Point(470, 2);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersVisible = false;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(717, 485);
            this.dGV.TabIndex = 4;
            // 
            // comboBoxTableNames
            // 
            this.comboBoxTableNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableNames.FormattingEnabled = true;
            this.comboBoxTableNames.Location = new System.Drawing.Point(127, 12);
            this.comboBoxTableNames.Name = "comboBoxTableNames";
            this.comboBoxTableNames.Size = new System.Drawing.Size(331, 28);
            this.comboBoxTableNames.TabIndex = 5;
            this.comboBoxTableNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose table";
            // 
            // textBoxCustomRequest
            // 
            this.textBoxCustomRequest.Location = new System.Drawing.Point(6, 25);
            this.textBoxCustomRequest.Multiline = true;
            this.textBoxCustomRequest.Name = "textBoxCustomRequest";
            this.textBoxCustomRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCustomRequest.Size = new System.Drawing.Size(211, 89);
            this.textBoxCustomRequest.TabIndex = 7;
            // 
            // button_custom_request
            // 
            this.button_custom_request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_custom_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_custom_request.Location = new System.Drawing.Point(10, 120);
            this.button_custom_request.Name = "button_custom_request";
            this.button_custom_request.Size = new System.Drawing.Size(207, 28);
            this.button_custom_request.TabIndex = 9;
            this.button_custom_request.Text = "Show Result";
            this.button_custom_request.UseVisualStyleBackColor = false;
            this.button_custom_request.Click += new System.EventHandler(this.button_custom_request_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 60);
            this.label4.TabIndex = 11;
            this.label4.Text = "1. Pick field where \r\nyou whant to find\r\n2. Input text below";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBoxSort.Location = new System.Drawing.Point(6, 85);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(211, 28);
            this.comboBoxSort.TabIndex = 13;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(6, 85);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSearch.Size = new System.Drawing.Size(211, 54);
            this.textBoxSearch.TabIndex = 14;
            // 
            // comboBoxFieldList
            // 
            this.comboBoxFieldList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFieldList.FormattingEnabled = true;
            this.comboBoxFieldList.Items.AddRange(new object[] {
            ""});
            this.comboBoxFieldList.Location = new System.Drawing.Point(127, 46);
            this.comboBoxFieldList.Name = "comboBoxFieldList";
            this.comboBoxFieldList.Size = new System.Drawing.Size(331, 28);
            this.comboBoxFieldList.TabIndex = 15;
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Location = new System.Drawing.Point(6, 119);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(211, 28);
            this.buttonSort.TabIndex = 16;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // comboBoxcomboBoxFieldListCount
            // 
            this.comboBoxcomboBoxFieldListCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcomboBoxFieldListCount.FormattingEnabled = true;
            this.comboBoxcomboBoxFieldListCount.Items.AddRange(new object[] {
            ""});
            this.comboBoxcomboBoxFieldListCount.Location = new System.Drawing.Point(66, 59);
            this.comboBoxcomboBoxFieldListCount.Name = "comboBoxcomboBoxFieldListCount";
            this.comboBoxcomboBoxFieldListCount.Size = new System.Drawing.Size(151, 28);
            this.comboBoxcomboBoxFieldListCount.TabIndex = 18;
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Items.AddRange(new object[] {
            "MIN",
            "MAX",
            "AVG",
            "SUM"});
            this.comboBoxCount.Location = new System.Drawing.Point(66, 25);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(151, 28);
            this.comboBoxCount.TabIndex = 17;
            // 
            // buttonCount
            // 
            this.buttonCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCount.Location = new System.Drawing.Point(6, 145);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(211, 28);
            this.buttonCount.TabIndex = 19;
            this.buttonCount.Text = "Count";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(6, 145);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(211, 28);
            this.buttonSearch.TabIndex = 20;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Choose field";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTitleOfNewHeader);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxcomboBoxFieldListCount);
            this.groupBox1.Controls.Add(this.comboBoxCount);
            this.groupBox1.Controls.Add(this.buttonCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 179);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Counting";
            // 
            // textBoxTitleOfNewHeader
            // 
            this.textBoxTitleOfNewHeader.Location = new System.Drawing.Point(66, 93);
            this.textBoxTitleOfNewHeader.Multiline = true;
            this.textBoxTitleOfNewHeader.Name = "textBoxTitleOfNewHeader";
            this.textBoxTitleOfNewHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTitleOfNewHeader.Size = new System.Drawing.Size(151, 46);
            this.textBoxTitleOfNewHeader.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Field";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Action";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Location = new System.Drawing.Point(241, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 179);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboBoxSort);
            this.groupBox3.Controls.Add(this.buttonSort);
            this.groupBox3.Location = new System.Drawing.Point(12, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 154);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 60);
            this.label9.TabIndex = 17;
            this.label9.Text = "1. Pick field where \r\nyou whant to find\r\n2. Input text below";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxCustomRequest);
            this.groupBox4.Controls.Add(this.button_custom_request);
            this.groupBox4.Location = new System.Drawing.Point(241, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 154);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Special SQL request";
            // 
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteRecord.Location = new System.Drawing.Point(316, 425);
            this.buttonDeleteRecord.Name = "buttonDeleteRecord";
            this.buttonDeleteRecord.Size = new System.Drawing.Size(148, 62);
            this.buttonDeleteRecord.TabIndex = 22;
            this.buttonDeleteRecord.Text = "Delete";
            this.buttonDeleteRecord.UseVisualStyleBackColor = false;
            this.buttonDeleteRecord.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
            // 
            // buttonEditRecord
            // 
            this.buttonEditRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonEditRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditRecord.Location = new System.Drawing.Point(12, 425);
            this.buttonEditRecord.Name = "buttonEditRecord";
            this.buttonEditRecord.Size = new System.Drawing.Size(148, 62);
            this.buttonEditRecord.TabIndex = 21;
            this.buttonEditRecord.Text = "Edit";
            this.buttonEditRecord.UseVisualStyleBackColor = false;
            this.buttonEditRecord.Click += new System.EventHandler(this.buttonEditRecord_Click);
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRecord.Location = new System.Drawing.Point(158, 425);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(160, 62);
            this.buttonAddRecord.TabIndex = 20;
            this.buttonAddRecord.Text = "Add";
            this.buttonAddRecord.UseVisualStyleBackColor = false;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 504);
            this.Controls.Add(this.buttonDeleteRecord);
            this.Controls.Add(this.buttonEditRecord);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxFieldList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTableNames);
            this.Controls.Add(this.dGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Base Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTableNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCustomRequest;
        private System.Windows.Forms.Button button_custom_request;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxFieldList;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox comboBoxcomboBoxFieldListCount;
        private System.Windows.Forms.ComboBox comboBoxCount;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTitleOfNewHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.Button buttonEditRecord;
        private System.Windows.Forms.Button buttonAddRecord;
        public System.Windows.Forms.DataGridView dGV;
    }
}

