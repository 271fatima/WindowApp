namespace WindowsFormsApp5
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.student_dataDataSet = new WindowsFormsApp5.Student_dataDataSet();
            this.studentdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_dataTableAdapter = new WindowsFormsApp5.Student_dataDataSetTableAdapters.student_dataTableAdapter();
            this.stdIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(582, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdIDDataGridViewTextBoxColumn,
            this.stdnameDataGridViewTextBoxColumn,
            this.stdemailDataGridViewTextBoxColumn,
            this.stdnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentdataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 163);
            this.dataGridView1.TabIndex = 2;
            // 
            // student_dataDataSet
            // 
            this.student_dataDataSet.DataSetName = "Student_dataDataSet";
            this.student_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentdataBindingSource
            // 
            this.studentdataBindingSource.DataMember = "student_data";
            this.studentdataBindingSource.DataSource = this.student_dataDataSet;
            // 
            // student_dataTableAdapter
            // 
            this.student_dataTableAdapter.ClearBeforeFill = true;
            // 
            // stdIDDataGridViewTextBoxColumn
            // 
            this.stdIDDataGridViewTextBoxColumn.DataPropertyName = "stdID";
            this.stdIDDataGridViewTextBoxColumn.HeaderText = "stdID";
            this.stdIDDataGridViewTextBoxColumn.Name = "stdIDDataGridViewTextBoxColumn";
            this.stdIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stdnameDataGridViewTextBoxColumn
            // 
            this.stdnameDataGridViewTextBoxColumn.DataPropertyName = "stdname";
            this.stdnameDataGridViewTextBoxColumn.HeaderText = "stdname";
            this.stdnameDataGridViewTextBoxColumn.Name = "stdnameDataGridViewTextBoxColumn";
            // 
            // stdemailDataGridViewTextBoxColumn
            // 
            this.stdemailDataGridViewTextBoxColumn.DataPropertyName = "stdemail";
            this.stdemailDataGridViewTextBoxColumn.HeaderText = "stdemail";
            this.stdemailDataGridViewTextBoxColumn.Name = "stdemailDataGridViewTextBoxColumn";
            // 
            // stdnoDataGridViewTextBoxColumn
            // 
            this.stdnoDataGridViewTextBoxColumn.DataPropertyName = "stdno";
            this.stdnoDataGridViewTextBoxColumn.HeaderText = "stdno";
            this.stdnoDataGridViewTextBoxColumn.Name = "stdnoDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Student_dataDataSet student_dataDataSet;
        private System.Windows.Forms.BindingSource studentdataBindingSource;
        private Student_dataDataSetTableAdapters.student_dataTableAdapter student_dataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdnoDataGridViewTextBoxColumn;
    }
}

