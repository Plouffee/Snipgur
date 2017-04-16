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

namespace Snipgur
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string curDir = Directory.GetCurrentDirectory();
            this.webBrowser1.Url = new Uri(String.Format("file:///{0}/webpages/login.html", curDir));
        }
    }
}
