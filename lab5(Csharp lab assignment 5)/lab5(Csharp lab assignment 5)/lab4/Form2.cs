using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Regex regex = new Regex("^[a-z]{2,5}$"); // $ - end of string //Regex regex = new Regex(@"^[a-z] {2}$");
            bool result = regex.IsMatch(objectname.Text);                                            // the @ is to check email, its outside b/c its needed // to check .com use . outside then ()
            //string g = result.ToString();
            if (result == false)
            {
                
               objname.SetError(objectname, "can only be char and can't be empty");
            }
            

            try
            {
                if (string.IsNullOrEmpty(number.Text))

                {
                    name.SetError(number, "its required");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

              
            if (string.IsNullOrEmpty(price.Text))

            {
                priceerror.SetError(price, "is required");

            }

            if (string.IsNullOrEmpty(inventory.Text))

            {
                inv.SetError(inventory, "is required");

            }

            if (string.IsNullOrEmpty(count.Text))

            {
                cnt.SetError(count, "is required");

            }


            if ( !string.IsNullOrEmpty(number.Text) &&  !string.IsNullOrEmpty(count.Text) && !string.IsNullOrEmpty(inventory.Text) && result == true)
            {
                Class1 c = new Class1
                {
                    number = number.Text,
                    inventory = inventory.Text,
                    objectname = objectname.Text,
                    count = count.Text,
                    price = price.Text,
                };
                c.save();
                displaytable.DataSource = null;
                displaytable.DataSource = Class1.getall();

                //MessageBox.Show(Class1.getall()); 

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void displaytable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
