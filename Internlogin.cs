using FloSDK.Exceptions;
using FloSDK.Methods;
using MessagingToolkit.QRCode.Codec.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Configuration;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace Certificate._1
{
    public partial class Internlogin : Form
    {
        
        public Internlogin()
        {
            InitializeComponent();
            pas.PasswordChar = '*';
            
        }
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

        public string decrpyt(string ps)
        {
            int count = 0;
            int i = 0;
            string pass = "";
            for (i = 0; i < ps.Length; i++)
            {
                if (count == 10)
                {
                    break;
                }
                else
                {
                    if (ps[i] == '-' && ps[i + 1] == '-')
                    {
                        count++;
                        i = i + 1;
                    }
                }

            }
            int j;
            for (j = i; j < ps.Length; j++)
            {
                pass = pass + ps[j];
            }
            return pass;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = ConfigurationManager.AppSettings.Get("rpcusername");
            string past = ConfigurationManager.AppSettings.Get("rpcpassword");
            string url1 = ConfigurationManager.AppSettings.Get("wallet_url");
            string port = ConfigurationManager.AppSettings.Get("wallet_port");

            RpcMethods rpc = new RpcMethods(username, past, url1, port);

            string us = response.Text;
            string p = ComputeSha256Hash(pas.Text).ToString();


            try
            {
                JObject obj = JObject.Parse(rpc.GetRawTransaction(us));
                string flodata = "";
                if (string.IsNullOrEmpty(obj["error"].ToString()))
                {
                    flodata = obj["result"]["floData"].ToString();
                    string passcode = decrpyt(flodata).ToString();
                    if (passcode.Equals(p))
                    {
                        response.Text = "****SUCCESSFULLY LOGGED-IN****";
                        response.ForeColor = Color.DarkOliveGreen;
                        response.Visible = true;
                        verification ob = new verification(us);
                        this.Hide();
                        ob.Show();
                    }
                    else
                    {
                        response.Text = "****INCORRECT PASSWORD****";
                        response.ForeColor = Color.Firebrick;
                        response.Visible = true;
                    }
                }
                else
                {
                    Console.WriteLine("Error searching the transactions");
                    response.Text = "****BLOCKCHAIN ERROR****";
                    response.ForeColor = Color.Blue;
                    response.Visible = true;
                }
              
            }
            catch (RpcInternalServerErrorException ex)
            {
                var err_code = 0;
                var err_message = string.Empty;
                if (ex.RpcErrorCode.GetHashCode() != 0)
                {
                    err_code = ex.RpcErrorCode.GetHashCode();
                    err_message = ex.RpcErrorCode.ToString();

                }
                Console.WriteLine("Exception:" + err_code + " " + err_message);
                response.Text = "****BLOCKCHAIN ERROR****";
                response.ForeColor = Color.Blue;
                response.Visible = true;
            }
            catch (Exception ex1)
            {
                Console.WriteLine("Exception:" + ex1);
                response.Text = "****VISUAL STUDIO ERROR****"+ex1;
                response.ForeColor = Color.Red;
                response.Visible = true;
            }

        }


        private void Add_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    qr.Image = Image.FromFile(ofd.FileName);
                    MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                    response.Text = decoder.Decode(new QRCodeBitmapImage(qr.Image as Bitmap));




                }
            }



        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Internsignup ob = new Internsignup();
            this.Hide();
            ob.Show();
        }
    }
}
