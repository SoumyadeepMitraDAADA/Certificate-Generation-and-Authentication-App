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
using word = Microsoft.Office.Interop.Word;
using System.Configuration;
using FloSDK.Methods;
using FloSDK.Exceptions;
using Newtonsoft.Json.Linq;

namespace Certificate._1

{
    public partial class Download : Form
    {
        int y;
        string gd;
        public Download(string str2, string str3, int str4, string str5)
        {
            InitializeComponent();
            label2.Text = str2;
            issued.Text = str3;
            y = str4;
             gd = str5;
            if (Convert.ToInt32(issued.Text) == 1)
            {
                button1.Visible = true;
                label1.Text = "Certificate issued";
            }
               else if (Convert.ToInt32(issued.Text) == -1)
            {
                button1.Visible = false;
                label1.Text = "intern not upto the mark";
               
            }
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=BT1707113\SQLEXPRESS02;Initial Catalog=root;Integrated Security=True");
            con.Open();

            if (Convert.ToInt32(issued.Text) == 1)
            {
              
                string i = Convert.ToString(label2.Text);
                word.Application app = new word.Application();
                app.Visible = false;

                //load Document
                word.Document doc = null;
                string filename = "D:\\Course-Completion-Certificate.docx";
                
                string[] temp = new string[7];
                temp = readSQL(i);
                object destination= "E:\\Certificates\\Certificate" + temp[1].ToString() + ".doc";
                string dest = "E:\\Certificates\\Certificate" + temp[1].ToString() + ".doc";
                System.IO.File.Copy(filename, dest, true);
                object missing = Type.Missing;
                doc = app.Documents.Open(destination, missing, missing);
                app.Selection.Find.ClearFormatting();
                app.Selection.Find.Replacement.ClearFormatting();

                app.Selection.Find.Execute("<course>", missing, missing, missing, missing, missing, missing, missing, missing, temp[0], 2);
                app.Selection.Find.Execute("<name>", missing, missing, missing, missing, missing, missing, missing, missing, temp[1], 2);
                app.Selection.Find.Execute("<guardian>", missing, missing, missing, missing, missing, missing, missing, missing, temp[2], 2);
                app.Selection.Find.Execute("<doj>", missing, missing, missing, missing, missing, missing, missing, missing, temp[3], 2);
                app.Selection.Find.Execute("<doc>", missing, missing, missing, missing, missing, missing, missing, missing, temp[4], 2);
                app.Selection.Find.Execute("<doi>", missing, missing, missing, missing, missing, missing, missing, missing, temp[5], 2);
                app.Selection.Find.Execute("<tid>", missing, missing, missing, missing, missing, missing, missing, missing, temp[6], 2);
                object SaveAsFile = (object)"E:\\Certificates\\Certificate" + temp[1].ToString() + ".doc";
                doc.SaveAs2(SaveAsFile, missing, missing, missing);
                MessageBox.Show("the intern Certificate is Downloaded on the System");
                doc.Close(false, missing, missing);
                app.Quit(false, false, false);
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(app);
               


                    String query = "Select * from skills where Intern_name=  '" + label2.Text + "'";
                SqlCommand sda = new SqlCommand(query, con);
                SqlDataReader dr = sda.ExecuteReader();
                if (dr.Read())
                {
                    Certificate ob = new Certificate(dr["Intern_name"].ToString(), dr["internshiptype"].ToString(),y,gd,dr["DOJ"].ToString(),dr["DOC"].ToString(),dr["guardian"].ToString());
                    ob.Show();
                    this.Hide();
                }
                
            }
           
        }
        private string[] readSQL(string index)
        {
            string[] values = new string[7];
            //Making the String for query
            string qry = "";
            qry = "select * from skills where Intern_name='" + Convert.ToString(index) + "'";
            SqlConnection con = new SqlConnection(@"Data Source=BT1707113\SQLEXPRESS02;Initial Catalog=root;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            //Storing value from SqlDataReader To String Array
            if (sdr.Read())
            {
                values[0] = sdr["internshiptype"].ToString(); //get ID
                values[1] = sdr["Intern_name"].ToString(); //get Name
                values[2] = sdr["guardian"].ToString(); // get Sex
                values[3] = sdr["DOJ"].ToString(); //get Age
                values[4] = sdr["DOC"].ToString();//get Work
                DateTime now = DateTime.Now;
                values[5] = now.ToString();
                values[6] = sdr["t_id"].ToString();
                con.Close();
                return values;
            }
            else
            {
                MessageBox.Show("Incorrect Index");
                con.Close();
                return null;
            }




        }

        private void Download_Load(object sender, EventArgs e)
        {

        }
    }
}
