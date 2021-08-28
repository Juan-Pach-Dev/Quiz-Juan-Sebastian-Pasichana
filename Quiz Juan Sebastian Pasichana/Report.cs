using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Juan_Sebastian_Pasichana
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public Report(String text)
        {
            InitializeComponent();
            rchtalmacenar.Text = text;
        }
    }
}
