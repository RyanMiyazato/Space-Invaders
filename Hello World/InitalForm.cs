using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class InitalForm : Form
    {
        public InitalForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Game(this);
            this.Hide();
            form.Show();
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            var form = new LeaderBoard(this);
            this.Hide();
            form.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

