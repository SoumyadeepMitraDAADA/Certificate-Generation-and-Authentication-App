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
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }

        public void Ok_Click(object sender, EventArgs e)
        {
            int count = 0;
            string str = text1.Text.Trim();
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < str.Length; i++)
            {
                if (string.Compare(str[i].ToString(), " ") == 0)
                {
                    count++;
                    if (count >= 2)
                    {
                        sb.Remove(i, 1);

                        i--;
                    }
                }
                str = sb.ToString();
            }
            str = sb.ToString();

            SqlConnection con = new SqlConnection(@"Data Source=BT1707113\SQLEXPRESS02;Initial Catalog=root;Integrated Security=True");
            con.Open();
            String query = "Select * from skills where Intern_name=  '" + str + "'"; 
            SqlCommand sda = new SqlCommand(query, con);
            SqlDataReader dr = sda.ExecuteReader();            
            if (dr.Read())
            {               
                Skillset obj2 = new Skillset(dr["internshiptype"].ToString(),dr["Intern_name"].ToString());               
                this.Hide();
                obj2.Show();                  
            }
            else
            {
                MessageBox.Show("Incorrect intern Name");
               
            }
        }

        private void Text1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
