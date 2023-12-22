using SyncFileExchange.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncFileExchange
{
    public partial class AuthFrame : Form
    {
        private readonly SFEClient client;
        private string input_email = "";
        private string input_password = "";
        public AuthFrame()
        {
            Console.WriteLine("Load AUTH");
            client = new SFEClient();
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Logging in...");
            var res = client.login("email", "pass");
            Console.WriteLine(res);
            DialogResult = DialogResult.OK;
        }

        private async void signup_btn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Register...");
            try {
                var res = await client.registerAccount(input_email, input_password);
              
                Debug.WriteLine(res);
                DialogResult = DialogResult.OK;
            }
            catch (HttpRequestException httpException)
            {
                Debug.WriteLine(httpException);
            }
        }

        private void emailLogin_tb_TextChanged(object sender, EventArgs e)
        {
            input_email = emailLogin_tb.Text;
        }

        private void passwordLogin_tb_TextChanged(object sender, EventArgs e)
        {
            input_password = passwordLogin_tb.Text;
        }
    }
}
