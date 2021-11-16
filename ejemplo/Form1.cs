using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo
{
    public partial class Form1 : Form
    {
        ventana2 v2 = new ventana2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult R = MessageBox.Show("Desea salir?","salir",MessageBoxButtons.YesNo);
            if (R==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Click_Click(object sender, EventArgs e)
        {
            v2.Show();

        }
    }
}
