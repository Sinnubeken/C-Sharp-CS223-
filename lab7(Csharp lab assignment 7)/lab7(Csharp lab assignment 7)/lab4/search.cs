using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab4
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var f=ptsearch.Text;
            var product = Class1.findone(tsearch.Text);

            if (product == null)
            {
                MessageBox.Show("nothing is entered");
            }
            else
                lprice.Text = null;
                lprice.Text = product.price;
                lnumber.Text = product.number;
            lcount.Text = product.count;
            linventory.Text = product.inventory;
            lobjname.Text = product.objectname;
                
              // Class1.findone(f);
              //ss.DataSource = null;
              //ss.DataSource = Class1.findone(tsearch.Text);






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbshow_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ss_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lprice_Click(object sender, EventArgs e)
        {

        }
    }
}
