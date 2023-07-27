using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama_Final
{
    public partial class Player_1 : Form
    {
        public Player_1()
        {
            InitializeComponent();
        }

        private void Player_1_Load(object sender, EventArgs e)
        {

        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ir = new Dificultad();
            ir.Show();
            this.Hide();
        }
    }
}
