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
    
    public partial class addgroup : Form
    {
        int id;
        public addgroup()
        {
            InitializeComponent();
        }

        private void addgroup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet14.group' table. You can move, or remove it, as needed.
            this.groupTableAdapter.Fill(this.sysbizzdemoDataSet14.group);



        }
        public void clear()
        {
            txtcode.Text = "";
            txtname.Text = "";
        }
        public void display()
        {
            DataTable dt = model.democlass.display("select * from [group]");
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcode.Text != "" || txtname.Text != "")
            {
                if (txtcode.Text == "" || txtname.Text == "")
                {
                    model.democlass.InsertUpdate("insert into [group] values('" + txtname.Text + "')");
                    MessageBox.Show("data saved");
                    display();
                    clear();

                }
                else
                {
                    model.democlass.InsertUpdate("update [group] set name='" + txtname.Text + "' where  si = '" + id + "'");
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

        private void button3_Click(object sender, EventArgs e)
        {
            model.democlass.InsertUpdate("delete from [group] where si='" +id+ "'");
            MessageBox.Show("data deleted");
            display();
            clear();
        }

      

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtcode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
