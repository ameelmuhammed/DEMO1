namespace sysbizzdemo
{
    partial class viewcat
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
            this.dataGridcate = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sysbizzdemoDataSet2 = new sysbizzdemo.sysbizzdemoDataSet2();
            this.view_catTableAdapter = new sysbizzdemo.sysbizzdemoDataSet2TableAdapters.view_catTableAdapter();
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysbizzdemoDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridcate
            // 
            this.dataGridcate.AutoGenerateColumns = false;
            this.dataGridcate.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridcate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridcate.DataSource = this.viewCatBindingSource;
            this.dataGridcate.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridcate.Location = new System.Drawing.Point(12, 36);
            this.dataGridcate.Name = "dataGridcate";
            this.dataGridcate.Size = new System.Drawing.Size(534, 197);
            this.dataGridcate.TabIndex = 4;
            this.dataGridcate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // viewCatBindingSource
            // 
            this.viewCatBindingSource.DataMember = "view cat";
            this.viewCatBindingSource.DataSource = this.sysbizzdemoDataSet2;
            // 
            // sysbizzdemoDataSet2
            // 
            this.sysbizzdemoDataSet2.DataSetName = "sysbizzdemoDataSet2";
            this.sysbizzdemoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_catTableAdapter
            // 
            this.view_catTableAdapter.ClearBeforeFill = true;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(416, 239);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(99, 30);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Code",
            "Name",
            "Mobile Number"});
            this.comboBox1.Location = new System.Drawing.Point(60, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // viewcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 291);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.dataGridcate);
            this.Name = "viewcat";
            this.Text = "view_category";
            this.Load += new System.EventHandler(this.view_category_Load);
            this.MdiChildActivate += new System.EventHandler(this.view_category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysbizzdemoDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridcate;
        private sysbizzdemoDataSet2 sysbizzdemoDataSet2;
        private System.Windows.Forms.BindingSource viewCatBindingSource;
        private sysbizzdemoDataSet2TableAdapters.view_catTableAdapter view_catTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}