using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certificate._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Internlogin ob = new Internlogin();
            this.Hide();
            ob.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Employee ob = new Employee();
            this.Hide();
            ob.Show();
        }
    }
}
