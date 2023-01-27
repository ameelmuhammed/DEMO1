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
    public partial class addbrand : Form
    {
        public addbrand()
        {
            InitializeComponent();
        }

        private void addbrand_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet9.brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.sysbizzdemoDataSet9.brand);

        }
        public void display()
        {
            DataTable dt = model.democlass.display("select * from brand");
            dataGridView1.DataSource = dt;
        }
        public void clear()
        {
            txtcode.Text = "";
            txtname.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            model.democlass.InsertUpdate("delete from brand where code='" + txtcode.Text + "'");
            MessageBox.Show("data deleted");
            display();
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcode.Text != "" || txtname.Text != "")
            {
                if (txtcode.Text == "" || txtname.Text == "")
                {
                    model.democlass.InsertUpdate("insert into brand  values('" + txtname.Text + "')");
                    MessageBox.Show("       data saved");
                    display();
                    clear();
                }
                else
                {
                    model.democlass.InsertUpdate("update brand set name='"+txtname.Text+"'where code='"+txtcode.Text+"'");
                    MessageBox.Show("     data updated");
                    display();
                    clear();
                }

            }
            else
            {
                MessageBox.Show("invalid entry");
            }
        }
    }
}
