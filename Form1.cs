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
            string prntscHtml;
            string imageUrl;
            client.Headers.Add("user-agent", "real browser for real people");

            if (IsId) prntscHtml = client.DownloadString("https://prnt.sc/" + input);
            else prntscHtml = client.DownloadString(input);
            
            //this is the regex for the image url in the html
            Regex prntscRegex = new Regex(@"https://image\.prntscr\.com/image/([a-zA-Z0-9_-]+)\.[a-zA-Z]+");
            Regex imgurRegex = new Regex(@"https://i\.imgur\.com/([a-zA-Z0-9_-]+)\.[a-zA-Z]+");

            if (prntscRegex.IsMatch(prntscHtml)) imageUrl = prntscRegex.Match(prntscHtml).ToString(); //prnt.sc
            else imageUrl = imgurRegex.Match(prntscHtml).ToString(); //imgur

            return imageUrl.Length > 0 ? imageUrl : "No image link found. I am personally attacked by and blame you for this, " + Environment.UserName + ".";
        }
        public void ManageInput(string input, char key, bool IsId)
        {
            if (key == (char)Keys.Enter)
            {
                UrlLabel.Text = GrabUrl(input, IsId);
                ActiveForm.Width = UrlLabel.Width + 33;
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
    }
}
