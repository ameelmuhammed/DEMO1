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
    public partial class addcat : Form
    {
        int id;
        public addcat()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcode.Text != "" || txtname.Text != "")
            {
                if (txtcode.Text == "")
                {
                    model.democlass.InsertUpdate("insert into [view cat] values('" + txtname.Text + "')");
                    MessageBox.Show("data saved");
                    display();
                    clear();
                }
                else
                {
                    model.democlass.InsertUpdate("update [view cat] set name='" + txtname.Text + "'where code='" + txtcode.Text + "'");
                    MessageBox.Show("data updated");
                    display();
                    clear();
                }

            }
            else
            {
                MessageBox.Show("invalid entry");
                
            }
        }
        public void display()
        {
            DataTable dt = model.democlass.display("select * from [view cat]");
            dataGridView1.DataSource = dt;
           

        }
        public void clear()
        {
            txtname.Text = "";
            txtcode.Text = "";
        }
        private void addcat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet3.view_cat' table. You can move, or remove it, as needed.
            this.view_catTableAdapter.Fill(this.sysbizzdemoDataSet3.view_cat);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            model.democlass.InsertUpdate("delete from [view cat] where code='"+txtcode.Text+"'");
            MessageBox.Show("data deleted");
            display();
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
