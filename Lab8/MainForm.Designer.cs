
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
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.buttonEditRecord = new System.Windows.Forms.Button();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUnion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxField2 = new System.Windows.Forms.ComboBox();
            this.comboBoxTable2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTable1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxField1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTableEdit = new System.Windows.Forms.ComboBox();
            this.checkBoxEditTable = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTable3 = new System.Windows.Forms.ComboBox();
            this.comboBoxField3 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dGV.Size = new System.Drawing.Size(717, 691);
            this.dGV.TabIndex = 4;
            // 
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDeleteRecord.Enabled = false;
            this.buttonDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteRecord.Location = new System.Drawing.Point(310, 631);
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
            this.buttonEditRecord.Enabled = false;
            this.buttonEditRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditRecord.Location = new System.Drawing.Point(16, 631);
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
            this.buttonAddRecord.Enabled = false;
            this.buttonAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRecord.Location = new System.Drawing.Point(163, 631);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(148, 62);
            this.buttonAddRecord.TabIndex = 20;
            this.buttonAddRecord.Text = "Add";
            this.buttonAddRecord.UseVisualStyleBackColor = false;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox3);
            this.groupBox1.Controls.Add(this.checkedListBox2);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.buttonUnion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxField3);
            this.groupBox1.Controls.Add(this.comboBoxTable3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxField1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxField2);
            this.groupBox1.Controls.Add(this.comboBoxTable1);
            this.groupBox1.Controls.Add(this.comboBoxTable2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 579);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Union tables";
            // 
            // buttonUnion
            // 
            this.buttonUnion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonUnion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUnion.Location = new System.Drawing.Point(6, 523);
            this.buttonUnion.Name = "buttonUnion";
            this.buttonUnion.Size = new System.Drawing.Size(434, 50);
            this.buttonUnion.TabIndex = 24;
            this.buttonUnion.Text = "Union";
            this.buttonUnion.UseVisualStyleBackColor = false;
            this.buttonUnion.Click += new System.EventHandler(this.buttonUnion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Choose key";
            // 
            // comboBoxField2
            // 
            this.comboBoxField2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxField2.FormattingEnabled = true;
            this.comboBoxField2.Items.AddRange(new object[] {
            ""});
            this.comboBoxField2.Location = new System.Drawing.Point(154, 224);
            this.comboBoxField2.Name = "comboBoxField2";
            this.comboBoxField2.Size = new System.Drawing.Size(286, 28);
            this.comboBoxField2.TabIndex = 24;
            // 
            // comboBoxTable2
            // 
            this.comboBoxTable2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTable2.FormattingEnabled = true;
            this.comboBoxTable2.Location = new System.Drawing.Point(154, 190);
            this.comboBoxTable2.Name = "comboBoxTable2";
            this.comboBoxTable2.Size = new System.Drawing.Size(286, 28);
            this.comboBoxTable2.TabIndex = 22;
            this.comboBoxTable2.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableNames_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Choose table 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(32, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Choose key";
            // 
            // comboBoxTable1
            // 
            this.comboBoxTable1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTable1.FormattingEnabled = true;
            this.comboBoxTable1.Location = new System.Drawing.Point(154, 28);
            this.comboBoxTable1.Name = "comboBoxTable1";
            this.comboBoxTable1.Size = new System.Drawing.Size(286, 28);
            this.comboBoxTable1.TabIndex = 5;
            this.comboBoxTable1.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose table 1";
            // 
            // comboBoxField1
            // 
            this.comboBoxField1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxField1.FormattingEnabled = true;
            this.comboBoxField1.Items.AddRange(new object[] {
            ""});
            this.comboBoxField1.Location = new System.Drawing.Point(154, 62);
            this.comboBoxField1.Name = "comboBoxField1";
            this.comboBoxField1.Size = new System.Drawing.Size(286, 28);
            this.comboBoxField1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Edit Table";
            // 
            // comboBoxTableEdit
            // 
            this.comboBoxTableEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableEdit.Enabled = false;
            this.comboBoxTableEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTableEdit.FormattingEnabled = true;
            this.comboBoxTableEdit.Location = new System.Drawing.Point(127, 597);
            this.comboBoxTableEdit.Name = "comboBoxTableEdit";
            this.comboBoxTableEdit.Size = new System.Drawing.Size(322, 28);
            this.comboBoxTableEdit.TabIndex = 26;
            this.comboBoxTableEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableEdit_SelectedIndexChanged);
            // 
            // checkBoxEditTable
            // 
            this.checkBoxEditTable.AutoSize = true;
            this.checkBoxEditTable.Location = new System.Drawing.Point(20, 604);
            this.checkBoxEditTable.Name = "checkBoxEditTable";
            this.checkBoxEditTable.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEditTable.TabIndex = 28;
            this.checkBoxEditTable.UseVisualStyleBackColor = true;
            this.checkBoxEditTable.CheckedChanged += new System.EventHandler(this.checkBoxEditTable_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(154, 96);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(286, 88);
            this.checkedListBox1.TabIndex = 29;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(154, 258);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(286, 88);
            this.checkedListBox2.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(32, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Choose key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(32, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Choose table 3";
            // 
            // comboBoxTable3
            // 
            this.comboBoxTable3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTable3.Enabled = false;
            this.comboBoxTable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTable3.FormattingEnabled = true;
            this.comboBoxTable3.Location = new System.Drawing.Point(154, 352);
            this.comboBoxTable3.Name = "comboBoxTable3";
            this.comboBoxTable3.Size = new System.Drawing.Size(286, 28);
            this.comboBoxTable3.TabIndex = 27;
            this.comboBoxTable3.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableNames_SelectedIndexChanged);
            // 
            // comboBoxField3
            // 
            this.comboBoxField3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxField3.Enabled = false;
            this.comboBoxField3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxField3.FormattingEnabled = true;
            this.comboBoxField3.Items.AddRange(new object[] {
            ""});
            this.comboBoxField3.Location = new System.Drawing.Point(154, 386);
            this.comboBoxField3.Name = "comboBoxField3";
            this.comboBoxField3.Size = new System.Drawing.Size(286, 28);
            this.comboBoxField3.TabIndex = 29;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(11, 358);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.Enabled = false;
            this.checkedListBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(154, 420);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(286, 88);
            this.checkedListBox3.TabIndex = 33;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 705);
            this.Controls.Add(this.checkBoxEditTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTableEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDeleteRecord);
            this.Controls.Add(this.buttonEditRecord);
            this.Controls.Add(this.buttonAddRecord);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.Button buttonEditRecord;
        private System.Windows.Forms.Button buttonAddRecord;
        public System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxField2;
        private System.Windows.Forms.ComboBox comboBoxTable2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxField1;
        private System.Windows.Forms.Button buttonUnion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTableEdit;
        private System.Windows.Forms.CheckBox checkBoxEditTable;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxField3;
        private System.Windows.Forms.ComboBox comboBoxTable3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
    }
}

