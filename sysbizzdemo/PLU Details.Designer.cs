namespace sysbizzdemo
{
    partial class PLU_Details
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pLUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salespriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemmasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sysbizzdemoDataSet25 = new sysbizzdemo.sysbizzdemoDataSet25();
            this.sysbizzdemoDataSet27 = new sysbizzdemo.sysbizzdemoDataSet27();
            this.button1 = new System.Windows.Forms.Button();
            this.itemmasterTableAdapter = new sysbizzdemo.sysbizzdemoDataSet25TableAdapters.itemmasterTableAdapter();
            this.btnexport = new System.Windows.Forms.Button();
            this.bntbrowser = new System.Windows.Forms.Button();
            this.txtbrowse = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemmasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysbizzdemoDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysbizzdemoDataSet27)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pLUDataGridViewTextBoxColumn,
            this.Itemcode,
            this.salespriceDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemmasterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // pLUDataGridViewTextBoxColumn
            // 
            this.pLUDataGridViewTextBoxColumn.DataPropertyName = "PLU";
            this.pLUDataGridViewTextBoxColumn.HeaderText = "PLU";
            this.pLUDataGridViewTextBoxColumn.Name = "pLUDataGridViewTextBoxColumn";
            // 
            // Itemcode
            // 
            this.Itemcode.DataPropertyName = "Itemcode";
            this.Itemcode.HeaderText = "Itemcode";
            this.Itemcode.Name = "Itemcode";
            // 
            // salespriceDataGridViewTextBoxColumn
            // 
            this.salespriceDataGridViewTextBoxColumn.DataPropertyName = "salesprice";
            this.salespriceDataGridViewTextBoxColumn.HeaderText = "salesprice";
            this.salespriceDataGridViewTextBoxColumn.Name = "salespriceDataGridViewTextBoxColumn";
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "productname";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // itemmasterBindingSource
            // 
            this.itemmasterBindingSource.DataMember = "itemmaster";
            this.itemmasterBindingSource.DataSource = this.sysbizzdemoDataSet25;
            // 
            // sysbizzdemoDataSet25
            // 
            this.sysbizzdemoDataSet25.DataSetName = "sysbizzdemoDataSet25";
            this.sysbizzdemoDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sysbizzdemoDataSet27
            // 
            this.sysbizzdemoDataSet27.DataSetName = "sysbizzdemoDataSet27";
            this.sysbizzdemoDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Location = new System.Drawing.Point(464, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemmasterTableAdapter
            // 
            this.itemmasterTableAdapter.ClearBeforeFill = true;
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.Color.PeachPuff;
            this.btnexport.Location = new System.Drawing.Point(373, 398);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(75, 23);
            this.btnexport.TabIndex = 2;
            this.btnexport.Text = "Export";
            this.btnexport.UseVisualStyleBackColor = false;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // bntbrowser
            // 
            this.bntbrowser.BackColor = System.Drawing.Color.PeachPuff;
            this.bntbrowser.Location = new System.Drawing.Point(57, 397);
            this.bntbrowser.Name = "bntbrowser";
            this.bntbrowser.Size = new System.Drawing.Size(75, 24);
            this.bntbrowser.TabIndex = 3;
            this.bntbrowser.Text = "browser";
            this.bntbrowser.UseVisualStyleBackColor = false;
            this.bntbrowser.Click += new System.EventHandler(this.bntbrowser_Click);
            // 
            // txtbrowse
            // 
            this.txtbrowse.Location = new System.Drawing.Point(138, 400);
            this.txtbrowse.Name = "txtbrowse";
            this.txtbrowse.Size = new System.Drawing.Size(167, 20);
            this.txtbrowse.TabIndex = 4;
            this.txtbrowse.TextChanged += new System.EventHandler(this.txtbrowse_TextChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // PLU_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.txtbrowse);
            this.Controls.Add(this.bntbrowser);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PLU_Details";
            this.Text = "PLU_Details";
            this.Load += new System.EventHandler(this.PLU_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemmasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysbizzdemoDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysbizzdemoDataSet27)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private sysbizzdemoDataSet25 sysbizzdemoDataSet25;
        private System.Windows.Forms.BindingSource itemmasterBindingSource;
        private sysbizzdemoDataSet25TableAdapters.itemmasterTableAdapter itemmasterTableAdapter;
        private sysbizzdemoDataSet27 sysbizzdemoDataSet27;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn salespriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bntbrowser;
        private System.Windows.Forms.TextBox txtbrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}