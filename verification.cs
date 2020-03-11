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

namespace Certificate._1
{
    public partial class verification : Form
    {
        public verification(string str)
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=BT1707113\SQLEXPRESS02;Initial Catalog=root;Integrated Security=True");
            con.Open();
            String query = "Select * from skills where t_id=  '" + str + "'";
            SqlCommand sda = new SqlCommand(query, con);
            SqlDataReader dr = sda.ExecuteReader();
            if (dr.Read())
            {
                label2.Text = dr["Intern_name"].ToString();
                if (Convert.ToInt32(dr["issued"]) == 0)
                {
                    label3.Text = "Your certificate has not yet been issued";
                    label3.ForeColor = Color.Yellow;
                }
                else if (Convert.ToInt32(dr["issued"]) == -1)
                {
                    label3.Text = "Sorry!! you were not upto the mark";
                    label3.ForeColor = Color.Red;
                }
                else if (Convert.ToInt32(dr["issued"]) == 1)
                {
                    label3.Text = "Congo! You succesfully completed your internship,you will receive your certificate on your email";
                    label3.ForeColor = Color.Green;
                }
            }
            else
            {
                MessageBox.Show("wrong!");
            }

        }

        private void Verification_Load(object sender, EventArgs e)
        {

        }
    }
}
