using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Net.Http;

namespace prntsc_imgflip_viewer
{
    public partial class Form1 : Form
    {
        bool isPrntsc = true;
        WebClient client = new WebClient();
        Regex prntscRegex = new Regex(@"https://image\.prntscr\.com/image/([a-zA-Z0-9_-]+)\.[a-zA-Z]+");
        Regex imgurRegex = new Regex(@"https://i\.imgur\.com/([a-zA-Z0-9_-]+)\.[a-zA-Z]+");
        Regex imgflipRegex = new Regex(@"//i\.imgflip\.com/([a-zA-Z0-9_-]+)\.[a-zA-Z]+");
        public Form1()
        {
            InitializeComponent();
        }
        public string GrabUrl(string input, bool IsId)
        {
            string downloadedHtml;
            string imageUrl;
            client.Headers.Add("user-agent", "real browser for real people");

            if (isPrntsc)
            {
                if (IsId) downloadedHtml = client.DownloadString("https://prnt.sc/" + input);
                else downloadedHtml = client.DownloadString(input);

                if (prntscRegex.IsMatch(downloadedHtml)) imageUrl = prntscRegex.Match(downloadedHtml).ToString();
                else imageUrl = imgurRegex.Match(downloadedHtml).ToString();

                return imageUrl.Length > 0 ? imageUrl : "No image link found. I am personally attacked by and blame you for this, " + Environment.UserName + ".";
            }
            else
            {
                if (IsId) {
                    try
                    {
                        downloadedHtml = client.DownloadString("https://imgflip.com/i/" + input);
                    }
                    catch
                    {
                        return "No image link found. I am personally attacked by and blame you for this, " + Environment.UserName + ".";
                    }
                } else downloadedHtml = client.DownloadString(input);

                return "https:" + imgflipRegex.Match(downloadedHtml).ToString();
            }
        }
        public void ManageInput(string input, char key, bool IsId)
        {
            if (key == (char)Keys.Enter)
            {
                UrlLabel.Text = GrabUrl(input, IsId);

                if (UrlLabel.Width + 33 < 286) ActiveForm.Width = 286;
                else ActiveForm.Width = UrlLabel.Width + 33;
                ActiveForm.Height = 133;

                if (BrowserCheckbox.Checked && UrlLabel.Text != "No image link found. I am personally attacked by and blame you for this, " + Environment.UserName + ".")
                {
                    Process.Start(UrlLabel.Text);
                }
            }
        }
        private void IdInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManageInput(IdInput.Text, e.KeyChar, true);
        }

        private void LinkInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManageInput(LinkInput.Text, e.KeyChar, false);
        }

        private void IdButton_Click(object sender, EventArgs e)
        {
            ManageInput(IdInput.Text, (char)Keys.Enter, true);
        }

        private void LinkButton_Click(object sender, EventArgs e)
        {
            ManageInput(LinkInput.Text, (char)Keys.Enter, false);
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            isPrntsc = !isPrntsc;
            if (isPrntsc) ModeLabel.Text = "Mode: prnt.sc";
            else ModeLabel.Text = "Mode: imgflip";
        }
    }
}
