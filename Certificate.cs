using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FloSDK.Methods;
using FloSDK.Exceptions;
using Newtonsoft.Json.Linq;

namespace Certificate._1
{
    public partial class Certificate : Form
    {
        public static string address = "ocGQVknDefRbEx1pLJDbFamAvh8izus3bH";
        public string url = "https://testnet.flocha.in/tx/";
        public Certificate(string str1, string str2, int str4, string str5, string str6, string str7, string str8)
        {
            InitializeComponent();
            name.Text = str1;
            course.Text = str2;
            marks.Text = str4.ToString();
            grade.Text = str5;
            jdate.Text = str6;
            cdate.Text = str7;
            DateTime now = DateTime.Now;
            parentname.Text = str8;
            string username = ConfigurationManager.AppSettings.Get("rpcusername");
            string passcode = ConfigurationManager.AppSettings.Get("rpcpassword");
            string url1 = ConfigurationManager.AppSettings.Get("wallet_url");
            string port = ConfigurationManager.AppSettings.Get("wallet_port");

            RpcMethods obj = new RpcMethods(username, passcode, url1, port);
            try
            {
                string flodata = str1 + "**" + str8 + "**" + str2 + "**" + str5 + "**" + str6 + "**" + str7 + "**" +now.ToString()+ "**" + "DIGITAL SIGNATURE BY:-366piTECH";
                JObject Jobj = JObject.Parse(obj.SendToAddress(address, 1M, "test send", "testing 123", false, false, 1, "UNSET", flodata));
                if (string.IsNullOrEmpty(Jobj["error"].ToString()))
                {
                    url += Jobj["result"].ToString();
                }
            }
            catch (RpcInternalServerErrorException ex1)
            {
                var err_code = 0;
                string err_message = "";
                if (ex1.RpcErrorCode.GetHashCode() != 0)
                {
                    err_code = ex1.RpcErrorCode.GetHashCode();
                    err_message = ex1.RpcErrorCode.ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex);
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
                {

                }

        private void Certificate_Load(object sender, EventArgs e)
        {

        }

        private void Url2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
