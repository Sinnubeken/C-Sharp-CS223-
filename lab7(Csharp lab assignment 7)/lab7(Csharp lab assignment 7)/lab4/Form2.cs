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
        public string username { get; set; }
        public Form2(String user)
        {
            InitializeComponent();
            username = user;
            label7.Text = user;
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
            catch (Exception ex)
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


            if (!string.IsNullOrEmpty(number.Text) && !string.IsNullOrEmpty(count.Text) && !string.IsNullOrEmpty(inventory.Text) && result == true)
            {
                string message = " ";
                foreach (var item in chklist.CheckedItems)
                {
                    message = message + item.ToString();
                    MessageBox.Show(message);
                }

                bool b1 = rb1.Checked;
                if (b1)
                    MessageBox.Show("simple");
                bool b2 = rb2.Checked;
                if (b2)
                    MessageBox.Show("varaible product");


                bool b3 = rb1.Checked;
                if (b3)
                    MessageBox.Show("payment on delivery");
                bool b4 = rb2.Checked;
                if (b4)
                    MessageBox.Show("paypal");

                Class1 c = new Class1
                {
                    number = number.Text,
                    inventory = inventory.Text,
                    objectname = objectname.Text,
                    count = count.Text,
                    price = price.Text,
                    isavaliable = isavaliable.Checked,
                };

                c.save();
                //displayallproducts dp = new displayallproducts();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gb2_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void displaytable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
