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
    public partial class sales : Form
    {
        string productname, barcode, costprice, type;
        BindingSource source;
        public sales()
        {
            InitializeComponent();    
        }
       
        private void sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet22.sales' table. You can move, or remove it, as needed.
            //this.salesTableAdapter.Fill(this.sysbizzdemoDataSet22.sales);
            source = new BindingSource();
            LoadData();
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet21.sales' table. You can move, or remove it, as needed.
            dataGridView1.Rows.Add();
            increment();
           
            
        }
        private void LoadData()
        {

            DataTable dt = new DataTable();
            dt = model.democlass.display("select productname,barcode,costprice from itemmaster ");
            source.DataSource = dt;
            dataGridView2.DataSource = source;

        }
        public void clear1()
        {
            txtno.Text = "";
            txtcoust.Text = "";
            txtcustadd.Text = "";
            txtadd.Text = "";
            txtmob.Text="";
            txtsalesman.Text = "";
            txtbalance.Text = "";
            txtcash.Text = "";
            grandtotal.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }
        public void gridclear()
        {
                while (dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                }
                                    
        }
        public void add1()
        {
            dataGridView1.CurrentRow.Cells[4].Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value) * Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            grandtotal.Text = sum.ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }

        private void textBox9_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            coustomermaster cm = new coustomermaster();
            cm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                if (e.Control is TextBox)
                {
                    if (dataGridView1.CurrentCell.ColumnIndex == 1)
                    {
                        DataGridViewTextBoxEditingControl txt = e.Control as DataGridViewTextBoxEditingControl;
                        txt.TextChanged += Txt_TextChanged;
                        txt.TextChanged += Txt_TextChanged1;
                        txt.KeyDown += Txt_KeyDown;
                        
                    }
                    else if (dataGridView1.CurrentCell.ColumnIndex == 3)
                    { }
                }
                              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void Txt_TextChanged1(object sender, EventArgs e)
        {
            add1();
        }

        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
        //    if (e.KeyCode == Keys.Down)
        //    {
        //        dataGridView2.Focus();
        //    }
            
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    TextBox t = (TextBox)sender;

                    panel1.Visible = true;

                    
                    source.Filter = string.Format("productname like '%{0}%'", t.Text);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int col = dataGridView1.CurrentCell.ColumnIndex;
                    int row = dataGridView1.CurrentCell.RowIndex;
                    if (col < dataGridView1.ColumnCount - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[row].Cells[col + 1];
                        dataGridView2.Focus();

                    }
                    else if (col == dataGridView1.ColumnCount - 1)
                    {

                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.CurrentCell = dataGridView1.Rows[row + 1].Cells[0];
                            dataGridView2.Focus();
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clear1();
            gridclear();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcoust_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        public void increment()
        {
            
            DataTable dt = new DataTable();
            dt = model.democlass.display("select [sino] from sales");


            if (dt.Rows.Count==0) 
            {
                txtno.Text = "1";
            }
            else
            {
                model.democlass.conn.Open();
                SqlCommand cmd = new SqlCommand("select max([sino])+1 from sales", model.democlass.conn);
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                model.democlass.conn.Close();
                txtno.Text = a.ToString();
            }         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
              
                
            }
               
        }

        private void txtmob_KeyDown(object sender, KeyEventArgs e)
        {
            dataGridView1.Focus();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int startx = 100;
            int starty = 0;
            Pen mypen = new Pen(Color.Black);
            Font myfont = new Font("Arial", 18, FontStyle.Regular);
            Graphics g = e.Graphics;
            Brush b1 = new SolidBrush(Color.Black);


            g.DrawString("SALE INVOICE", myfont, b1, new Point(startx + 295, starty + 80));
            g.DrawString("Coustomer Bill", myfont, b1, new Point(startx + 310, starty + 120));
            g.DrawLine(mypen, 15, 150, 805, 150);
            g.DrawLine(mypen, 15, 154, 805, 154);
            g.DrawString("Si No", myfont, b1, new Point(startx + 30, starty + 170));
            g.DrawString(":", myfont, b1, new Point(startx + 138, starty + 170));
            g.DrawString("Customer:", myfont, b1, new Point(startx + 30, starty + 195));
            g.DrawString("---------------------------------------------------------------------------------------------", myfont, b1, new Point(startx + 15, starty + 220));
            string head = "Item".PadRight(50) + "Qty".PadRight(10) + "Rate".PadRight(25) + "total";
            g.DrawString(head, myfont, b1, new Point(startx + 30, starty + 240));
            g.DrawString("---------------------------------------------------------------------------------------------", myfont, b1, new Point(startx + 15, starty + 260));
            g.DrawString(txtcoust.Text.ToUpper().ToString(), myfont, b1, new Point(startx + 155, starty + 195));
            g.DrawString(txtno.Text.ToString(), myfont, b1, new Point(startx + 155, starty + 170));
         
      
            try
            {
                foreach (DataGridViewRow dgrow in dataGridView1.Rows)
                {

                    string item = dgrow.Cells[1].Value.ToString();
                    string qty = dgrow.Cells[3].Value.ToString();
                    string rate = dgrow.Cells[2].Value.ToString();
                    string total = dgrow.Cells[4].Value.ToString();

                    g.DrawString(item, myfont, b1, new Point(startx + 30, starty + 280));
                    g.DrawString(qty, myfont, b1, new Point(startx + 420, starty + 280));
                    g.DrawString(rate, myfont, b1, new Point(startx + 505, starty + 280));
                    g.DrawString(total, myfont, b1, new Point(startx + 705, starty + 280));
                   

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dataGridView1.Rows.Count >= 2)
            {

                g.DrawString("---------------------------------------------------------------------------------------------", myfont, b1, new Point(startx + 15, starty + 300));
                g.DrawString("---------------------------------------------------------------------------------------------", myfont, b1, new Point(startx + 15, starty + 295));
                g.DrawString("Gross Total:", myfont, b1, new Point(startx + 550, starty + 320));
                g.DrawString(grandtotal.Text.ToString(), myfont, b1, new Point(startx + 700, starty + 320));

            }



        }

        private void button7_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("paper1",810,1000);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void dataGridView1_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                type = "cash";
            }
            else
            {
                type = "credit";
            }
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                model.democlass.InsertUpdate("insert into sales(Code,Itemname,Qty,Price,[sino],coustomer,address,salesman,date,type,amount,mob,grandtotal)values('"+dataGridView1.Rows[i].Cells[0].Value+"','"+dataGridView1.Rows[i].Cells[1].Value+"','"+dataGridView1.Rows[i].Cells[3].Value+"','"+dataGridView1.Rows[i].Cells[2].Value+"','"+txtno.Text+"','"+txtcoust.Text+"','"+txtadd.Text+"','"+txtsalesman.Text+"','"+dateTimePicker1.Text+"','"+type+"','"+dataGridView1.Rows[i].Cells[4].Value+"','"+txtmob.Text+"','"+grandtotal.Text+"')");
              
            }
            MessageBox.Show("data saved");
            clear1();
            gridclear();
            increment();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
        if (Keys.Enter == e.KeyCode)
            {
                if (panel1.Visible == true)
                {
                    productname = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    dataGridView1.CurrentRow.Cells[1].Value = productname.ToString();
                    barcode = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    dataGridView1.CurrentRow.Cells[0].Value = barcode.ToString();
                    costprice = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                    dataGridView1.CurrentRow.Cells[2].Value = costprice.ToString();
                    panel1.Visible = false;
                    dataGridView1.Rows.Add();
                    
                }
            }            
        }
    }
}
