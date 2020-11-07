using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DiscordRPC;
using DiscordRPC.Logging;


namespace Skid_Lookup
{ 
    public partial class Form1 : MetroForm
    {
        private WebClient wb;
        public DiscordRpcClient client;
        bool initalized = false;

        public Form1()
        {
            this.wb = new WebClient();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            initalized = true;
            client = new DiscordRpcClient("765685233176805386");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();

            if (initalized == false)
            {
                MessageBox.Show("You need to initialize app first!");
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = "GeoLocating a skid",
                    State = "www.skidforum.xyz",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = "main",
                        LargeImageText = "www.skidforum.xyz",
                        SmallImageText = "https://discord.gg/4nuq8fx",
                        SmallImageKey = "main"
                    }
                }); ;
            }
            outputbox.Text = this.wb.DownloadString(string.Format("http://ip-api.com/line/" + this.IPAddress.Text));

        }

        private void ToolsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            initalized = true;
            client = new DiscordRpcClient("765685233176805386");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();

            if (initalized == false)
            {
                MessageBox.Show("You need to initialize app first!");
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = "Best Forum 2020",
                    State = "www.skidforum.xyz",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = "main",
                        LargeImageText = "www.skidforum.xyz",
                        SmallImageText = "https://discord.gg/4nuq8fx",
                        SmallImageKey = "main"
                    }
                }); ;
            }
            outputbox.Text = "";
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            initalized = true;
            client = new DiscordRpcClient("765685233176805386");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();

            if (initalized == false)
            {
                MessageBox.Show("You need to initialize app first!");
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = "Saving some important shit",
                    State = "www.skidforum.xyz",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = "main",
                        LargeImageText = "www.skidforum.xyz",
                        SmallImageText = "https://discord.gg/4nuq8fx",
                        SmallImageKey = "main"
                    }
                }); ;
            }
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Documents(*.txt)|*.txt|All Files(*.*)|*.*";
                saveFileDialog.Title = "Save Results";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    this.outputbox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                this.Text = saveFileDialog.FileName;

            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("Something went wrong :/", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }


        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            initalized = true;
            client = new DiscordRpcClient("765685233176805386");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();

            if (initalized == false)
            {
                MessageBox.Show("You need to initialize app first!");
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = "PortScanning some skids.",
                    State = "www.skidforum.xyz",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = "main",
                        LargeImageText = "www.skidforum.xyz",
                        SmallImageText = "https://discord.gg/4nuq8fx",
                        SmallImageKey = "main"
                    }
                }); ;
            }
            outputbox.Text = this.wb.DownloadString(string.Format("https://api.hackertarget.com/nmap/?q=" + this.IPAddress.Text));
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            initalized = true;
            client = new DiscordRpcClient("765685233176805386");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();

            if (initalized == false)
            {
                MessageBox.Show("You need to initialize app first!");
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = "Pinging skids",
                    State = "www.skidforum.xyz",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = "main",
                        LargeImageText = "www.skidforum.xyz",
                        SmallImageText = "https://discord.gg/4nuq8fx",
                        SmallImageKey = "main"
                    }
                }); ;
            }
            outputbox.Text = this.wb.DownloadString(string.Format("https://api.hackertarget.com/nping/?q=" + this.IPAddress.Text));
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            initalized = true;
            client = new DiscordRpcClient("765685233176805386");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();

            if (initalized == false)
            {
                MessageBox.Show("You need to initialize app first!");
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = "Revese Ip Lookup",
                    State = "www.skidforum.xyz",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = "main",
                        LargeImageText = "www.skidforum.xyz",
                        SmallImageText = "https://discord.gg/4nuq8fx",
                        SmallImageKey = "main"
                    }
                }); ;
            }
            outputbox.Text = this.wb.DownloadString(string.Format("https://api.hackertarget.com/reverseiplookup/?q=" + this.IPAddress.Text));
        }
    }
}
