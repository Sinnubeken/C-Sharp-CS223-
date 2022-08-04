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
    public partial class displayallproducts : Form
    {
        public displayallproducts()
        {
            InitializeComponent();
        }
       
              
        private void displayallproduct_Load(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            
            displayall.DataSource = null;
            displayall.DataSource = Class1.getall();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
