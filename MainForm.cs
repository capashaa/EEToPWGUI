using Microsoft.Extensions.Configuration;
using PixelPilot.PixelGameClient;
using PixelPilot;
using EELVL;
using PixelPilot.PixelGameClient.Messages.Received;
using PixelPilot.PixelGameClient.Messages.Send;
namespace EEtoPWGUI
{
    public partial class MainForm : Form
    {
        public string FileName { get { return txtbFileName.Text; } }
        private static Thread? thread;
        private static PixelPilotClient? client_;
        private bool stopthread = false;
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "EELVL *.eelvl|*.eelvl";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtbFileName.Text = ofd.FileName;
            }
        }
        private void StartThread(object data)
        {

            thread = new Thread(() => RunThread());
            thread.Start();
        }
        private void RunThread()
        {

            BlockUploader.PlaceBlocks(client_, txtbFileName.Text);
            if (stopthread) { return; }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Upload")
            {
                button1.Text = "Stop";

                // Create a client.
                if (!string.IsNullOrEmpty(txtbAuthTokenOrEmail.Text) && !string.IsNullOrEmpty(txtbWorldId.Text))
                {
                    client_ = new PixelPilotClient(txtbAuthTokenOrEmail.Text, false);
                    client_.OnClientConnected += StartThread;

                    await client_.Connect(txtbWorldId.Text);

                }
            }
            if (button1.Text == "Stop")
            {
                if (client_ != null && client_.IsConnected)
                {

                    client_?.Disconnect();
                    if (thread != null && thread.IsAlive)
                    {
                        stopthread = true;
                    }
                    button1.Text = "Upload";
                }
            }
        }
    }
}
