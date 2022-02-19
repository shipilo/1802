using System;
using System.Drawing;
using System.Windows.Forms;

namespace _1802
{
    public partial class Form2 : Form
    {
        public Form2(int x, int y, int w, int h)
        {
            InitializeComponent();
            this.Location = new Point(x, y);
            this.Size = new Size(w, h);
            webBrowser1.Url = new Uri("http://google.com");
        }
    }
}
