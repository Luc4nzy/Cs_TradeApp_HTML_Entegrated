using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cs_TradeApp_HTML_Entegrated
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeWebView2();
        }
        private async void InitializeWebView2()
        {
            await webView21.EnsureCoreWebView2Async(null);
            string htmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TradeBot.html");
            webView21.Source = new Uri(htmlFilePath);
        }
    }
}
