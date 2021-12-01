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

namespace prntsc_viewer_because_cloudflare_is_a_bitch
{
    public partial class Form1 : Form
    {
        WebClient client = new WebClient();
        public Form1()
        {
            InitializeComponent();
        }
        public string GrabUrl(string input, bool IsId)
        {
            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36");

            string prntscHtml;
            switch (IsId)
            {
                case false:
                    prntscHtml = client.DownloadString(input); break;
                default:
                    prntscHtml = client.DownloadString("https://prnt.sc/" + input); break;
            }

            Regex prntscRegex = new Regex(@"https://image\.prntscr\.com/image/([a-zA-Z0-9_-]+)\.png");
            Regex imgurRegex = new Regex(@"https://i\.imgur\.com/([a-zA-Z0-9_-]+)\.png");

            bool prntscMatches = prntscRegex.IsMatch(prntscHtml);

            string imageUrl;
            if (prntscMatches) { imageUrl = prntscRegex.Match(prntscHtml).ToString(); }
            else { imageUrl = imgurRegex.Match(prntscHtml).ToString(); }

            switch (imageUrl)
            {
                case "":
                    return "Link returned with nothing!";
                default:
                    return imageUrl;
            }
        }
        public void ManageInput(string input, char key, bool IsId)
        {
            if (key == (char)Keys.Enter)
            {
                UrlLabel.Text = GrabUrl(input, IsId);
                ActiveForm.Width = UrlLabel.Width + 33;
                ActiveForm.Height = 133;
                if (BrowserCheckbox.Checked) { Process.Start(GrabUrl(input, IsId)); }
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
    }
}
