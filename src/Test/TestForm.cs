using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AboutBox;

namespace Test
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = new AboutBox.AboutForm(this.Icon.ToBitmap());
            a.ShowDialog();

            var b = new AboutBox1();
            b.Show();
        }
    }
}
