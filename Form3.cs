using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utility
{
    public partial class Form3 : Form
    {
        private readonly Form1 _owner;
        public Form3(Form1 owner)
        {
            InitializeComponent();
            _owner = owner;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 info = new Form2(_owner);
            info.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }
    }
}
