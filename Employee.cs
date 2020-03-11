using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using FloSDK;
using System.Data.SqlClient;

namespace Certificate._1
{
    public partial class Employee : Form
    {
        
        public Employee()
        {
            InitializeComponent();
            password_btn.PasswordChar = '*';
            
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=BT1707113\SQLEXPRESS02;Initial Catalog=root;Integrated Security=True"); 
            String query ="Select * from employee where username= '" + user_btn.Text.Trim() + "' and password= '" + password_btn.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
            {
                login1 ob = new login1();
                this.Hide();
                ob.Show();
            }    
            else
            {
                MessageBox.Show("username or password incorrect");
            }
        }
        }
    }

    

