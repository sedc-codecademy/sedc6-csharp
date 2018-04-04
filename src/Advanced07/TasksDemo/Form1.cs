using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksDemo
{
    public partial class Form1 : Form
    {
        Task downloadingStringTask = null;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void GoButton_Click(object sender, EventArgs e)
        {

            /// -------- -o------------------------o-------
            ///           \---------o---------o--/
            ///                      \-------/;
            
            //$.get("", function(response){ });
            //var result  = await new HttpClient().GetAsync("/sdfghjk");

            //var url = UrlTextBox.Text;
            //var wc = new WebClient();
            //var res = await wc.DownloadStringTaskAsync(new Uri (url));
            //await IncrementCountAsync();
            //ContentRichTextBox.Text = res;
        }

        Task IncrementCountAsync()
        {
            count++;
            HitCountLabel.Text = $"Count: {count}";
            return Task.CompletedTask;
        }

        private void HitCountButton_Click(object sender, EventArgs e)
        {
            count++;
            HitCountLabel.Text = $"Count: {count}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HitCountLabel.Text = $"Count: {count}";
        }
    }
}
