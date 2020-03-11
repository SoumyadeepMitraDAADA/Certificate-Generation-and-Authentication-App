using System;
using FloSDK.Methods;
using FloSDK.Exceptions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace Certificate._1
{
    public partial class Internsignup : Form
    {
        public static string address = "ocGQVknDefRbEx1pLJDbFamAvh8izus3bH";
        public string url = "https://testnet.flocha.in/";
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public Internsignup()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = ConfigurationManager.AppSettings.Get("rpcusername");
            string passcode = ConfigurationManager.AppSettings.Get("rpcpassword");
            string url1 = ConfigurationManager.AppSettings.Get("wallet_url");
            string port = ConfigurationManager.AppSettings.Get("wallet_port");

            RpcMethods obj = new RpcMethods(username, passcode, url1, port);

            try
            {
                
                string fn = first.Text.Trim();
                string ln = last.Text.Trim();
                string c = college.Text.Trim();
                string r = roll.Text.Trim();
                string m = mobile.Text.Trim();
                string em = email.Text.Trim();
                string p = pass.Text;
                string t = type.Text.Trim();
                string g = guardian.Text.Trim();
                string YYYY = yj.Text.Trim();
                string MM = mj.Text.Trim();
                string DD = dj.Text.Trim();
                string yyyy = yc.Text.Trim();
                string mm = mc.Text.Trim();
                string dd = dc.Text.Trim();
                string jdate = DD + "/" + MM + "/" + YYYY;
                string cdate = dd + "/" + mm + "/" + yyyy;
                string n = fn + " " + ln;
                string txid = "";
                string qry = string.Empty;
                string message = fn + "--" + ln + "--" + c + "--" + r + "--" + m + "--" + em + "--" + t + "--"+ g + "--" + jdate + "--" + cdate + "--" + ComputeSha256Hash(p);
                
               

                JObject jobj = JObject.Parse(obj.SendToAddress(address, 1M, "test send", "testing 123", false, false, 1, "UNSET", message));
                if (string.IsNullOrEmpty(jobj["error"].ToString()))
                {
                    url += jobj["result"].ToString();

                    response.Text = "MESSAGE SENT SUCCESSFULLY";
                    response.ForeColor = Color.Blue;
                    response.Visible = true;
                    txid = jobj["result"].ToString();
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {

                            MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                            encoder.QRCodeScale = 8;
                            Bitmap bmp = encoder.Encode(jobj["result"].ToString());

                            qr.Image = bmp;

                            bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                        }
                    }

                    SqlConnection conn = new SqlConnection(@"Data Source=BT1707113\SQLEXPRESS02;Initial Catalog=root;Integrated Security=True");
                    conn.Open();
                    qry = "insert into skills values ('" + n + "','" + txid + "',NULL,NULL,NULL,NULL,NULL,NULL,'0','" + t + "','" + jdate + "','" + cdate + "','" + g + "');";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Internlogin ob = new Internlogin();
                    this.Hide();
                    ob.Show();

                }
                else
                {

                    response.Text = "MESSAGE WAS NOT SENT";
                    response.ForeColor = Color.Blue;
                    response.Visible = true;
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
                Console.WriteLine("Error:" + err_code + "\n" + err_message);



            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex);
                response.Text = "Message Not Sent";
                response.Visible = true;

            }




        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Roll_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Yj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            }

        private void Mj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Dj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Yc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Mc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Dc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
