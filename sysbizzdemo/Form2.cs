using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysbizzdemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sysbizzdemoDataSet10);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet1.itemmaster' table. You can move, or remove it, as needed.
            this.itemmasterTableAdapter.Fill(this.sysbizzdemoDataSet1.itemmaster);
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet10.group' table. You can move, or remove it, as needed.
            this.groupTableAdapter.Fill(this.sysbizzdemoDataSet10.group);

        }
    }
}
