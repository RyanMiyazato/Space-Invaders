using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Game : Form
    {
        private InitalForm _initalForm;

        public Game()
        {
            
        }
        public Game(InitalForm initalForm)
        {
            _initalForm = initalForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
