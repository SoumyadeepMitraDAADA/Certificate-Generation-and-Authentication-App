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
    public partial class Skillset : Form
    {
        public Skillset(string str1,string str2)
        {
            InitializeComponent();
            type.Text = str1;
            Internname.Text = str2;
        }
        public void Label14_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Skillset_Load(object sender, EventArgs e)
        {
            
        }

        private void Label22_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=BT1707113\SQLEXPRESS02;Initial Catalog=root;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update skills set communication=@communication,coding=@coding,management=@management,designing=@designing,improvisation=@improvisation,coordination=@coordination where Intern_name='" + Internname.Text + "'", con);
            cmd.Parameters.Add("@communication", textBox1.Text);
            cmd.Parameters.Add("@coding", textBox2.Text);
            cmd.Parameters.Add("@management", textBox3.Text);
            cmd.Parameters.Add("@designing", textBox4.Text);
            cmd.Parameters.Add("@improvisation", textBox5.Text);
            cmd.Parameters.Add("@coordination", textBox6.Text);
            if (Convert.ToInt32(textBox1.Text) <= 10 && Convert.ToInt32(textBox2.Text) <= 10 && Convert.ToInt32(textBox3.Text) <= 10 && Convert.ToInt32(textBox4.Text) <= 10 && Convert.ToInt32(textBox5.Text) <= 10 && Convert.ToInt32(textBox6.Text) <= 10)
            {
                cmd.ExecuteNonQuery();
                this.Hide();
                int x = (((Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text)) * 100) / 60);
                string grade = "";
                if ((((Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToDecimal(textBox5.Text) + Convert.ToInt32(textBox6.Text)) * 100) / 60) >= 70)
                {
                    cmd = new SqlCommand("update skills set issued=1 where Intern_name='" + Internname.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    String query = "Select * from skills where Intern_name=  '" + Internname.Text + "'";
                    SqlCommand sda = new SqlCommand(query, con);
                    SqlDataReader dr = sda.ExecuteReader();
                    if (dr.Read())
                    {


                        if (x >= 70 && x <= 79)
                        {
                            grade = "C";
                        }
                        else if (x >= 80 && x <= 89)
                        {
                            grade = "B";

                        }
                        else if (x >= 90 && x <= 100)
                        {
                            grade = "A";
                        }
                        Download obj = new Download(Internname.Text, dr["issued"].ToString(), x, grade);
                        this.Hide();
                        obj.Show();
                    }
                }
                else
                {
                    cmd = new SqlCommand("update skills set issued=-1 where Intern_name='" + Internname.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    String query = "Select * from skills where Intern_name=  '" + Internname.Text + "'";
                    SqlCommand sda = new SqlCommand(query, con);
                    SqlDataReader dr = sda.ExecuteReader();
                    if (dr.Read())
                    {
                        Download obj = new Download(Internname.Text, dr["issued"].ToString(), x, grade);
                        this.Hide();
                        obj.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("value entered out of range");
            }

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar !='.')
            {
                e.Handled = true;
            }

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {

                e.Handled = true;
            }
        }

        private void Skillset_Load_1(object sender, EventArgs e)
        {

        }
    }
}
