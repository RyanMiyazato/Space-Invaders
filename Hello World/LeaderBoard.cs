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
    public partial class LeaderBoard : Form
    {
        private InitalForm _initalForm;
        public LeaderBoard()
        {
            
        }
        public LeaderBoard(InitalForm initalForm)
        {
            _initalForm = initalForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _initalForm.Show();
        }
    }
}
