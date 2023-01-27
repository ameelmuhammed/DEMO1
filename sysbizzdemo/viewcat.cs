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
    public partial class viewcat : Form
    {
        public string c;
        
        public viewcat()
        {
            InitializeComponent();
        }

        private void view_category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet2.view_cat' table. You can move, or remove it, as needed.
            this.view_catTableAdapter.Fill(this.sysbizzdemoDataSet2.view_cat);
            

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            c = textBox1.Text;
            this.Close();
            
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridcate.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
     
    }
}