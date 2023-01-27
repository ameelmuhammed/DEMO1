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
using System.IO;

namespace sysbizzdemo
{
    public partial class PLU_Details : Form
    {
        
       
        public PLU_Details()
        {
            InitializeComponent();
        }
        public int code;
        private void PLU_Details_Load(object sender, EventArgs e)
        {


            //while (r.Read())
            DataTable dt;
            dt = model.democlass.display("SELECT PLU,Itemcode,salesprice,barcode,Unit,productname from itemmaster where PLU != ''");
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                model.democlass.InsertUpdate("update itemmaster set  salesprice='" + dataGridView1.Rows[i].Cells[2].Value + "' where Itemcode='" + dataGridView1.Rows[i].Cells[1].Value + "'");
            MessageBox.Show("data updated");
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(string.Format("{0}\\PLU.txt",txtbrowse.Text));
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j == 4)
                    {
                        if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "KG")
                        {
                            writer.Write("1");
                        }
                        else
                        {
                            writer.Write("2");
                        }
                    }
                    else
                    {
                        writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());

                    }
                    if (j != dataGridView1.Columns.Count - 1)
                    {
                        writer.Write(",");
                    }


                }
                writer.WriteLine();
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void bntbrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            fdb.ShowNewFolderButton = true;
            if (fdb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtbrowse.Text = fdb.SelectedPath;
        


        }

        private void txtbrowse_TextChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}