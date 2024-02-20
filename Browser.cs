
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuelOS
{
    public partial class Browser : UserControl
    {
        string url = "https://www.google.com";
        public Browser()
        {
            InitializeComponent();
        }

        private async Task GetWebView2()
        {
            await webView.EnsureCoreWebView2Async();
        }

        private async void Browser_Load(object sender, EventArgs e)
        {
            await GetWebView2();
            openBrowser();
            toSearchTxt.Text = url;
        }

        private void openBrowser()
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out Uri resultUri))
            {
                webView.CoreWebView2.Navigate(url);
            }
            else
            {
                // La cadena no es una URL válida, mostrar un mensaje de error o realizar alguna acción adecuada
                MessageBox.Show("La cadena proporcionada no es una URL válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toSearchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Buscar al presionar Enter
            if (e.KeyChar == (char)13)
            {
                url = toSearchTxt.Text;
                openBrowser();
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Reload();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoBack();

        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoForward();
        }

        private void webView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            toSearchTxt.Text = webView.CoreWebView2.Source;
        }

        private void webView_Click(object sender, EventArgs e)
        {

        }
    }
}
