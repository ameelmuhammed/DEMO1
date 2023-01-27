using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace sysbizzdemo
{
    public partial class coustomermaster : Form
    {
        public coustomermaster()
        {
            InitializeComponent();
        }
        int id;
        public void display()
        {
            DataTable dt = model.democlass.display("select * from coustomerdetails");
            dataGridView1.DataSource = dt;
        }
        public void clear()
        {
            txtcode.Text = "";
            txtname.Text = "";
            txtaddr.Text = "";
            txtmobile.Text = "";
            txtemail.Text = "";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void coustomermaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet19.coustomerdetails' table. You can move, or remove it, as needed.
            this.coustomerdetailsTableAdapter.Fill(this.sysbizzdemoDataSet19.coustomerdetails);

        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.democlass.InsertUpdate("insert into coustomerdetails values('"+txtcode.Text+"','"+txtname.Text+"','"+txtaddr.Text+"','"+txtmobile.Text+"','"+txtemail.Text+"')");
            MessageBox.Show("data saved");
            display();
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtcode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtaddr.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtmobile.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            model.democlass.InsertUpdate("delete from coustomerdetails where sino='"+id+"'");
            display();
            clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
