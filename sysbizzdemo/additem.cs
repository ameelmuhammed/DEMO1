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
    public partial class additem : Form
    {
        public additem()
        {
            InitializeComponent();
        }

        private void additem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet5.viewitem' table. You can move, or remove it, as needed.
            this.viewitemTableAdapter.Fill(this.sysbizzdemoDataSet5.viewitem);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void display()
        {
            DataTable dt = model.democlass.display("select * from viewitem ");
            dataGridView1.DataSource = dt;
           
            
        }
        public void clear()
        {
            txtcode.Text = "";
            txtname.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            model.democlass.InsertUpdate("delete from viewitem where code='"+txtcode.Text+"'");
            MessageBox.Show("data deleted");
            clear();
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcode.Text != "" || txtname.Text != "")
            {
                if (txtcode.Text == "" || txtname.Text == "")
                {
                    model.democlass.InsertUpdate("insert into viewitem values('" + txtname.Text + "')");
                    MessageBox.Show("data saved");
                    display();
                    clear();
                }
                else
                {
                    model.democlass.InsertUpdate("update  viewitem set name='"+txtname.Text+"'where code='" + txtcode.Text + "'");
                    MessageBox.Show("data updated");
                    clear();
                    display();
                }

            }
            else
            {
                MessageBox.Show("invalid entry");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
