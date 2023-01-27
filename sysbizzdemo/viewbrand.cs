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
    
    public partial class viewbrand : Form
    {
        public string c;
        
        public viewbrand()
        {
            InitializeComponent();
        }

        private void viewbrand_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet8.brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.sysbizzdemoDataSet8.brand);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = textBox1.Text;
            this.Close();
        }
    }
}
