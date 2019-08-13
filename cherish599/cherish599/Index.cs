using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace huodong
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            string path1 =path+ @"\1.jpg";
            string path2 =path+ @"\2.jpg";
            this.pictureBox1.Image = Image.FromFile(path1);
            this.pictureBox2.Image = Image.FromFile(path2);
        }

    }
}
