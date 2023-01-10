using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Width = this.Width - 30;
            webBrowser1.Height = this.Height - 122;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnavancar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            webBrowser1.Width = this.Width - 30;
            webBrowser1.Height = this.Height - 122;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            webBrowser1.Dispose();
        }

        private void btnir_Click(object sender, EventArgs e)
        {
            var uri = new Uri(txturl.Text);
            webBrowser1.Url = uri;
        }

        private void btnir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
