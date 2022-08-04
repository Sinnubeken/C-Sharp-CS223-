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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
             Form2 screen = new Form2("");
            screen.MdiParent = this;
            screen.Show();
        }

        private void displayStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            displayallproducts screen = new displayallproducts();
            screen.MdiParent = this;
            screen.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (activescreen != null)
            {
                activescreen.Close();
            }
            search s = new search();
            s.MdiParent = this;
            s.Show();
            
        }
    }
}
