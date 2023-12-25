using SyncFileExchange.Client;
using System.Net;

namespace SyncFileExchange
{
    public partial class MainFrame : Form
    {
        private readonly SFEClient Client;
        public MainFrame(string accountToken)
        {
            Client = new SFEClient(accountToken);
            Client.setToken(accountToken);
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void addFile_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    await Client.UploadFile(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
