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
        public string DownloadImage(string id)
        {
            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36");

            string prntscHtml = client.DownloadString("https://prnt.sc/" + id);
            Regex prntscRegex = new Regex(@"https://image\.prntscr\.com/image/([a-zA-Z0-9_-]+)\.png");
            Regex imgurRegex = new Regex(@"https://i\.imgur\.com/([a-zA-Z0-9_-]+)\.png");
            bool prntscMatches = prntscRegex.IsMatch(prntscHtml);
            string imageUrl;
            if (prntscMatches) { imageUrl = prntscRegex.Match(prntscHtml).ToString(); }
            else { imageUrl = imgurRegex.Match(prntscHtml).ToString(); }


            client.Headers.Add("Access-Control-Allow-Origin", "*");
            client.Headers.Add("Access-Control-Allow-Methods", "GET, OPTIONS");
            client.Headers.Add("Access-Control-Allow-Headers", "DNT,X-CustomHeader,Keep-Alive,User-Agent,X-Requested-With,If-Modified-Since,Cache-Control,Content-Type");

            /*try
            {
                imageBytes = client.DownloadData(imageUrl.Value);
            }
            catch (WebException ex)
            {
                WebException Exception = ex;
                HttpWebResponse Response = (HttpWebResponse)Exception.Response;
                StreamReader WebStream = new StreamReader(Response.GetResponseStream(), System.Text.Encoding.GetEncoding("utf-8"));
                imageBytes = Encoding.UTF8.GetBytes(WebStream.ReadToEnd());
                Debug.WriteLine(imageBytes);
                Debug.WriteLine(WebStream.ReadToEnd());
            }*/
            //HttpWebRequest imageRequest = (HttpWebRequest)WebRequest.Create(imageUrl.Value);
            //imageRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36";
            //imageRequest.UseDefaultCredentials = true;
            //HttpWebResponse imageResponse = (HttpWebResponse)imageRequest.GetResponse();
            //Stream imageStream = imageResponse.GetResponseStream();
            switch (imageUrl)
            {
                case "":
                    return "Link returned with nothing!";
                default:
                    return imageUrl;
            }
        }

        private void idInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                urlLabel.Text = DownloadImage(idInput.Text);
                ActiveForm.Width = urlLabel.Width + 33;
                ActiveForm.Height = 113;
                if (checkBox1.Checked) { Process.Start(urlLabel.Text); }
            }
        }

        private void linkInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                urlLabel.Text = DownloadImage(linkInput.Text);
                ActiveForm.Width = urlLabel.Width + 33;
                ActiveForm.Height = 113;
                Process.Start(urlLabel.Text);
                if (checkBox1.Checked) { Process.Start(urlLabel.Text); }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
