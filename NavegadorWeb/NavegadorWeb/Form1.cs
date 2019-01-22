using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtURL.Text = "www.google.com.ar";
            webBrowser1.Navigate(txtURL.Text);
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void webBrowser1_RegionChanged(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                pbCarga.Value = Convert.ToInt32(e.CurrentProgress);
                pbCarga.Maximum = Convert.ToInt32(e.MaximumProgress);

            }
            catch (Exception ex) { }
        }
    }
}
