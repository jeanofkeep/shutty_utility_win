using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utility
{
    public partial class Form2 : Form
    {
        private readonly Form1 _owner;
        public Form2(Form1 owner)
        {
            InitializeComponent();
            _owner = owner;
            this.ShowInTaskbar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _owner.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 support = new Form3(_owner);
            support.ShowDialog();
            this.Close();
        }
    }
}
