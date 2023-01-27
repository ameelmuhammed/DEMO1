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
    public partial class Form1 : Form
    {
        public static SqlCommand cmd = new SqlCommand();
        
        int id;
        public Form1()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtbarcode.Text = "";
            txtname.Text = "";
            txtdes.Text = "";
            txtcat.Text = "";
            txtitem.Text = "";
            txtgroup.Text = "";
            txtbrand.Text = "";
            txthsn.Text = "";
            txtcost.Text = "";
            txtmrp.Text = "";
            txtsales.Text = "";
            txtwholsale.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txtplu.Text = "";
            comboUnit.Text = "";
            txtcode.Text = "";
            
        }
        public void gtvalue()
        {
            DataTable dt = model.democlass.display("select barcode from itemmaster ");
            if (dt.Rows.Count < 1)
            {
                txtbarcode.Text = "1";
            }
            else
            {
                
                string query=  " select concat(p.prifix, max(convert(decimal, SUBSTRING(barcode, LEN(p.prifix) + 1, LEN(barcode)))) + 1) from itemmaster";
                query += " join prefix p on substring(itemmaster.barcode, 0, 3) = p.prifix  where p.value='"+comboBox1.Text+"'";
                query+=  " group by p.prifix; ";
                model.democlass.conn.Open();
                SqlCommand cmd = new SqlCommand(query, model.democlass.conn);
                string a = Convert.ToString(cmd.ExecuteScalar());
                model.democlass.conn.Close();
                
                txtbarcode.Text = a.ToString();
            }
        }
        private void item_master_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet26.itemmaster' table. You can move, or remove it, as needed.
            this.itemmasterTableAdapter4.Fill(this.sysbizzdemoDataSet26.itemmaster);
            // TODO: This line of code loads data into the 'sysbizzdemoDataSet24.itemmaster' table. You can move, or remove it, as needed.
            this.itemmasterTableAdapter3.Fill(this.sysbizzdemoDataSet24.itemmaster);


            combo();
            gtvalue();
        }
        private void label19_Click(object sender, EventArgs e)
        {

        }
        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
       {
            model.democlass.down(e);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //viewbrand();
        }
        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txthsn.Text == "" || txtcost.Text == "" || txtmrp.Text == "" || txtsales.Text == "" || txtwholsale.Text == "")
            {
                MessageBox.Show("invalid entry");
            }
            else
            {
               
                Dictionary<string, object> parameter = new Dictionary<string, object>();
                string query= " if not exists(select * from itemmaster where Itemcode = '"+txtcode.Text+"')";
                       query +=" insert into itemmaster values('" + txtbarcode.Text + "','" + txtname.Text + "','" + txtdes.Text + "','" + txtcat.Text + "','" + txtitem.Text + "','" + txtgroup.Text + "','" + txtbrand.Text + "','" + txthsn.Text + "','" + txtcost.Text + "','" + txtmrp.Text + "','" + txtsales.Text + "','" + txtwholsale.Text + "','"+txtplu.Text+"','"+comboUnit.Text+"','"+txtcode.Text+"')";

                model.democlass.InsertUpdate(query);
                MessageBox.Show("data saved");
                clear();
                gtvalue();
                display();
            }
        
            
        }
      
        private void button14_Click(object sender, EventArgs e)
        {
            clear();
            gtvalue();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            model.democlass.InsertUpdate("delete from itemmaster where sino='" + id + "' ");
            MessageBox.Show("data delete");

            display();
            clear();
        }
        private void button16_Click(object sender, EventArgs e)
        {

        }
        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {
            string final;
            string last="";
            DataTable dt;
            if (txtbarcode.TextLength == 14)
            {
                string itemvalue = txtbarcode.Text.Substring(0, 9);
                char[] mychar = itemvalue.ToCharArray();
                char[] result = new char[mychar.Length];
                for (int i = 0, j = itemvalue.Length - 1; i < itemvalue.Length; i++, j--)
                {
                    result[i] = mychar[j];
                    final = result[i].ToString();
                    last = final + last;
                    dt = model.democlass.display("select * from itemmaster where Itemcode = '" + last + "'");
                    if (dt.Rows.Count > 0)
                    {
                       txtname.Text = dt.Rows[0]["productname"].ToString();
                       //break;
                    }
                }
                Double qtyvalue =Convert.ToDouble(txtbarcode.Text.Substring(txtbarcode.Text.Length-5,5));
                dt = model.democlass.display("select * from itemmaster where Unit = '" + qtyvalue + "'");
                if (dt.Rows.Count > 0)
                {
                    txtmrp.Text = dt.Rows[0]["Unit"].ToString();
                    //break;
                }

            }
        }
        private void txtcat_TextChanged(object sender, EventArgs e)
        {
            //viewcat();

        }
        private void txtgroup_TextChanged(object sender, EventArgs e)
        {
            //viewgrp();
        }
        private void txtitem_TextChanged(object sender, EventArgs e)
        {
            //viewitem();
        }
        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtcost_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtsales_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtmrp_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtmrp_KeyDown(object sender, KeyEventArgs e)
        {
            model.democlass.down(e);
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtbarcode.Text = (dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtname.Text = (dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtdes.Text = (dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtcat.Text = (dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtitem.Text = (dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString());
            txtgroup.Text = (dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString());
            txtbrand.Text = (dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString());
            txthsn.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtcost.Text = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtmrp.Text = dataGridView2.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtsales.Text = dataGridView2.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtwholsale.Text = dataGridView2.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtplu.Text = dataGridView2.Rows[e.RowIndex].Cells[13].Value.ToString();
            comboUnit.Text = dataGridView2.Rows[e.RowIndex].Cells[14].Value.ToString();
            txtcode.Text = dataGridView2.Rows[e.RowIndex].Cells[15].Value.ToString();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlstr = "update itemmaster set barcode='" + txtbarcode.Text + "',productname='" + txtname.Text + "',description='" + txtdes.Text + "',category='" + txtcat.Text + "',item='" + txtitem.Text + "',grp='" + txtgroup.Text + "',brand='" + txtbrand.Text + "',hsncode='" + txthsn.Text + "',costprice='" + txtcost.Text + "',mrp='" + txtmrp.Text + "',salesprice='" + txtsales.Text + "',wholsale='" + txtwholsale.Text + "',PLU='"+txtplu.Text+"',Unit='"+comboUnit.Text+"',Itemcode='"+txtcode.Text+"' where sino='" + id + "'";
                model.democlass.InsertUpdate(sqlstr);
                MessageBox.Show("data updated");
                display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void display()
        {

            DataTable dt = model.democlass.display("select * from itemmaster ");
            dataGridView2.DataSource = dt;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            viewcat();
        }
        public void viewcat()
        {
            viewcat v1 = new viewcat();
            DialogResult dr = v1.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                txt1.Text = v1.c;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            addcat a1 = new addcat();
            a1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //viewitem();
        }
        public void viewitem()
        {
            viewitem v2 = new viewitem();
            DialogResult dr = v2.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                txt2.Text = v2.c;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            additem a2 = new additem();
            a2.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //    viewgrp();
        }
    public void viewgrp()
        {
            viewgroup v3 = new viewgroup();
            DialogResult dr = v3.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                txt3.Text = v3.c;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            addgroup a3 = new addgroup();
            a3.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //viewbrand();
        }
        public void viewbrand() {
            viewbrand v4 = new viewbrand();
            DialogResult dr = v4.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                txt4.Text = v4.c;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            addbrand a4 = new addbrand();
            a4.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gtvalue();
        }
        public void combo()
        {
            DataTable dt = model.democlass.display("select * from [group]");
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "name";
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            PLU_Details plu = new PLU_Details();
            plu.Show();
        }
    }   
}
