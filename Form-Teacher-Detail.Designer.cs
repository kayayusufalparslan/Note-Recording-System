namespace Note_Recording_System
{
    partial class Form_Teacher_Detail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextSurname = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.MaskedTextBox();
            this.MaskNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TextExam3 = new System.Windows.Forms.MaskedTextBox();
            this.TextExam2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextExam1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblFailed = new System.Windows.Forms.Label();
            this.LblPassed = new System.Windows.Forms.Label();
            this.LblAverage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbRecordNotesDataSet = new Note_Recording_System.DbRecordNotesDataSet();
            this.lESSONTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lESSONTABLETableAdapter = new Note_Recording_System.DbRecordNotesDataSetTableAdapters.LESSONTABLETableAdapter();
            this.sTDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDLASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDEXAM1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDEXAM2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDEXAM3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVERAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRecordNotesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lESSONTABLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TextSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextName);
            this.groupBox1.Controls.Add(this.MaskNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextSurname
            // 
            this.TextSurname.Location = new System.Drawing.Point(84, 108);
            this.TextSurname.Name = "TextSurname";
            this.TextSurname.Size = new System.Drawing.Size(100, 26);
            this.TextSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(84, 76);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(100, 26);
            this.TextName.TabIndex = 2;
            // 
            // MaskNumber
            // 
            this.MaskNumber.Location = new System.Drawing.Point(84, 44);
            this.MaskNumber.Mask = "0000";
            this.MaskNumber.Name = "MaskNumber";
            this.MaskNumber.Size = new System.Drawing.Size(100, 26);
            this.MaskNumber.TabIndex = 1;
            this.MaskNumber.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TextExam3);
            this.groupBox2.Controls.Add(this.TextExam2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TextExam1);
            this.groupBox2.Location = new System.Drawing.Point(236, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 225);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exam Notes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Exam 3:";
            // 
            // TextExam3
            // 
            this.TextExam3.Location = new System.Drawing.Point(82, 108);
            this.TextExam3.Name = "TextExam3";
            this.TextExam3.Size = new System.Drawing.Size(100, 26);
            this.TextExam3.TabIndex = 6;
            // 
            // TextExam2
            // 
            this.TextExam2.Location = new System.Drawing.Point(82, 76);
            this.TextExam2.Name = "TextExam2";
            this.TextExam2.Size = new System.Drawing.Size(100, 26);
            this.TextExam2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Exam 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Exam 1:";
            // 
            // TextExam1
            // 
            this.TextExam1.Location = new System.Drawing.Point(82, 44);
            this.TextExam1.Name = "TextExam1";
            this.TextExam1.Size = new System.Drawing.Size(100, 26);
            this.TextExam1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblFailed);
            this.groupBox3.Controls.Add(this.LblPassed);
            this.groupBox3.Controls.Add(this.LblAverage);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(442, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 225);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exam Notes";
            // 
            // LblFailed
            // 
            this.LblFailed.AutoSize = true;
            this.LblFailed.Location = new System.Drawing.Point(82, 111);
            this.LblFailed.Name = "LblFailed";
            this.LblFailed.Size = new System.Drawing.Size(28, 18);
            this.LblFailed.TabIndex = 10;
            this.LblFailed.Text = "00";
            // 
            // LblPassed
            // 
            this.LblPassed.AutoSize = true;
            this.LblPassed.Location = new System.Drawing.Point(82, 79);
            this.LblPassed.Name = "LblPassed";
            this.LblPassed.Size = new System.Drawing.Size(28, 18);
            this.LblPassed.TabIndex = 9;
            this.LblPassed.Text = "00";
            // 
            // LblAverage
            // 
            this.LblAverage.AutoSize = true;
            this.LblAverage.Location = new System.Drawing.Point(82, 47);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(28, 18);
            this.LblAverage.TabIndex = 8;
            this.LblAverage.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Failed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Passed:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Average:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(784, 248);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTDIDDataGridViewTextBoxColumn,
            this.sTDNODataGridViewTextBoxColumn,
            this.sTDNAMEDataGridViewTextBoxColumn,
            this.sTDLASTNAMEDataGridViewTextBoxColumn,
            this.sTDEXAM1DataGridViewTextBoxColumn,
            this.sTDEXAM2DataGridViewTextBoxColumn,
            this.sTDEXAM3DataGridViewTextBoxColumn,
            this.aVERAGEDataGridViewTextBoxColumn,
            this.sTATEDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.lESSONTABLEBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 223);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dbRecordNotesDataSet
            // 
            this.dbRecordNotesDataSet.DataSetName = "DbRecordNotesDataSet";
            this.dbRecordNotesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lESSONTABLEBindingSource
            // 
            this.lESSONTABLEBindingSource.DataMember = "LESSONTABLE";
            this.lESSONTABLEBindingSource.DataSource = this.dbRecordNotesDataSet;
            // 
            // lESSONTABLETableAdapter
            // 
            this.lESSONTABLETableAdapter.ClearBeforeFill = true;
            // 
            // sTDIDDataGridViewTextBoxColumn
            // 
            this.sTDIDDataGridViewTextBoxColumn.DataPropertyName = "STDID";
            this.sTDIDDataGridViewTextBoxColumn.HeaderText = "STDID";
            this.sTDIDDataGridViewTextBoxColumn.Name = "sTDIDDataGridViewTextBoxColumn";
            this.sTDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTDNODataGridViewTextBoxColumn
            // 
            this.sTDNODataGridViewTextBoxColumn.DataPropertyName = "STDNO";
            this.sTDNODataGridViewTextBoxColumn.HeaderText = "STDNO";
            this.sTDNODataGridViewTextBoxColumn.Name = "sTDNODataGridViewTextBoxColumn";
            // 
            // sTDNAMEDataGridViewTextBoxColumn
            // 
            this.sTDNAMEDataGridViewTextBoxColumn.DataPropertyName = "STDNAME";
            this.sTDNAMEDataGridViewTextBoxColumn.HeaderText = "STDNAME";
            this.sTDNAMEDataGridViewTextBoxColumn.Name = "sTDNAMEDataGridViewTextBoxColumn";
            // 
            // sTDLASTNAMEDataGridViewTextBoxColumn
            // 
            this.sTDLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "STDLASTNAME";
            this.sTDLASTNAMEDataGridViewTextBoxColumn.HeaderText = "STDLASTNAME";
            this.sTDLASTNAMEDataGridViewTextBoxColumn.Name = "sTDLASTNAMEDataGridViewTextBoxColumn";
            // 
            // sTDEXAM1DataGridViewTextBoxColumn
            // 
            this.sTDEXAM1DataGridViewTextBoxColumn.DataPropertyName = "STDEXAM1";
            this.sTDEXAM1DataGridViewTextBoxColumn.HeaderText = "STDEXAM1";
            this.sTDEXAM1DataGridViewTextBoxColumn.Name = "sTDEXAM1DataGridViewTextBoxColumn";
            // 
            // sTDEXAM2DataGridViewTextBoxColumn
            // 
            this.sTDEXAM2DataGridViewTextBoxColumn.DataPropertyName = "STDEXAM2";
            this.sTDEXAM2DataGridViewTextBoxColumn.HeaderText = "STDEXAM2";
            this.sTDEXAM2DataGridViewTextBoxColumn.Name = "sTDEXAM2DataGridViewTextBoxColumn";
            // 
            // sTDEXAM3DataGridViewTextBoxColumn
            // 
            this.sTDEXAM3DataGridViewTextBoxColumn.DataPropertyName = "STDEXAM3";
            this.sTDEXAM3DataGridViewTextBoxColumn.HeaderText = "STDEXAM3";
            this.sTDEXAM3DataGridViewTextBoxColumn.Name = "sTDEXAM3DataGridViewTextBoxColumn";
            // 
            // aVERAGEDataGridViewTextBoxColumn
            // 
            this.aVERAGEDataGridViewTextBoxColumn.DataPropertyName = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.HeaderText = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.Name = "aVERAGEDataGridViewTextBoxColumn";
            // 
            // sTATEDataGridViewCheckBoxColumn
            // 
            this.sTATEDataGridViewCheckBoxColumn.DataPropertyName = "STATE";
            this.sTATEDataGridViewCheckBoxColumn.HeaderText = "STATE";
            this.sTATEDataGridViewCheckBoxColumn.Name = "sTATEDataGridViewCheckBoxColumn";
            // 
            // Form_Teacher_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(808, 503);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Teacher_Detail";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_Teacher_Detail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRecordNotesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lESSONTABLEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox TextSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TextName;
        private System.Windows.Forms.MaskedTextBox MaskNumber;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TextExam3;
        private System.Windows.Forms.MaskedTextBox TextExam2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TextExam1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblFailed;
        private System.Windows.Forms.Label LblPassed;
        private System.Windows.Forms.Label LblAverage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbRecordNotesDataSet dbRecordNotesDataSet;
        private System.Windows.Forms.BindingSource lESSONTABLEBindingSource;
        private DbRecordNotesDataSetTableAdapters.LESSONTABLETableAdapter lESSONTABLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDLASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDEXAM1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDEXAM2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDEXAM3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sTATEDataGridViewCheckBoxColumn;
    }
}